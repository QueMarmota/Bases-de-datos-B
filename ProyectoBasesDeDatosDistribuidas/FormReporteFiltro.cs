using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoBasesDeDatosDistribuidas
{
    public partial class FormReporteFiltro : Form
    {
        public FormReporteFiltro()
        {
            InitializeComponent();
        }

        private void FormReporteFiltro_Load(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Reporte.pdf", FileMode.Create));
            doc.Open();
            //write some content
            Paragraph paragraph = new Paragraph("Este es un parrafo");
            doc.Add(paragraph);
            doc.Close();
        }
    }
}
