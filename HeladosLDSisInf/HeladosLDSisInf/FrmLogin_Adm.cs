using HeladosLDSisInf.Controllers;
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
            UsuarioController usuarioC = new UsuarioController();
            string cuenta=txt_Cuenta.Text;
            string password=txt_Password.Text;
            int Contador=usuarioC.Login(cuenta, password);

            if (Contador==1 || Contador==2)
            {
                Frm_Sistema Frm_Adm = new Frm_Sistema(cuenta,Contador);
                Frm_Adm.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Error! Cuenta o Pasword Incorrectos");
            }
        }
    }
}
