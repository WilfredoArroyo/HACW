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
        UsuarioController _usuarioController= new UsuarioController();
        
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
            usuarioBindingSource.DataSource = _usuarioController.GetAll();
            if (Contador==2)
            {
               Btn_HIstorialVentas.Visible = false;
                Btn_GUsuario.Visible = false;   
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
            //-------------------------------------------------------------------------

            Btn_HIstorialVentas.BackColor = Color.Crimson;
            Btn_GUsuario.BackColor = Color.Maroon;
            Btn_InvHelado.BackColor = Color.Maroon;
            Btn_InvProducto.BackColor = Color.Maroon;
            Btn_IrProductos.BackColor = Color.Maroon;
            Btn_Pedidos.BackColor = Color.Maroon;
            //-------------------------------------------------------------------------
            Panel_HV.Visible = true;
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
    }
}
