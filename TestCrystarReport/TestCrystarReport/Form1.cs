using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading;


namespace TestCrystarReport
{
    public partial class Form1 : Form
    {
        string reporte = "", DirectorioDestino = "";
        string procesoError;

        public Form1()
        {
            InitializeComponent();

            txtServidor.Text = @".";
          //  txtBaseDatos.Text = "dbPadron2016";
            //txtBaseDatos.Text = "PadronDiaD"; 
            txtBaseDatos.Text = "GENERADOR_PADRON";
            //txtServidor.Text = @"ADM-PC\SQLEXPRESS";
            //txtBaseDatos.Text = "dbPadron2016";
            //chbSeguridadIntegrada.Checked = true;

            txtUsuario.Text = "mjavier";
            txtClave.Text = "javier1234";
            ////reporte           
            txtDirectorioDestino.Text = @"D:\PADRON_EXTERIOR";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string PaisConError = "",ProvinciaConError = "", MunicipioConError = "", CircunscripcionConError = "",  RecintoConError = "";
            try
            {

                //SqlConnection cn = Coneccion();

               
                //Buscamos las pr0vincias con sus municipios                
                DataTable dt = Consultar(Coneccion());

                //Especifico la provincia anterior que se trabajo
                //si es diferente, creo otra carpeta.
                string PaisAnterior = "", ProvinciaAnterior = "", MunicipioAnterior = "", CircunscripcionAnterior = "";
                int secuenciaPrueba = 0;
                foreach (DataRow dr in dt.Rows)
                {


                   
                    //Estas varibles se guardaran en un archivo temporarl por si da error el programa
                    //Decir en que provincia se paro
                    PaisConError = dr["pais"].ToString();
                    ProvinciaConError = dr["Provinica"].ToString();
                    MunicipioConError = dr["municipio"].ToString();
                    CircunscripcionConError = dr["Circunscripcion"].ToString();                   
                    RecintoConError = dr["Recinto"].ToString();
                    lbpais.Text = dr["pais"].ToString();
                    lbMunicipio.Text = dr["municipio"].ToString();
                    lbProvincia.Text = dr["Provinica"].ToString();
                    lbcircunscripcion.Text = dr["Circunscripcion"].ToString();                   
                    lbRecinto.Text = dr["recinto"].ToString();
                    lbColegio.Text = dr["colegio"].ToString();

                    //Para en momento en que vaya a trabajar con la vega
                    //if (dr["provincia"].ToString() == "14-LA VEGA")
                    //{
                    //    MessageBox.Show("Esta en 14-LA VEGA");
                    //}

                    //Creo la carpeta en el directorio Destino con el nombre de la provincia     

                    DirectorioDestino = txtDirectorioDestino.Text + "\\" + "PAIS-" + dr["pais"].ToString().Trim()
                        + "\\" + "PROVINCIA-" + dr["Provinica"].ToString().Trim()                     
                        + "\\" + "MUNICIPIO-" + dr["municipio"].ToString().Trim()  
                        + "\\" + "CIRCUNSCRIPCION-" + dr["Circunscripcion"].ToString()  
                        + "\\" + "RECINTO-" + dr["Recinto"].ToString().Substring(0, 5).Trim()
                        + "\\" + "COLEGIO-" + dr["Colegio"].ToString().Trim() ;
                    CrearDirectorio(DirectorioDestino);
                   
                    //Borro la tabla donde creo los registros del municipio a trabajar
                    BorrarTablaGeneracion(Coneccion());

                
                    ////creo tabLA llamada GenerarPadron Con el colegio a crear
                    CrearTablaGenracion(Coneccion(),
                         dr["pais"].ToString().Trim(),
                        dr["Provinica"].ToString().Trim(),
                        dr["municipio"].ToString().Trim(),
                        dr["Circunscripcion"].ToString().Trim(),                        
                        dr["recinto"].ToString().Substring(0, 5).Trim(),
                        dr["colegio"].ToString().Trim());


                    //Direccion del municipio con nombre del pdf a guardar
                    //Nombre pdf provincia+Municipio+suscripcion+distritoMunicipal+recinto+colegio
                    string NombrePadronPdf = "";
                    NombrePadronPdf = dr["pais"].ToString().Trim() +
                        "-" + dr["Provinica"].ToString().Trim() +
                        "-" + dr["municipio"].ToString().Trim() +
                        "-" + dr["Circunscripcion"].ToString().Trim() +                       
                        "-" + dr["recinto"].ToString().Substring(0, 5).Trim() +
                        "-" + dr["colegio"].ToString().Trim();

                    //o//verifico que efectivamente que la ruta este
                    //CrearDirectorio(DirectorioDestino);
                    string ArchivoPdfProvincia = DirectorioDestino + @"\" + NombrePadronPdf + ".pdf";
                     //MessageBox.Show("REPORTE: " + ArchivoPdfProvincia);
                    //Busco reporte 
                    ReportDocument crDocument = new ReportDocument();
                    crDocument.Load(@"" + txtDireccionReporte.Text);
                    //verificar si no es cargado el reporte
                    //if( !crDocument.IsLoaded)
                    //{
                    //    string pp = "\n++++++++++++La redieccion del reporte no es cargada: " + txtDireccionReporte.Text;
                    //  //  MessageBox.Show(pp);
                    //    txtFiltro.Text += pp;
                    //    crDocument.Load(@"" + txtDireccionReporte.Text);

                    //}
                    // MessageBox.Show("CARGADO REPORTE " );
                    //crDocument.SetDatabaseLogon("sa", "123456");               
                    crDocument.SetDatabaseLogon(txtUsuario.Text.Trim(), txtClave.Text.Trim());
                    // MessageBox.Show("CARGADO  CREDENCIALES "+ txtUsuario.Text +" -- "+txtClave.Text);
                    
                    //  MessageBox.Show("ANTES DE EXPORTAR REPORTE ");
                    crDocument.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, ArchivoPdfProvincia);
                   // Thread.Sleep(10000);
                    // MessageBox.Show(" REPORTE EXPORTADO ");
                    crDocument.Refresh();
                    if (crDocument != null)
                    {
                        
                    crDocument.Database.Dispose();                    
                    crDocument.Close();
                    crDocument.Dispose();
                    GC.Collect();
                    //GC.WaitForPendingFinalizers();
                    //GC.Collect();
                    }
                   
                    
                    
                }



                //cn.Close();
            }
            catch (Exception ex)
            {
                string ErrorMessage = "++++++++++++++++++++++++++";
                ErrorMessage+=ex.GetBaseException().Message.ToString();                
                ErrorMessage += "++++++++++++++++++++++++++";
                ErrorMessage += ex.ToString();
                txtFiltro.Text += ErrorMessage;

                MessageBox.Show(ex.GetBaseException().Message.ToString());
                MessageBox.Show(ex.ToString());

                //Para crear log por si da error
                GuardarTempPdf(@"d:\TempPdf\TempReportesPDF.txt", ProvinciaConError, MunicipioConError, ex);

            }
            finally
            {
              GC.Collect();
               
            }

            if (procesoInterrunpido == false)
                MessageBox.Show("El proceso completado exitosamente");
        }

        private void CrearDirectorio(string DirectorioDestino)
        {
            if (!Directory.Exists(DirectorioDestino))
            {
                System.IO.Directory.CreateDirectory(DirectorioDestino);
            
                
            }
        }

        private void CrearTablaGenracion(SqlConnection cn, string pais, string Provincia, string Municipio, string circunstripcion,  string recinto, string colegio)
        {
            //listBox1.Items.Add("Conexcion antes de insertar generacion=" + cn.ConnectionString.ToString());
            //MessageBox.Show("Conexcion antes de insertar generacion=" + cn.ConnectionString.ToString());
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;

           
          //  cm.CommandText = " select   * into [dbPadron2016].[dbo].GenerarPadron " +
            cm.CommandText = " select   * into GenerarPadronExterior " +    
                  //   " from [dbPadron2016].[dbo].[Tabla_Vis_Padron_2016]  " +
                             " from [Tabla_Vis_Padron_2016_Exterior]  " +
                             " where pais = '" + pais + "'" +
                            " and Provinica = '" + Provincia + "'" +
                             " and municipio = '" + Municipio + "'" +
                             "  and  Circunscripcion='" + circunstripcion + "'" +                             
                              "  and  left(recinto,5)='" + recinto + "'" +
                              "  and  colegio='" + colegio + "'" +
                             "";
           // txtFiltro.Text = txtFiltro.Text + "-CREANDO TABLA GENERACIONPADRON--" + cm.CommandText;//PONER
            cm.CommandTimeout = 0;
            //listBox1.Items.Add("Commando= " + cm.CommandText.ToString());
            ////MessageBox.Show("Commando= " + cm.CommandText.ToString());
            cm.ExecuteNonQuery();
            //listBox1.Items.Add("Commando= " + cm.CommandText.ToString());
            //MessageBox.Show("Commando= " + cm.CommandText.ToString());

            //Probar  borrar cm
            if (cm != null)
            {

                cm.Dispose();

            }
            //Cierro Conexion y libero memoria
            if (cn != null && cn.State == ConnectionState.Open)
            {
                
                cn.Close();
                cn.Dispose();
            }
            



        }


        bool procesoInterrunpido = false;
        private void GuardarTempPdf(string fileName, string ProvinciaConError, string MunicipioConError, Exception ex)
        {
            procesoInterrunpido = true;
            //string fileName = @"C:\TempReportesPDF.txt";
            //System.IO.Directory.CreateDirectory(@"d:\TempPadronPdf");
            System.IO.Directory.CreateDirectory(@""+fileName);
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Ultima error Provincia en que se detubo el proceso:   " + ProvinciaConError + "  Municipio: " + MunicipioConError + "\n " + ex.GetBaseException().ToString());
            writer.Close();
            writer.Dispose();
            MessageBox.Show("El proceso interrrunpido  " + ex.GetBaseException().ToString());

        }

        private void BorrarTablaGeneracion(SqlConnection cn)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "if exists (select * from sys.objects where name = 'GenerarPadronExterior' and type = 'u')    drop table GenerarPadronExterior ";

            //drop table generacion";
            int result = cm.ExecuteNonQuery();
            //Probar  borrar cm
            if (cm != null)
            {

                cm.Dispose();

            }
            //Cierro Conexion y libero memoria
            if (cn != null && cn.State == ConnectionState.Open)
            {

                cn.Close();
                cn.Dispose();
            }


        }

        private DataTable ConsultarProvinciamunicipio(SqlConnection cn, String Provincia, String Municipio)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            //if not exists (select * from sys.objects where name = 'generacion' and type = 'u')
            cm.CommandText = " select  *  " +
                             " from [Vista_M_Padron_General] where provincia = '" + Provincia + "' and municipio = '" + Municipio + "'" +
                             " order by coordinador ";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;

        }
        private DataTable ConsultarVistaParaReporte(SqlConnection cn)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "  select * from vista_M_padron_General  ";
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        private DataTable Consultar(SqlConnection cn)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            //lo deje de usar esta por que  cree una tabla con todos los registros ordenados
            // por cantidad de registros por provincia y municipio de manera ascendente en 
            //la base de datos sigel en el servidor
            //cm.CommandText = "  select provincia,municipio from [Lap_CBA_19_01_2016]  " +
            //                 " group by provincia,municipio " +
            //                 " having  left(provincia,3) = 007 and  left(municipio,3) = 063  " +
            //                 " order by provincia desc ,municipio  desc";
            cm.CommandText = " SELECT  " +
                             "pais, [Provinica] " +
                              " ,[Municipio] " +
                              " ,[Circunscripcion] " +                            
                              " ,[Recinto] " +
                              " ,[Colegio] " +
                             //   " FROM [dbPadron2016].[dbo].[Tabla_Vis_Padron_2016] " +
                                " FROM [Tabla_Vis_Padron_2016_Exterior] " +
                          " group by  pais, [Provinica] " +
                              " ,[Municipio] " +
                             " ,Circunscripcion " +                             
                             " ,[Recinto] " +
                             " ,[Colegio]       " +txtFiltro.Text+
                              "   order by  pais, [Provinica]  " +
                              " ,[Municipio] " +
                              " ,Circunscripcion " +                             
                              " ,[Recinto] " +
                              " ,[Colegio] ";

         //   txtFiltro.Text = txtFiltro.Text+"-"+cm.CommandText;
            cm.CommandTimeout = 0;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            //Cierro Conexion y libero memoria
            //Probar  borrar cm
            if (cm != null)
            {

                cm.Dispose();

            }
            //Cierro Conexion y libero memoria
            if (cn != null && cn.State == ConnectionState.Open)
            {

                cn.Close();
                cn.Dispose();
            }

            return dt;
        }

        private SqlConnection Coneccion()
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
            cb.DataSource = txtServidor.Text;
            cb.InitialCatalog = txtBaseDatos.Text;

            if (chbSeguridadIntegrada.Checked)
            {
                cb.IntegratedSecurity = true;
            }
            else
            {
                cb.UserID = txtUsuario.Text;
                cb.Password = txtClave.Text;
            }

            SqlConnection cn = new SqlConnection(cb.ConnectionString);
            
            cn.Open();
            return cn;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {


            if (DialogResult.OK == OFDReporte.ShowDialog())
            {
                //Asignar direccion del archvio en txt
                txtDireccionReporte.Text = OFDReporte.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbdDirectorioDestino.ShowDialog())
            {
                //Asignar direccion del archvio en txt
                txtDirectorioDestino.Text = fbdDirectorioDestino.SelectedPath;

            }
        }

        private void txtDirectorioDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(new Random().Next().ToString());
            listBox1.Items.Clear();
            string ProvinciaAnterior = "";
            ////voy a cargar el tree view
            //SqlConnection cn = Coneccion();
            ////Buscamos las pr0vincias con sus municipios                
            //DataTable dt = Consultar(cn);
            ////Identifico la provincia
            //int ProvinciaNumero = -1;
            ////cargar provincias al treeview
            //foreach (DataRow dr in dt.Rows)
            //{
            //    //////       TreeNode NextChildNode2 = new TreeNode();
            //    //////NextChildNode2.Text = "Next Child 2";
            //    //////NextChildNode2.ForeColor = Color.Black;
            //    //////NextChildNode2.BackColor = Color.White;
            //    //////NextChildNode2.ImageIndex = 1;
            //    //////NextChildNode2.SelectedImageIndex = 1;

            //    if (string.IsNullOrEmpty(dr["provincia"].ToString()) || string.IsNullOrEmpty(dr["municipio"].ToString())) { continue; }

            //    //si la provincia anterior es diferente de la actual
            //    //entonces creo otro carpeta de provincia para entrar 
            //    //los nuevos municipios que corresponden a esa proviencia
            //    if (ProvinciaAnterior != dr["provincia"].ToString())
            //    {

            //        ProvinciaAnterior = dr["provincia"].ToString();
            //        ProvinciaNumero++;
            //        tvProvinciasYmunicipios.Nodes.Add(dr["provincia"].ToString());
            //    }

            //    tvProvinciasYmunicipios.Nodes[ProvinciaNumero].Nodes.Add(dr["municipio"].ToString());




            //}

            //cn.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void chbSeguridadIntegrada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tvProvinciasYmunicipios_AfterCheck(object sender, TreeViewEventArgs e)
        {
            e.Node.PrevNode.Checked = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
