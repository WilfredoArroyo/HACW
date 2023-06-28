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
    public partial class Frm_Productos : Form
    {
        public string NombreF { get; set; }
        public Frm_Productos(string nom)
        {
            InitializeComponent();
            NombreF = nom;
            TimerProducto.Interval = 120000;
            TimerProducto.Tick += TimerProducto_Tick;
            TimerProducto.Start();

            this.KeyPress += Frm_Productos_KeyPress;
            this.MouseMove += Frm_Productos_MouseMove;
            this.KeyDown += Frm_Productos_KeyDown;
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            TimerProducto.Stop();
            Frm_Inicio Ins =new Frm_Inicio();   
            Ins.Show(); 
            this.Hide();
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            lbl_Nombre.Text ="Hola Bienvenido "+NombreF;
            Panel_AceptarT.Visible = false;
            panel_Extras.Visible = false;
            Panel_Helados.Visible = false;
            Panel_Sabores.Visible = false;
        }

        private void Frm_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Helados_Click(object sender, EventArgs e)
        {
            Panel_Helados.Visible = true;
            Panel_Sabores.Visible = false;
            panel_Extras.Visible = false;
            
        }

        private void Btn_Helados_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Helados.BackColor = Color.Crimson;
            Btn_Extras.BackColor = Color.Maroon;
            Btn_Recipiente.BackColor = Color.Maroon;
            Btn_sabor.BackColor = Color.Maroon;
        }

        private void Btn_sabor_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Helados.BackColor = Color.Maroon;
            Btn_Extras.BackColor = Color.Maroon;
            Btn_Recipiente.BackColor = Color.Maroon;
            Btn_sabor.BackColor = Color.Crimson;
        }

        private void Btn_Recipiente_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Helados.BackColor = Color.Maroon;
            Btn_Extras.BackColor = Color.Maroon;
            Btn_Recipiente.BackColor = Color.Crimson;
            Btn_sabor.BackColor = Color.Maroon;
        }

        private void Btn_Extras_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Helados.BackColor = Color.Maroon;
            Btn_Extras.BackColor = Color.Crimson;
            Btn_Recipiente.BackColor = Color.Maroon;
            Btn_sabor.BackColor = Color.Maroon;
        }

        private void Btn_sabor_Click(object sender, EventArgs e)
        {
            Panel_Helados.Visible = false;
            Panel_Sabores.Visible = true;
            panel_Extras.Visible = false;
        }

        private void Btn_Recipiente_Click(object sender, EventArgs e)
        {
            Panel_Helados.Visible = false;
            Panel_Sabores.Visible = false;
            panel_Extras.Visible = false;
        }

        private void Btn_Extras_Click(object sender, EventArgs e)
        {
            Panel_Helados.Visible = false;
            Panel_Sabores.Visible = false;
            panel_Extras.Visible = true;
        }

        private void Btn_Helado1P_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (s == 0)
            { Btn_Helado1P.Enabled = false;
            Btn_Helado1P.Text = "X";
                Btn_Helado1P.ForeColor = Color.Red;   
            }
        }

        private void Frm_Productos_MouseMove(object sender, MouseEventArgs e)
        {
            TimerProducto.Stop();
            TimerProducto.Start();
        }
        private void TimerProducto_Tick(object sender, EventArgs e)
        {
            TimerProducto.Stop();
            Frm_Inicio form =Frm_Inicio.GetInstance();
            form.Show();
            this.Hide();
        }
        
        private void Frm_Productos_KeyDown(object sender, KeyEventArgs e)
        {
            TimerProducto.Stop();
            TimerProducto.Start();
        }

        private void Frm_Productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerProducto.Stop();
            TimerProducto.Start();
        }
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            // Aquí puedes detener la ejecución de eventos o funciones mientras el formulario está oculto
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            // Aquí puedes reactivar los eventos o funciones cuando vuelvas al formulario
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            panel_Extras.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel_Extras.Visible = false;
            Panel_AceptarT.Visible = true;
            List<Pedido> pedido = new List<Pedido>
            {
                new Pedido { Descripcion = "Helado de fresa,Coco en Cono", Precio = 4 },
                new Pedido { Descripcion = "Helado de Oreo,Banana en varquillo", Precio = 5 },
                new Pedido { Descripcion = "Helado de chocolate,Frutilla en Cono", Precio = 4 }
            };
            foreach (Pedido persona in pedido)
            {
                TablaPedido.Rows.Add(persona.Descripcion, persona.Precio);
            }
        }
        public class Pedido
        {
            public string Descripcion { get; set; }
            public Decimal Precio { get; set; }
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            Frm_Cobro cobro = new Frm_Cobro();
            cobro.Show();
            this.Hide();
        }

        private void Btn_CancelarPedido_Click(object sender, EventArgs e)
        {
            Frm_Inicio frm_Inicio = new Frm_Inicio();
            frm_Inicio.Show();
            this.Hide();
        }
    }
}
