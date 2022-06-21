using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCrystarReport
{
    public partial class frmReporte : Form
    {
        DataTable dt;
        string report;
        public frmReporte( DataTable dt,string report)
        {
            InitializeComponent();
            this.dt = dt;
            this.report = report;
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            //ReportDocument rd = new ReportDocument();
            //DataSet ds = new DataSet();
            
            //ds.Tables[0].Merge(dt);
            ////crTest t = new crTest();
            ////t.SetDataSource(dt);
            ////rd.SetDataSource(dt);
            //crTest1.SetDataSource(ds);
            ////crTest1.Load(report);

            // //rd.Load(report);
            ////crTest1.SetDataSource(dt);
            
           
            //crystalReportViewer1.ReportSource = crTest1;

            //crTest c = new crTest();
            //c.SetDataSource(dt);

            //crystalReportViewer1.ReportSource = c;
            //c.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"D:\ASD.pdf");

          

        }

        private void crTest1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
