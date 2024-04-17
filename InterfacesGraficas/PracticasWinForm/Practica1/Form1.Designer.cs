namespace Practica1
{
    partial class MainWin
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
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBoton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoton1.Location = new System.Drawing.Point(251, 170);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(111, 38);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Clickeame!";
            this.btnBoton1.UseVisualStyleBackColor = false;
            this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtiqueta.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEtiqueta.Location = new System.Drawing.Point(208, 232);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(204, 18);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Soy un robot, haz lo que digo";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta_MouseMove_1);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(208, 268);
            this.txtTexto.MaxLength = 130;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(203, 20);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(210, 314);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBox.Size = new System.Drawing.Size(201, 34);
            this.txtBox.TabIndex = 3;
            this.txtBox.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBoton1);
            this.MinimizeBox = false;
            this.Name = "MainWin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de prueba";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.Click += new System.EventHandler(this.MainWin_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtBox;
    }
}

