using HeladosLDSisInf.Controllers;
using HeladosLDSisInf.Models;
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
    public partial class Frm_Sistema : Form
    {
        ClienteController _clienteController = new ClienteController();
        PedidoController _pedidoController= new PedidoController();
        HeladoController _heladoController= new HeladoController();
        UsuarioController _usuarioController= new UsuarioController();
        HIstorialVentasController _historialVController = new HIstorialVentasController();
        ProductoController _productoController = new ProductoController();
        
        //si un usuario es nuevo
        bool _isNew = true;
        public string nombreCuenta { get; set; }
        public int Contador { get; set; }
        public Frm_Sistema(string Ncuenta,int Cont)
        {
            InitializeComponent();
            nombreCuenta = Ncuenta;
            Contador = Cont;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            FrmLogin_Adm frmLogin_Adm = new FrmLogin_Adm();
            frmLogin_Adm.Show();
            this.Hide();    
            this.Close();   
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            DGB_Usuario.Visible = false;
            Frm_Productos Prod= new Frm_Productos("Admin"); 
            Prod.Show();
            this.Hide();
            Btn_Buscar.Visible = false;
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible = false;
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }
        private void Frm_Sistema_Load(object sender, EventArgs e)
        {
            lbl_Prueba.Text = "hola "+nombreCuenta+" Bienvenido al sistema";
            DGB_Usuario.Visible = false;
            Btn_Buscar.Visible = false; 
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible=false;
            Panel_HV.Visible = false;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = false;
            Panel_Cliente.Visible = false;
            clienteBindingSource.DataSource = _clienteController.GetAll();
            pedidoBindingSource.DataSource = _pedidoController.GetAll();
            heladoBindingSource.DataSource = _heladoController.GetAll();
            productoBindingSource.DataSource = _productoController.GetAll();
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
            historialVentaBindingSource.DataSource = _historialVController.GetAll();
            if (Contador==2)
            {
               Btn_HIstorialVentas.Visible = false;
                Btn_GUsuario.Visible = false;
                Panel_HeladoIv.Visible = false;
            }
        }
        //--------------------------------------------------------------------
        private void Btn_GUsuario_Click(object sender, EventArgs e)
        {
            DGB_Usuario.Visible = true;
            Btn_Buscar.Visible = true;
            Btn_Editar.Visible = true;
            Btn_Eliminar.Visible = true;
            Btn_Guardar.Visible = true;
            GroupBox_usuario.Visible = true;
            Btn_Nuevo.Visible = true;
            txt_Buscar.Visible = true;
            GroupBox_usuario.Enabled = false;
            Btn_HIstorialVentas.BackColor = Color.Maroon;
            Btn_GUsuario.BackColor = Color.Crimson;
            Btn_InvHelado.BackColor = Color.Maroon;
            Btn_InvProducto.BackColor = Color.Maroon;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Maroon;
            //-----------------------------------------------------------------
            Panel_HV.Visible = false;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = false;
            Panel_Cliente.Visible = false;
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void Btn_InvProducto_Click(object sender, EventArgs e)
        {
            //todos los botones a continuacion son los botones del gestionar usuario 
            DGB_Usuario.Visible = false;
            DGB_Usuario.Visible = false;
            Btn_Buscar.Visible = false;
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible = false;
            //------------------------------------------------------------
            Btn_HIstorialVentas.BackColor = Color.Maroon;
            Btn_GUsuario.BackColor = Color.Maroon;
            Btn_InvHelado.BackColor = Color.Maroon;
            Btn_InvProducto.BackColor = Color.Crimson;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Maroon;
            //------------------------------------------------------------
            Panel_HV.Visible = false;
            Panel_Producto.Visible = true;
            groupBoxverInProducto.Enabled = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = false;
            productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void Btn_InvHelado_Click(object sender, EventArgs e)
        {
            //todos los botones a continuacion son los botones del gestionar usuario 
            DGB_Usuario.Visible = false;
            Btn_Buscar.Visible = false;
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible = false;
            //-------------------------------------------------------------------------

            Btn_HIstorialVentas.BackColor = Color.Maroon;
            Btn_GUsuario.BackColor = Color.Maroon;
            Btn_InvHelado.BackColor = Color.Crimson;
            Btn_InvProducto.BackColor = Color.Maroon;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Maroon;
            //-------------------------------------------------------------------------
            Panel_HV.Visible = false;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = true;
            groupBox_Helado.Enabled = false;
            Panel_Pedido.Visible = false;
            Panel_Cliente.Visible = false;
            heladoBindingSource.DataSource = _heladoController.GetAll();
        }

        private void Btn_Pedidos_Click(object sender, EventArgs e)
        {
            //todos los botones a continuacion son los botones del gestionar usuario 
            DGB_Usuario.Visible = false;
            Btn_Buscar.Visible = false;
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible = false;
            //-------------------------------------------------------------------------

            Btn_HIstorialVentas.BackColor = Color.Maroon;
            Btn_GUsuario.BackColor = Color.Maroon;
            Btn_InvHelado.BackColor = Color.Maroon;
            Btn_InvProducto.BackColor = Color.Maroon;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Crimson;
            //----------------------------------------------------------------------
            Panel_HV.Visible = false;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = true;
            groupBox_Pedido.Enabled = false;
            Panel_Cliente.Visible = false;
            pedidoBindingSource.DataSource = _pedidoController.GetAll();
        }

        private void Btn_HIstorialVentas_Click(object sender, EventArgs e)
        {
            //todos los botones a continuacion son los botones del gestionar usuario 
            DGB_Usuario.Visible = false;
            Btn_Buscar.Visible = false;
            Btn_Editar.Visible = false;
            Btn_Eliminar.Visible = false;
            Btn_Guardar.Visible = false;
            GroupBox_usuario.Visible = false;
            Btn_Nuevo.Visible = false;
            txt_Buscar.Visible = false;
            txt_ganancia.Enabled = false;
            //-------------------------------------------------------------------------

            Btn_HIstorialVentas.BackColor = Color.Crimson;
            Btn_GUsuario.BackColor = Color.Maroon;
            Btn_InvHelado.BackColor = Color.Maroon;
            Btn_InvProducto.BackColor = Color.Maroon;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Maroon;
            //-------------------------------------------------------------------------
            Panel_HV.Visible = true;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = false;
            Panel_Cliente.Visible = false;
            historialVentaBindingSource.DataSource = _historialVController.GetAll();
        }
        //--------------------------------------------------------------------

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Desabilite los atributos (Textbox,Checkbox) para agregar o modificar un Usuario
            GroupBox_usuario.Enabled = false;
            //Elimina todo lo que se escribio en los atributos  (Textbox,Checkbox) del Usuario
            usuarioBindingSource.CancelEdit();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var user = (Usuario)usuarioBindingSource.Current;

            if (_isNew == true)
            {
                _usuarioController.Create(user);
            }
            else
            {
                _usuarioController.Update(user);
            }

            //Desabilite los atributos (Textbox,Checkbox) para agregar o modificar un Usuario
            GroupBox_usuario.Enabled = false;
            //Actualice el DataGridView 
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string par = txt_Buscar.Text;
            //Que en el DataGridView Muestre todos los usuarios que cumplan con el paramatro "par"
            usuarioBindingSource.DataSource = _usuarioController.Search(par);
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            //Variable Global _isNew sea True
            _isNew = true;
            //Habilite el GroupBox para escribir en los atributos (Textbox,Checkbox)
            GroupBox_usuario.Enabled = true;
            //Borre todo lo que antes estaba escrito para escribir los nuevos datos en los atributos (Textbox,Checkbox)
            usuarioBindingSource.AddNew();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            //Variable Global _isNew sea False Porque estamos modificando
            _isNew = false;
            //Habilite el GroupBox para escribir en los atributos (Textbox,Checkbox)
            GroupBox_usuario.Enabled = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Recuperar todo lo seleccionado del Usuario en el DataGridView
            var user = (Usuario)usuarioBindingSource.Current;
            //Mensaje 
            DialogResult dlr = MessageBox.Show("Estas Seguro de Eliminar?",
                "Heladeria la Deliciosa",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            //Si yo apreto Ok
            if (dlr == DialogResult.OK)
            {
                _usuarioController.Delete(user);
            }
            //Actualice el DataGridView 
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }
        //-----------------------------------------------------------------
        //todos los datos de historial de ventas 
        private void Btn_GananciaTHV_Click(object sender, EventArgs e)
        {

            txt_ganancia.Text = "";
            decimal GananciaT = _historialVController.GetAllGanancia();
            txt_ganancia.Text =GananciaT.ToString();
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
        }

        private void Btn_BuscarHV_Click(object sender, EventArgs e)
        {
            DateTime Finicio =dataTime_InicioHV.Value;
            DateTime Ffinal = dateTimeFinalHV.Value;
            historialVentaBindingSource.DataSource = _historialVController.SearchHV(Finicio,Ffinal);
        }

        private void btn_BuscarDescHV_Click(object sender, EventArgs e)
        {
            string par = txt_BuscarDescHV.Text;
            //Que en el DataGridView Muestre todos los usuarios que cumplan con el paramatro "par"
            historialVentaBindingSource.DataSource = _historialVController.Search(par);
        }

        private void Btn_GananciaFDHv_Click(object sender, EventArgs e)
        {
            DateTime Finicio = dataTime_InicioHV.Value;
            DateTime Ffinal = dateTimeFinalHV.Value;
            txt_ganancia.Text = "";
            decimal GananciaT = _historialVController.GetGananciaF(Finicio, Ffinal);
            txt_ganancia.Text=GananciaT.ToString();
            historialVentaBindingSource.DataSource = _historialVController.SearchHV(Finicio, Ffinal);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // de la clase Producto
            //aumentar cantidad a un producto
            var user = (Producto)productoBindingSource.Current;
            groupBoxverInProducto.Enabled = true;
            groupBox_Atri_Producto.Enabled = false;
        }
        private void AgregarCProducto(int Acantidad)
        {
            var Agregar = (Producto)productoBindingSource.Current;
                _productoController.Update(Agregar,Acantidad);
            //Desabilite los atributos (Textbox,Checkbox) para agregar o modificar un Usuario
            GroupBox_usuario.Enabled = false;
            //Actualice el DataGridView 
            productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void btn_AceptarCant_Click(object sender, EventArgs e)
        {
            var user = (Producto)productoBindingSource.Current;
            int ACantidad = int.Parse(txt_ACantidad.Text);
            AgregarCProducto(ACantidad);
            productoBindingSource.DataSource = _productoController.GetAll();
            groupBoxverInProducto.Enabled=false;
        }

        private void btn_CancelarP_Click(object sender, EventArgs e)
        {
            groupBoxverInProducto.Enabled = false;
            //Elimina todo lo que se escribio en los atributos  (Textbox,Checkbox) del Usuario
            productoBindingSource.CancelEdit();
            productoBindingSource.DataSource = _productoController.GetAll();
        }

        private void Btn_AgregarSHE_Click(object sender, EventArgs e)
        {
            //helado
            groupBox_Helado.Enabled = true;
            groupBox_Atrib_Helado.Enabled=false;

        }

        private void Btn_Agregar_CHinv_Click(object sender, EventArgs e)
        {
            //se agregara cantidad de porciones o tambien cantidad de Conos o varquillos o vasitos
            int Cantidad = int.Parse(txt_CantHv.Text);
                AgregarCHelado(Cantidad);
        }
        private void AgregarCHelado(int Acantidad)
        {
            var Agregar = (Helado)heladoBindingSource.Current;
            _heladoController.Update(Agregar, Acantidad);
            //Desabilite los atributos (Textbox,Checkbox) para agregar o modificar un Usuario
            groupBox_Helado.Enabled = false;
            //Actualice el DataGridView 
            heladoBindingSource.DataSource = _heladoController.GetAll();
        }

        private void btn_Cancelar_HeladoInv_Click(object sender, EventArgs e)
        {
            groupBox_Helado.Enabled=false;
            heladoBindingSource.DataSource = _heladoController.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //entregar pedido
            groupBox_Pedido.Enabled = false;
            pedidoBindingSource.DataSource = _pedidoController.GetAll();
        }

        private void Btn_GClientes_Click(object sender, EventArgs e)
        {
            groupBox_Cliente.Enabled = false;
            Panel_HV.Visible = false;
            Panel_Producto.Visible = false;
            Panel_HeladoIv.Visible = false;
            Panel_Pedido.Visible = false;
            Panel_Cliente.Visible = true;
            clienteBindingSource.DataSource = _clienteController.GetAll();
        }

        private void Btn_Prueba_Click(object sender, EventArgs e)
        {
            Panel_Cliente.Visible=true;
            clienteDataGridView.Visible=true;
            clienteDataGridView.DataSource = _clienteController.GetAll();
        }
        //-----------------------------------------------------------------
    }
}
