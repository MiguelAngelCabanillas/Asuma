using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using System.IO;
using MySqlConnector;

namespace Asuma
{
    public partial class PruebaWord : Form
    {
        public PruebaWord()
        {
            InitializeComponent();
        }

        private void bDocumento_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string documentPath = pathBueno + "documents\\" + "certificado.docx";

            object oMissing = System.Reflection.Missing.Value;
            Word.Application ap = new Word.Application();
            object marcadorNombreUsuario = "nombreUsuario";
            object marcadorNombreCurso = "nombreCurso";
            Word.Document document = ap.Documents.Open(documentPath);

            //INTRODUZCO EL NOMBRE DE USUARIO
            Word.Range nombreUsuario = document.Bookmarks.get_Item(ref marcadorNombreUsuario).Range;
            nombreUsuario.Text = "Miguel Ángel Cabanillas Silva";
            //INTRODUZCO EL NOMBRE DEL CURSO
            Word.Range nombreCurso  = document.Bookmarks.get_Item(ref marcadorNombreCurso).Range;
            nombreCurso.Text = "RECREO";
            object rango1 = nombreUsuario;
            object rango2 = nombreCurso;
            document.Bookmarks.Add("nombreUsuario", ref rango1);
            document.Bookmarks.Add("nombreCurso", ref rango2);
            object outputFileName = document.FullName.Replace(".docx", ".pdf");
            object fileFormat = Word.WdSaveFormat.wdFormatPDF;
            document.SaveAs2(ref outputFileName,
            ref fileFormat, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing,
            ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            
            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            ((_Document)document).Close(ref saveChanges, ref oMissing, ref oMissing);
            document = null;
            ((_Application)ap).Quit(ref oMissing, ref oMissing, ref oMissing);
            ap = null;
            

            Email email = new Email();
            Event evento = new Event(62);
            User usuario = new User("franB");
            email.sendEmailCertificate("miguelangelcabanillassilva1@gmail.com", new Event(62), usuario);

           // ap.Visible = true;
        }
    }
}
