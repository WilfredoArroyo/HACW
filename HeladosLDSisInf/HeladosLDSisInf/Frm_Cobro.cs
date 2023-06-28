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
    public partial class Frm_Cobro : Form
    {
        public Frm_Cobro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra");
            Frm_Inicio frm_Inicio = new Frm_Inicio();
            frm_Inicio.Show();
            this.Hide();
        }

        private void Btn_Qr_Click(object sender, EventArgs e)
        {
            pictureBox_Qr.Visible = true;
            lbl_Pago.Visible = false;
        }

        private void Frm_Cobro_Load(object sender, EventArgs e)
        {
            pictureBox_Qr.Visible = false;
            lbl_Pago.Visible = true;
        }
    }
}
