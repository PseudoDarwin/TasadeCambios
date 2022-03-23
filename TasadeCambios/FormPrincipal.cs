using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Logica;
namespace TasadeCambios
{
    public partial class FormPrincipal : Form
    {

        //Instancia del servicio SOAP
        ref_bcn.Tipo_Cambio_BCN bcn = new ref_bcn.Tipo_Cambio_BCN();

        //Intancia capa logica
        Logica.AgregarTasa tasa = new Logica.AgregarTasa();

        //Instancia a la aplicacion de consola
        ConsolaVerificacionMes.Program consola = new ConsolaVerificacionMes.Program();
        DataGridViewRow fila = new DataGridViewRow();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMesSiguiente.Rows.Clear();
            //Verificando criterio de busqueda
            if (cmbBusqueda.Text == "")
            {
                MessageBox.Show("Error, seleccione un criterio de busqueda");
            }
            else
            {
                //Obtenemos los valores del metodo de busqueda
                DateTime fecha = dtpBusqueda.Value;
                int dia = dtpBusqueda.Value.Day;
                int mes = dtpBusqueda.Value.Month;
                int año = dtpBusqueda.Value.Year;
                if (cmbBusqueda.Text == "Día especifico")
                {
                    //Busqueda por día especifico
                    var resultadoDia = bcn.RecuperaTC_Dia(año, mes, dia);

                    //Mostrando valores en el DataGrid
                    dgvResultados.Rows.Clear();
                    fila.CreateCells(dgvResultados);
                    fila.Cells[0].Value = fecha;
                    fila.Cells[1].Value = resultadoDia;
                    dgvResultados.Rows.Add(fila);
                }
                if (cmbBusqueda.Text == "Mes específico")
                {
                    busquedames(año, mes, dgvResultados);

                    if (consola.VerificarMes(mes+1,año) == true)
                    {
                        MessageBox.Show("Existen campos en el mes siguiente");
                        busquedames(año, mes+1, dgvMesSiguiente);
                        guardarfechas(dgvMesSiguiente);
                    }
                    else
                    {
                        MessageBox.Show("No xisten campos en el mes siguiente");
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            guardarfechas(dgvResultados);
        }
        void guardarfechas(DataGridView dataGrid)
        {
            int cantidadFechas = dataGrid.RowCount - 1;
            double valor;
            DateTime fecha;
            Boolean comprobar = true;
            for (int i = 0; i < cantidadFechas; i++)
            {
                try
                {
                    valor = Convert.ToDouble(dataGrid.Rows[i].Cells[1].Value.ToString());
                    fecha = Convert.ToDateTime(dataGrid.Rows[i].Cells[0].Value.ToString());
                    tasa.CrearTasa(valor, fecha);
                }
                catch
                {
                    comprobar = false;
                }
            }
            if (comprobar == true)
            {
                MessageBox.Show("Tasa agregada con exito");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        void busquedames(int año, int mes, DataGridView dataGrid)
        {
            //Busqueda por mes especifico
            var resultadoMes = bcn.RecuperaTC_Mes(año, mes).OuterXml;

            //OuterXml obtiene los resultados de la busqueda en formato XML guardando cada uno en una rama individual

            //Recorriendo el XML

            //xdoc crea un nuevo documento a parit de los resultados del anterior xml
            XDocument xdoc = XDocument.Parse(resultadoMes);
            dataGrid.Rows.Clear();
            fila.CreateCells(dataGrid);

            IEnumerable<XElement> data = xdoc.XPathSelectElements(".//Fecha").ToArray();
            //Recorremos los datos de fecha y valor del xml y los agregamos al Datagrid                 
            foreach (var el in data)
            {
                int rowEscribir = dataGrid.Rows.Count - 1;
                dataGrid.Rows.Add(1);
                dataGrid.Rows[rowEscribir].Cells[0].Value = el.Value;
                fila.Cells[1].Value = el.Value;
            }

            int i = 0;
            IEnumerable<XElement> dvalor = xdoc.XPathSelectElements(".//Valor").ToArray();
            foreach (var el in dvalor)
            {
                dataGrid.Rows[i].Cells[1].Value = el.Value;
                fila.Cells[1].Value = el.Value;
                i = i + 1;
               
            }
            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
        }
    }
}
