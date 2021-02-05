using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_Aemet
{
    public partial class Form1 : Form
    {
        BindingList<ValoresDiarios> binding = new BindingList<ValoresDiarios>();
        Dictionary<string, string> codCCAA = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLocalidades.DataSource = leerLocalidades();
            cboLocalidades.DisplayMember = "Value";
            cboLocalidades.ValueMember = "Key";

            var lst = ClienteAemet.InventarioTodasEstaciones();
            cboEstaciones.DataSource = lst;
            cboEstaciones.DisplayMember = "nombre";
            dgvEstacion.DataSource = binding;

            string esp_hoy = ClienteAemet.ValoresPrediccionEspana();
            txtEspaña.Text = esp_hoy;

            codCCAA = ClienteAemet.GenerateCODCcaa();
            cboComunidades.DataSource = codCCAA.Keys.ToArray();
        }

        private void btnEstación_Click(object sender, EventArgs e)
        {
            string fechaIni = dtInicio.Value.ToString("yyyy-MM-ddThh:00:0" + "0UTC");
            string fechaFin = dtFin.Value.ToString("yyyy-MM-ddThh:00:00UTC");
            string idema = ((Estacion)cboEstaciones.SelectedItem).indicativo;
            var diarios = ClienteAemet.ValoresClimaDiario(fechaIni, fechaFin, idema);
            binding.Clear();
            Array.ForEach(diarios, d => binding.Add(d));
            binding.ResetBindings();
        }

        private void btnAutonomas_Click(object sender, EventArgs e)
        {
            string select = (string) cboComunidades.SelectedItem;

            string cod = codCCAA[select];

            string ccaa_hoy = ClienteAemet.ValoresPrediccionComunidad(cod);

            txtComunidades.Text = ccaa_hoy;
        }


        public List<KeyValuePair<string, string>> leerLocalidades()
        {
            var list = new List<KeyValuePair<string, string>>();
            string workingDirectory = Environment.CurrentDirectory;
            FileInfo existingFile = new FileInfo(Directory.GetParent(workingDirectory).Parent.FullName + "\\bin\\20codmun.xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                for (int row = 3; row <= rowCount; row++)
                {
                    list.Add(new KeyValuePair<string, string>(worksheet.Cells[row, 2].Value.ToString() + worksheet.Cells[row, 3].Value.ToString(), worksheet.Cells[row, 5].Value.ToString().Trim()));
                    Console.WriteLine(" Row:" + row + " Value:" + worksheet.Cells[row, 2].Value + worksheet.Cells[row, 3].Value + " -> " + worksheet.Cells[row, 5].Value.ToString().Trim());

                }
            }
            return list;
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            PrediccionLocalidad[] prediccion = ClienteAemet.ValoresClimaLocalidad(cboLocalidades.SelectedValue.ToString());
            txtFecha.Text = prediccion[0].Elaborado.ToString();
            txtProvincia.Text = prediccion[0].Provincia;
            txtLocalidad.Text = prediccion[0].Nombre;

            txtTmax.Text = prediccion[0].Prediccion.Dia[0].Temperatura.Maxima.ToString() + "°C";
            txtTmin.Text = prediccion[0].Prediccion.Dia[0].Temperatura.Minima.ToString() + "°C";

            txtSensacionMax.Text = prediccion[0].Prediccion.Dia[0].SensTermica.Maxima.ToString() + "°C";
            txtSensacionMin.Text = prediccion[0].Prediccion.Dia[0].SensTermica.Minima.ToString() + "°C";

            txtHumedadMax.Text = prediccion[0].Prediccion.Dia[0].HumedadRelativa.Maxima.ToString() + "%";
            txtHumedadMin.Text = prediccion[0].Prediccion.Dia[0].HumedadRelativa.Minima.ToString() + "%";
        }


    }
}




