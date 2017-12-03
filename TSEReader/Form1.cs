using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace TSEReader
{
    public partial class MainForm : Form
    {
        private string addr = "https://api.tse.hn/prod/ApiActa/Consultar/1/";
        private List<MerResult> results = new List<MerResult>();
        public MainForm()
        {
            InitializeComponent();
            ImagesDownload.SelectedIndex = 0;
            Directory.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            results.Clear();
            WebClient request = new WebClient() { Encoding = Encoding.UTF8 };

            string result;
            int init, last;
            init = Int32.Parse(InitialNumber.Text);
            last = Int32.Parse(LastNumber.Text);
            InitTime.Text = DateTime.Now.ToString("T");
            Application.DoEvents();
            try
            {
                for (; init <= last; init++)
                {
                    // Obtenemos los datos
                    result = request.DownloadString(addr + init);

                    // Hacemos el parsing del json
                    var mer = ParseJson(result);
                    try {
                        // Ahora guardamos la imagen
                        mer.ImageAvailable = true;
                        if (ImagesDownload.SelectedIndex == 1)
                        {
                            DownloadAndSaveImage(request, mer);
                        }
                    } catch (Exception ex)
                    {
                        // Si falla dejamos ImageavAilable en false
                        mer.ImageAvailable = false;
                    }
                }
                // Actualizamos                   
                //Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al leer los datos. Asegurese " +
                   " que tiene acceso a internet antes de proceder. Si el problema persiste " +
                   " pongase en contacto con los administradores del sistema. Error: " +
                   ex.Message, "Lector TSE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CreateExcelFile(results);
            EndTime.Text = DateTime.Now.ToString("T");
        }

        private void DownloadAndSaveImage(WebClient request, MerResult mer)
        {
            string num = mer.CodMER.PadLeft(5, '0');
            request.DownloadFile(mer.Url, Directory.Text + Path.DirectorySeparatorChar + "MER" + num + ".jpg");
        }

        private MerResult ParseJson(string json)
        {
            var result = JsonConvert.DeserializeObject<MerResult>(json);
            results.Add(result);
            return result;
        }

        private void CreateExcelFile(List<MerResult> results)
        {
            var excel = new ExcelPackage();
            var hoja = excel.Workbook.Worksheets.Add("Datos");

            // Encabezado
            BuildHeader(hoja);

            int row = 2;
            foreach (var mer in results)
            {
                hoja.Cells["A" + row].Value = mer.NomDepartamento;
                hoja.Cells["B" + row].Value = mer.NomMunicipio;
                hoja.Cells["C" + row].Value = mer.NomCentroVotacion;
                hoja.Cells["D" + row].Value = mer.CodMER;
                hoja.Cells["E" + row].Value = mer.NomEstado;
                hoja.Cells["F" + row].Value = mer.ImageAvailable ? "Si" : "No";
                if (mer.Votos.Count > 0)
                {
                    hoja.Cells["G" + row].Value = mer.Votos[1].NumVotos;
                    hoja.Cells["H" + row].Value = mer.Votos[8].NumVotos;
                    hoja.Cells["I" + row].Value = mer.Votos[4].NumVotos;
                }
                row++;
            }
            hoja.Cells["A1:E"+row].AutoFitColumns();
            FileInfo excelFile = new FileInfo(Directory.Text + @"\DatosTSE.xlsx");
            excel.SaveAs(excelFile);

        }

        private void BuildHeader(ExcelWorksheet hoja)
        {
            hoja.Cells["A1"].Value = "Departamento";
            hoja.Cells["B1"].Value = "Municipio";
            hoja.Cells["C1"].Value = "Centro de Votación";
            hoja.Cells["D1"].Value = "MER";
            hoja.Cells["E1"].Value = "Estado";
            hoja.Cells["F1"].Value = "Imagen";
            hoja.Cells["G1"].Value = "Alianza";
            hoja.Cells["H1"].Value = "PN";
            hoja.Cells["I1"].Value = "PL";
            hoja.Cells["A1:I1"].Style.Font.Bold = true;
            hoja.Cells["A1:I1"].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
            hoja.Cells["A1:I1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
