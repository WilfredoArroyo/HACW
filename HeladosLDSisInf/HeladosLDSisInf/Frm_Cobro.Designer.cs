namespace HeladosLDSisInf
{
    partial class Frm_Cobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Qr = new System.Windows.Forms.Button();
            this.Btn_Efectivo = new System.Windows.Forms.Button();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.pictureBox_Qr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qr)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Qr
            // 
            this.Btn_Qr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Qr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Qr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Qr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Qr.ForeColor = System.Drawing.Color.White;
            this.Btn_Qr.Location = new System.Drawing.Point(124, 366);
            this.Btn_Qr.Name = "Btn_Qr";
            this.Btn_Qr.Size = new System.Drawing.Size(243, 88);
            this.Btn_Qr.TabIndex = 8;
            this.Btn_Qr.Text = "PAGAR POR QR";
            this.Btn_Qr.UseVisualStyleBackColor = false;
            this.Btn_Qr.Click += new System.EventHandler(this.Btn_Qr_Click);
            // 
            // Btn_Efectivo
            // 
            this.Btn_Efectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_Efectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Efectivo.ForeColor = System.Drawing.Color.White;
            this.Btn_Efectivo.Location = new System.Drawing.Point(436, 366);
            this.Btn_Efectivo.Name = "Btn_Efectivo";
            this.Btn_Efectivo.Size = new System.Drawing.Size(267, 88);
            this.Btn_Efectivo.TabIndex = 9;
            this.Btn_Efectivo.Text = "PAGAR EN EFECTIVO";
            this.Btn_Efectivo.UseVisualStyleBackColor = false;
            this.Btn_Efectivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pago.ForeColor = System.Drawing.Color.White;
            this.lbl_Pago.Location = new System.Drawing.Point(208, 174);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(403, 69);
            this.lbl_Pago.TabIndex = 17;
            this.lbl_Pago.Text = "PRECIO TOTAL: 13,00Bs";
            // 
            // pictureBox_Qr
            // 
            this.pictureBox_Qr.BackgroundImage = global::HeladosLDSisInf.Properties.Resources.QrImage;
            this.pictureBox_Qr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Qr.Location = new System.Drawing.Point(231, 45);
            this.pictureBox_Qr.Name = "pictureBox_Qr";
            this.pictureBox_Qr.Size = new System.Drawing.Size(299, 291);
            this.pictureBox_Qr.TabIndex = 18;
            this.pictureBox_Qr.TabStop = false;
            // 
            // Frm_Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeladosLDSisInf.Properties.Resources.FRmproductopantalla;
            this.ClientSize = new System.Drawing.Size(841, 499);
            this.Controls.Add(this.pictureBox_Qr);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.Btn_Efectivo);
            this.Controls.Add(this.Btn_Qr);
            this.Name = "Frm_Cobro";
            this.Text = "Frm_Cobro";
            this.Load += new System.EventHandler(this.Frm_Cobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Qr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Qr;
        private System.Windows.Forms.Button Btn_Efectivo;
        private System.Windows.Forms.Label lbl_Pago;
        private System.Windows.Forms.PictureBox pictureBox_Qr;
    }
}