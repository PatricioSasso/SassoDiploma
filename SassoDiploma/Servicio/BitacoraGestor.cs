using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace Service
{
    public class BitacoraGestor
    {
        DALBitacora dalBitacora;

        public BitacoraGestor()
        {
            dalBitacora = new DALBitacora();
        }

        public void Registrar(string descripcion, TipoMensaje tipoBitacora, Usuario usuario)
        {
            dalBitacora.Registrar(new Bitacora(DateTime.Now, descripcion, tipoBitacora, usuario));
        }

        public List<string> GetAll()
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.GetAll())
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }

        public List<string> BuscarNombreUsuario(string filtro)
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.BuscarNombreUsuario(filtro))
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }

        public List<string> BuscarFecha(string filtro)
        {
            List<string> datos = new List<string>();
            foreach (var d in dalBitacora.BuscarFecha(filtro))
            {
                datos.Add(d.Fecha + " , " + d.TipoMensaje.ToString() + " : " + d.Descripcion);
            }
            return datos;
        }

        public void GenerarPdf(string ruta)
        {
            StringBuilder sbMensaje = new StringBuilder();
            foreach (var b in GetAll())
            {
                sbMensaje.AppendLine(b);
            }
            Document pdf = new Document(PageSize.A4);
            using (PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(ruta, FileMode.Create))) //+ "\\" + DateTime.Now.ToShortDateString() + "_Bitacora.pdf", FileMode.Create)))
            {
                pdf.Open();
                Paragraph p = new Paragraph("Informe de datos de la bitácora hasta la fecha " + DateTime.Now.ToShortDateString() + ".");
                p.Alignment = Element.ALIGN_CENTER;
                p.Font.Size = 35;
                pdf.Add(p);
                pdf.Add(new Paragraph(" "));
                LineSeparator lineSeparator = new LineSeparator();
                pdf.Add(lineSeparator);
                pdf.Add(new Paragraph(sbMensaje.ToString()));
                pdf.Close();
            }

        }
    }
}
