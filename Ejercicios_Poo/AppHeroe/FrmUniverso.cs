using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AppHeroe
{
    public partial class FrmUniverso : Form
    {
        Universo universo;
        public FrmUniverso()
        {
            InitializeComponent();
            universo = (Universo)8;
        }

        private void btnNuevoHeroe_Click(object sender, EventArgs e)
        {
            FrmHeroe1 frmHeroe = new FrmHeroe1();
            frmHeroe.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
