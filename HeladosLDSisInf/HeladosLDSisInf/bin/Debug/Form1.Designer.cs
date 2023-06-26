namespace HeladosLDSisInf
{
    partial class Frm_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio));
            this.Empezar = new System.Windows.Forms.Button();
            this.PBox_Img2 = new System.Windows.Forms.PictureBox();
            this.Pbox_Img1 = new System.Windows.Forms.PictureBox();
            this.Btn_Siguiente = new System.Windows.Forms.Button();
            this.Lb_IngNom = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBox_Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_Img1)).BeginInit();
            this.SuspendLayout();
            // 
            // Empezar
            // 
            this.Empezar.BackColor = System.Drawing.Color.Maroon;
            this.Empezar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Empezar.FlatAppearance.BorderSize = 3;
            this.Empezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Empezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.Empezar, "Empezar");
            this.Empezar.ForeColor = System.Drawing.Color.White;
            this.Empezar.Name = "Empezar";
            this.Empezar.UseVisualStyleBackColor = false;
            this.Empezar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBox_Img2
            // 
            resources.ApplyResources(this.PBox_Img2, "PBox_Img2");
            this.PBox_Img2.Image = global::HeladosLDSisInf.Properties.Resources.heladosImg2;
            this.PBox_Img2.Name = "PBox_Img2";
            this.PBox_Img2.TabStop = false;
            // 
            // Pbox_Img1
            // 
            resources.ApplyResources(this.Pbox_Img1, "Pbox_Img1");
            this.Pbox_Img1.Image = global::HeladosLDSisInf.Properties.Resources.HELADOSLADELICIOSA;
            this.Pbox_Img1.Name = "Pbox_Img1";
            this.Pbox_Img1.TabStop = false;
            // 
            // Btn_Siguiente
            // 
            this.Btn_Siguiente.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Siguiente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Btn_Siguiente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Siguiente.FlatAppearance.BorderSize = 2;
            this.Btn_Siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.Btn_Siguiente, "Btn_Siguiente");
            this.Btn_Siguiente.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Siguiente.Name = "Btn_Siguiente";
            this.Btn_Siguiente.UseVisualStyleBackColor = false;
            this.Btn_Siguiente.Click += new System.EventHandler(this.Btn_Siguiente_Click);
            // 
            // Lb_IngNom
            // 
            resources.ApplyResources(this.Lb_IngNom, "Lb_IngNom");
            this.Lb_IngNom.BackColor = System.Drawing.Color.Transparent;
            this.Lb_IngNom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_IngNom.Name = "Lb_IngNom";
            this.Lb_IngNom.Click += new System.EventHandler(this.Lb_IngNom_Click);
            // 
            // txt_Nom
            // 
            this.txt_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Nom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            resources.ApplyResources(this.txt_Nom, "txt_Nom");
            this.txt_Nom.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.TextChanged += new System.EventHandler(this.txt_Nom_TextChanged_1);
            // 
            // Frm_Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::HeladosLDSisInf.Properties.Resources.heladosImg2;
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.Lb_IngNom);
            this.Controls.Add(this.Btn_Siguiente);
            this.Controls.Add(this.PBox_Img2);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.Pbox_Img1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Frm_Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBox_Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbox_Img1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbox_Img1;
        private System.Windows.Forms.Button Empezar;
        private System.Windows.Forms.PictureBox PBox_Img2;
        private System.Windows.Forms.Button Btn_Siguiente;
        private System.Windows.Forms.Label Lb_IngNom;
        private System.Windows.Forms.TextBox txt_Nom;
    }
}

