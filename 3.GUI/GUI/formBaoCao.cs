using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace QLTV
{
    public partial class formBaoCao : Form
    {
        public formBaoCao()
        {
            InitializeComponent();
            dgvBaoCao.AutoGenerateColumns = false;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            exportPDF();
        }
        public void exportPDF()
        {

            if (dgvBaoCao.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {

                    if (!ErrorMessage)
                    {
                        try
                        {

                            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, true);
                            PdfPTable pTable = new PdfPTable(dgvBaoCao.Columns.Count);
                            pTable.DefaultCell.Padding = 5;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //Create our usable font
                            var font = new iTextSharp.text.Font(baseFont, 14);

                            foreach (DataGridViewColumn column in dgvBaoCao.Columns)
                            {
                                PdfPCell Cell = new PdfPCell(new Phrase(column.HeaderText));
                                pTable.AddCell(Cell);
                            }
                            foreach (DataGridViewRow row in dgvBaoCao.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pTable.AddCell(new Phrase(cell.Value.ToString(), font));
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {

                                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Tạo file PDF thành công");

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show("Lỗi tạo file" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy bảng dữ liệu");

            }
        }
    }
}
