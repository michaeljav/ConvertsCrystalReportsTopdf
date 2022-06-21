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
    public partial class provinciaMunicipio : Form
    {
        public provinciaMunicipio(string articulo)
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox1.Items.Add(articulo);
        }

        private void provinciaMunicipio_Load(object sender, EventArgs e)
        {

        }
    }
}
