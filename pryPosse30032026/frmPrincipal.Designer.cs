namespace pryPosse30032026
{
    partial class FrmCafecito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCafecito));
            this.lblcafedia = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblCantcafe = new System.Windows.Forms.Label();
            this.txtCantCafe = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcafedia
            // 
            this.lblcafedia.AutoSize = true;
            this.lblcafedia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcafedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcafedia.Location = new System.Drawing.Point(132, 25);
            this.lblcafedia.Name = "lblcafedia";
            this.lblcafedia.Size = new System.Drawing.Size(104, 20);
            this.lblcafedia.TabIndex = 0;
            this.lblcafedia.Text = "Cafe del dia ";
            this.lblcafedia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(300, 29);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 15);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha ";
            // 
            // lblCantcafe
            // 
            this.lblCantcafe.AutoSize = true;
            this.lblCantcafe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantcafe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantcafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantcafe.Location = new System.Drawing.Point(12, 88);
            this.lblCantcafe.Name = "lblCantcafe";
            this.lblCantcafe.Size = new System.Drawing.Size(137, 15);
            this.lblCantcafe.TabIndex = 3;
            this.lblCantcafe.Text = "Cantidad  de cafecitos";
            this.lblCantcafe.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCantCafe
            // 
            this.txtCantCafe.Location = new System.Drawing.Point(193, 83);
            this.txtCantCafe.Name = "txtCantCafe";
            this.txtCantCafe.Size = new System.Drawing.Size(155, 20);
            this.txtCantCafe.TabIndex = 4;
            this.txtCantCafe.TextChanged += new System.EventHandler(this.txtCantCafe_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(106, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(141, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "+ 1 Cafecito";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCafecito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 269);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantCafe);
            this.Controls.Add(this.lblCantcafe);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcafedia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCafecito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafecito";
            this.Load += new System.EventHandler(this.FrmCafecito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcafedia;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblCantcafe;
        private System.Windows.Forms.TextBox txtCantCafe;
        private System.Windows.Forms.Button btnAceptar;
    }
}

