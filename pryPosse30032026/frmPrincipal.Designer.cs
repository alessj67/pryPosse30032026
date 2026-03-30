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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCantcafe = new System.Windows.Forms.Label();
            this.txtCantCafe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcafedia
            // 
            this.lblcafedia.AutoSize = true;
            this.lblcafedia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcafedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcafedia.Location = new System.Drawing.Point(124, 67);
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
            this.lblfecha.Location = new System.Drawing.Point(142, 145);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(48, 15);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblCantcafe
            // 
            this.lblCantcafe.AutoSize = true;
            this.lblCantcafe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantcafe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantcafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantcafe.Location = new System.Drawing.Point(91, 204);
            this.lblCantcafe.Name = "lblCantcafe";
            this.lblCantcafe.Size = new System.Drawing.Size(137, 15);
            this.lblCantcafe.TabIndex = 3;
            this.lblCantcafe.Text = "Cantidad  de cafecitos";
            this.lblCantcafe.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCantCafe
            // 
            this.txtCantCafe.Location = new System.Drawing.Point(234, 199);
            this.txtCantCafe.Name = "txtCantCafe";
            this.txtCantCafe.Size = new System.Drawing.Size(155, 20);
            this.txtCantCafe.TabIndex = 4;
            this.txtCantCafe.TextChanged += new System.EventHandler(this.txtCantCafe_TextChanged);
            // 
            // FrmCafecito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantCafe);
            this.Controls.Add(this.lblCantcafe);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcafedia);
            this.Name = "FrmCafecito";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcafedia;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCantcafe;
        private System.Windows.Forms.TextBox txtCantCafe;
    }
}

