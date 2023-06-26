using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void apretar_Click(object sender, EventArgs e)
        {
           int c = 5;
            double p = 0.5;

            p = c + p;
            lb1.Text = "el numero es: " + p;
        }
    }
}
