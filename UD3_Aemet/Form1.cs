using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UD3_Aemet
{
    public partial class Form1 : Form
    {
        BindingList<ValoresDiarios> binding = new BindingList<ValoresDiarios>();
        Dictionary<string, string> codCCAA = new Dictionary<string, string>();
        Dictionary<string, string> codProv = new Dictionary<string, string>();
        Dictionary<string, string> codMon = new Dictionary<string, string>();
        Dictionary<string, string> codAlcance = new Dictionary<string, string>();
        Dictionary<string, string> codPlaya = new Dictionary<string, string>();

        static CultureInfo ci = new CultureInfo("es-ES");
        TextInfo ti = ci.TextInfo;

        public Form1()
        {
            InitializeComponent();
        }

        #region LLenar los ComboBox

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

            codProv = ClienteAemet.GenerateCODProvincia();
            cboProvincias.DataSource = codProv.Keys.ToArray();

            codMon = ClienteAemet.GenerateCODMontana();
            cboMacizo.DataSource = codMon.Keys.ToArray();

            codAlcance = ClienteAemet.GenerateCODAlcance();
            cboAlcance.DataSource = codAlcance.Keys.ToArray();

            codPlaya = ClienteAemet.GenerateCODPlaya();
            cboPlaya.DataSource = codPlaya.Values.ToArray();
        }

        public List<KeyValuePair<string, string>> leerLocalidades()
        {
            var list = new List<KeyValuePair<string, string>>();
            string workingDirectory = Environment.CurrentDirectory;
            FileInfo existingFile = new FileInfo(Directory.GetParent(workingDirectory).Parent.FullName + ".\\Codigos\\20codmun.xlsx");
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
        #endregion


        #region Realizar Request y mostrar los datos
        //ESTACIONES METEREOLÓGICAS
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

        //COMUNIDADES AUTÓNOMAS
        private void btnAutonomas_Click(object sender, EventArgs e)
        {
            string select = (string)cboComunidades.SelectedItem;

            string cod = codCCAA[select];

            string ccaa_hoy = ClienteAemet.ValoresPrediccionComunidad(cod);

            txtComunidades.Text = ccaa_hoy;
        }


        //LOCALIDADES
        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            PrediccionLocalidad[] prediccion = ClienteAemet.ValoresClimaLocalidad(cboLocalidades.SelectedValue.ToString());

            var dia = cboDiasLocalidad.SelectedIndex;

            if (dia < 0)
            {
                dia = 1;
                cboDiasLocalidad.SelectedIndex = 1;
            }

            renderLocalidadData(prediccion, dia);
        }

        private void renderLocalidadData(PrediccionLocalidad[] prediccion, int dia)
        {
            txtFecha.Text = DateTime.ParseExact(prediccion[0].Prediccion.Dia[dia].Fecha.DateTime.ToString(), "dd/MM/yyyy h:mm:ss",
                            ci.DateTimeFormat).ToString("D");
            txtProvincia.Text = prediccion[0].Provincia;
            txtLocalidad.Text = prediccion[0].Nombre;

            txtTmax.Text = prediccion[0].Prediccion.Dia[dia].Temperatura.Maxima.ToString() + "°C";
            txtTmin.Text = prediccion[0].Prediccion.Dia[dia].Temperatura.Minima.ToString() + "°C";

            txtSensacionMax.Text = prediccion[0].Prediccion.Dia[dia].SensTermica.Maxima.ToString() + "°C";
            txtSensacionMin.Text = prediccion[0].Prediccion.Dia[dia].SensTermica.Minima.ToString() + "°C";

            txtHumedadMax.Text = prediccion[0].Prediccion.Dia[dia].HumedadRelativa.Maxima.ToString() + "%";
            txtHumedadMin.Text = prediccion[0].Prediccion.Dia[dia].HumedadRelativa.Minima.ToString() + "%";
        }

        //PROVINCIAS
        private void btnProvincias_Click(object sender, EventArgs e)
        {
            string select = (string)cboProvincias.SelectedItem;

            string cod = codProv[select];

            string prv_hoy = ClienteAemet.ValoresClimaProvincia(cod);

            txtProvincias.Text = prv_hoy;
        }

        //MONTAÑA
        private void btnMontañosos_Click(object sender, EventArgs e)
        {
            string select = (string)cboMacizo.SelectedItem;
            string codMontana = codMon[select];

            select = (string)cboAlcance.SelectedItem;
            string codAlc = codAlcance[select];

            PrediccionMontana[] prediccion = ClienteAemet.ValoresClimaMontana(codMontana, codAlc);


            //TODO Ir accediento a cada elemento que queramos mostrar y ponerlo en la vista

        }


        //PLAYAS
        private void btnPlayas_Click(object sender, EventArgs e)
        {
            DiaPlaya data = getPlayaData();

            renderPlayaData(ci, ti, data);
        }

        private void cboDiaPlaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiaPlaya data = getPlayaData();
            renderPlayaData(ci, ti, data);
        }

        private DiaPlaya getPlayaData()
        {
            var cod_playa = codPlaya.FirstOrDefault(x => x.Value == (string)cboPlaya.SelectedItem).Key;
            var dia = cboDiaPlaya.SelectedIndex;

            PrediccionPlaya[] prediccion = ClienteAemet.ValoresClimaPlaya(cod_playa);

            if (dia < 0)
            {
                dia = 1;
                cboDiaPlaya.SelectedIndex = 1;
            }

            var data = prediccion[0].Prediccion.DiaPlaya[dia];
            return data;
        }

        private void renderPlayaData(CultureInfo ci, TextInfo ti, DiaPlaya data)
        {
            lblPlayaFecha.Text = DateTime.ParseExact(data.Fecha.ToString(), "yyyyMMdd", ci.DateTimeFormat).ToString("D");
            lblPlayaCielo.Text = ti.ToTitleCase(data.EstadoCieloPlaya.Descripcion1);
            lblPlayaOleaje.Text = ti.ToTitleCase(data.Oleaje.Descripcion1);
            lblPlayaSensTer.Text = ti.ToTitleCase(data.STermica.Descripcion1);
            lblPlayaTemAgua.Text = data.TAgua.Valor1.ToString() + "°C";
            lblPlayaViento.Text = ti.ToTitleCase(data.Viento.Descripcion1);
            lblPlayaTempMax.Text = data.TMaxima.Valor1.ToString() + "°C";
        }
    } 
    #endregion
}




