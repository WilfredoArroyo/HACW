using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeladosLDSisInf
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_Siguiente.Visible = true;
            PBox_Img2.Visible = true;
            Lb_IngNom.Visible = true;
            txt_Nom.Visible = true;
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            Btn_Siguiente.Visible = false;
            PBox_Img2.Visible = false;
            Lb_IngNom.Visible = false;
            txt_Nom.Visible = false;  
        }
        private void txt_Nom_TextChanged_1(object sender, EventArgs e)
        {
            txt_Nom.Select(txt_Nom.Text.Length, 0);
            txt_Nom.ScrollToCaret();
        }

        private void Lb_IngNom_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            string txt_NOmbre = txt_Nom.Text;
            if (txt_NOmbre == "12345678")
            {
                FrmLogin_Adm Login = new FrmLogin_Adm();
                Login.Show();
                this.Hide();
            }
            else if (txt_NOmbre == "")
            {
                MessageBox.Show("Digite un Nombre :)");
            }
            else
            {
                txt_NOmbre = txt_Nom.Text;
                Frm_Productos pro = new Frm_Productos(txt_NOmbre);
                pro.Show();
                this.Hide();
            }
        }

        private void Frm_Inicio_OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Color borderColor = Color.White;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }
    }
}
