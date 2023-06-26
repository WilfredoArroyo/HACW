using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeladosLDSisInf
{
    public partial class FrmLogin_Adm : Form
    {
        public FrmLogin_Adm()
        {
            InitializeComponent();
        }
        private void FrmLogin_Adm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
