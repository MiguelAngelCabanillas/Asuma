using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Drawing;

namespace Asuma
{
    public class FTPClient
    {

        public static bool ftpOn = false;
        public static bool ftpBackupOn = false;
        // The hostname or IP address of the FTP server
        private string _remoteHost;

        // The remote username
        private string _remoteUser;

        // Password for the remote user
        private string _remotePass;

        public FTPClient(string remoteHost, string remoteUser, string remotePassword)
        {
            _remoteHost = remoteHost;
            _remoteUser = remoteUser;
            _remotePass = remotePassword;
        }

        /// <summary>
        /// Get a list of files and folders on the FTP server
        /// </summary>
        /// <returns></returns>
        public List<string> DirectoryListing()
        {
            return DirectoryListing(string.Empty);
        }

        public void NavigateTo(string directory)
        {
            _remoteHost += directory;
        }

        /// <summary>
        /// List files and folders in a given folder on the server
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public List<string> DirectoryListing(string folder)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + folder);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            List<string> result = new List<string>();

            while (!reader.EndOfStream)
            {
                result.Add(reader.ReadLine());
            }

            reader.Close();
            response.Close();
            return result;
        }

        /// <summary>
        /// Download a file from the FTP server to the destination
        /// </summary>
        /// <param name="filename">filename and path to the file, e.g. public_html/test.zip</param>
        /// <param name="destination">The location to save the file, e.g. c:test.zip</param>
        public void Download(string filename, string destination)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + filename);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            /*FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);*/

            using (Stream streamIn = request.GetResponse().GetResponseStream())
            using (Stream streamOut = File.Create(destination))
            {
                streamIn.CopyTo(streamOut);
            }

            /* StreamWriter writer = new StreamWriter(destination);
             writer.Write(reader.ReadToEnd());*/

            // writer.Close();
            /* reader.Close();
             response.Close();*/
        }

        public float GetFileDownloadSize(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(_remoteHost + filename);
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            float size = response.ContentLength;
            response.Close();
            return size;
        }

        public byte[] DownloadFileBytesInArray(string filename)
        {
            WebClient client = new WebClient();
            string url = _remoteHost + filename;
            client.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            byte[] contents = client.DownloadData(url);
            return contents;
        }

        public Image DownloadPngAsImage(string filename, Size size)
        {
            byte[] imagen = DownloadFileBytesInArray("image.png");
            Image image;
            using (var ms = new MemoryStream(imagen))
            {
                image = Image.FromStream(ms);
            }
            return (Image)(new Bitmap(image, size));
        }

        /// <summary>
        /// Remove a file from the server.
        /// </summary>
        /// <param name="filename">filename and path to the file, e.g. public_html/test.zip</param>
        public void DeleteFileFromServer(string filename)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + filename);
            request.Method = WebRequestMethods.Ftp.DeleteFile;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            response.Close();
        }

        /// <summary>
        /// Upload a file to the server
        /// </summary>
        /// <param name="source">Full path to the source file e.g. c:test.zip</param>
        /// <param name="destination">destination folder and filename e.g. public_html/test.zip</param>
        public void UploadFile(string source, string destination)
        {
            string filename = Path.GetFileName(source);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + destination);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);

            StreamReader sourceStream = new StreamReader(source);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            request.ContentLength = fileContents.Length;

            /*Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();*/

            using (Stream fileStream = File.OpenRead(@source))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }


            /**response.Close();
            requestStream.Close();*/
            sourceStream.Close();
        }


        public void MakeFtpDirectory(string directory)
        {

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + directory);
            request.Credentials = new NetworkCredential("Prueba", "");
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            using (var resp = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine(resp.StatusCode);
            }



            /*FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(_remoteHost + directory);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;
            request.Credentials = new NetworkCredential(_remoteUser, _remotePass);*/
        }

        public void DeleteFTPFile(string destination)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + destination);
            request.Credentials = new System.Net.NetworkCredential(_remoteUser, _remotePass);
            request.Method = WebRequestMethods.Ftp.DeleteFile;

            string result = string.Empty;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            long size = response.ContentLength;
            Stream datastream = response.GetResponseStream();
            StreamReader sr = new StreamReader(datastream);
            result = sr.ReadToEnd();
            sr.Close();
            datastream.Close();
            response.Close();
        }

        public void DeleteFTPDirectory(string directory)
        {
            FtpWebRequest clsRequest = (System.Net.FtpWebRequest)WebRequest.Create(_remoteHost + directory);
            clsRequest.Credentials = new System.Net.NetworkCredential(_remoteUser, _remotePass);

            List<string> filesList = DirectoryListing(directory);

            foreach(string subdirectory in FTPSubdirectories(directory)){
                DeleteFTPDirectory(directory + "/" + subdirectory + "/" );
                filesList.Remove(subdirectory);
            }

            char[] delimitadores = { '/' };
            foreach (string file in filesList)
            {
                DeleteFTPFile(directory + "/" + file.Split(delimitadores)[file.Split(delimitadores).Length-1]);
            }

            clsRequest.Method = WebRequestMethods.Ftp.RemoveDirectory;

            string result = string.Empty;
            FtpWebResponse response = (FtpWebResponse)clsRequest.GetResponse();
            long size = response.ContentLength;
            Stream datastream = response.GetResponseStream();
            StreamReader sr = new StreamReader(datastream);
            result = sr.ReadToEnd();
            sr.Close();
            datastream.Close();
            response.Close();
        }

        public List<string> FTPSubdirectories(string path)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remoteHost + path);
            request.Credentials = new System.Net.NetworkCredential(_remoteUser, _remotePass);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string directoryRaw = null;
            List<string> directorios = new List<string>();
            char[] split = {' '};
            try { while (reader.Peek() != -1) {
                directoryRaw = reader.ReadLine();
                if (directoryRaw[0] == 'd')
                {
                    directorios.Add(directoryRaw.Split(split)[directoryRaw.Split(split).Length-1]/*.Replace("_", " ")*/);
                }
            } }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return directorios;
        }
    }
}
