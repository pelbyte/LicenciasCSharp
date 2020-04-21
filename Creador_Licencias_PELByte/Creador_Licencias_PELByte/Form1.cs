using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Management;

namespace Creador_Licencias_PELByte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string SerialLicencia;
        private Conexion.AES aes = new Conexion.AES();

        private void btnCrearLicencia_Click(object sender, EventArgs e)
        {
            //txtSerialpc.Text = Conexion.Encriptar_en_Texto.Desencriptar(txtSerialpc.Text);

            if (txtRuta.Text != "")
            {
                string miCarpeta = "Licencias_" + txtSoftware.Text;

                SerialLicencia = "|" + txtSerialpc.Text + "|" + txtFechaCaducidad.Text + "|" + "PENDIENTE" + "|" + txtSoftware.Text + "|";
                CrearXML();
                SavetoXML(aes.Encrypt(SerialLicencia, Conexion.Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Licencia Creada y guardada en: " + txtRuta.Text + miCarpeta, "Creando Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un Disco", "Ruta Invalida | PELByte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SavetoXML(object dbcnString)
        {
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day;
            int mes = fechaSistema.Month;
            int año = fechaSistema.Year;

            int hora = fechaSistema.Hour;
            int minuto = fechaSistema.Minute;
            string miCarpeta = "Licencias_" + txtSoftware.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load(txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter(txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        private void CrearXML()
        {
            string miCarpeta = "Licencias_" + txtSoftware.Text;
            if (System.IO.Directory.Exists(txtRuta.Text + miCarpeta))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day;
            int mes = fechaSistema.Month;
            int año = fechaSistema.Year;

            int hora = fechaSistema.Hour;
            int minuto = fechaSistema.Minute;

            string ruta = txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml";
            FileInfo fi = new FileInfo(ruta);
            StreamWriter sw;
            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(XMLparte1.Text + "pelr" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(XMLparte1.Text + "pelr" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
                /*string ruta = txtRuta.Text;
                if ((ruta.Contains(@"C:\")))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;

                }*/
            }
        }

        internal void Periodos()
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime fechaFinal;
                int numero_periodo = Convert.ToInt32(txtNumero.Value);

                if (txtPeriodo.Text == "mes(es)")
                {
                    fechaFinal = today.AddMonths(numero_periodo);
                    txtFechaCaducidad.Value = fechaFinal;
                }

                if (txtPeriodo.Text == "año(s)")
                {
                    fechaFinal = today.AddYears(numero_periodo);
                    txtFechaCaducidad.Value = fechaFinal;
                }

                if (txtPeriodo.Text == "perpetua")
                {
                    fechaFinal = today.AddYears(100);
                    txtFechaCaducidad.Value = fechaFinal;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtNumero_ValueChanged(object sender, EventArgs e)
        {
            Periodos();
        }

        private void txtPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Periodos();
        }

        public string SerialPcD;

        private void btnDescencriptar_Click(object sender, EventArgs e)
        {
            txtSerialpc.Text = Conexion.Encriptar_en_Texto.Desencriptar(txtSerialpcCopiada.Text);
        }
    }
}
