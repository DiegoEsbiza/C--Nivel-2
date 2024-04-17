namespace Practica_1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lvlFecha = new System.Windows.Forms.Label();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.rbWizard = new System.Windows.Forms.RadioButton();
            this.rbMuggle = new System.Windows.Forms.RadioButton();
            this.rbSquib = new System.Windows.Forms.RadioButton();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.numNumero = new System.Windows.Forms.NumericUpDown();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListView();
            this.gpbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(213, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(144, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(213, 79);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(219, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // lvlFecha
            // 
            this.lvlFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlFecha.AutoSize = true;
            this.lvlFecha.Location = new System.Drawing.Point(82, 79);
            this.lvlFecha.Name = "lvlFecha";
            this.lvlFecha.Size = new System.Drawing.Size(106, 13);
            this.lvlFecha.TabIndex = 0;
            this.lvlFecha.Text = "Fecha de nacimiento";
            // 
            // chkChocolate
            // 
            this.chkChocolate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(213, 105);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(86, 17);
            this.chkChocolate.TabIndex = 2;
            this.chkChocolate.Text = "¿Chocolate?";
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // rbWizard
            // 
            this.rbWizard.AutoSize = true;
            this.rbWizard.Checked = true;
            this.rbWizard.Location = new System.Drawing.Point(31, 28);
            this.rbWizard.Name = "rbWizard";
            this.rbWizard.Size = new System.Drawing.Size(58, 17);
            this.rbWizard.TabIndex = 6;
            this.rbWizard.TabStop = true;
            this.rbWizard.Text = "Wizard";
            this.rbWizard.UseVisualStyleBackColor = true;
            // 
            // rbMuggle
            // 
            this.rbMuggle.AutoSize = true;
            this.rbMuggle.Location = new System.Drawing.Point(139, 28);
            this.rbMuggle.Name = "rbMuggle";
            this.rbMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbMuggle.TabIndex = 6;
            this.rbMuggle.TabStop = true;
            this.rbMuggle.Text = "Muggle";
            this.rbMuggle.UseVisualStyleBackColor = true;
            // 
            // rbSquib
            // 
            this.rbSquib.AutoSize = true;
            this.rbSquib.Location = new System.Drawing.Point(258, 28);
            this.rbSquib.Name = "rbSquib";
            this.rbSquib.Size = new System.Drawing.Size(52, 17);
            this.rbSquib.TabIndex = 6;
            this.rbSquib.TabStop = true;
            this.rbSquib.Text = "Squib";
            this.rbSquib.UseVisualStyleBackColor = true;
            // 
            // gpbTipo
            // 
            this.gpbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbTipo.Controls.Add(this.rbSquib);
            this.gpbTipo.Controls.Add(this.rbMuggle);
            this.gpbTipo.Controls.Add(this.rbWizard);
            this.gpbTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbTipo.Location = new System.Drawing.Point(147, 128);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(340, 60);
            this.gpbTipo.TabIndex = 3;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(213, 194);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(219, 21);
            this.cbColor.Sorted = true;
            this.cbColor.TabIndex = 4;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(157, 197);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // numNumero
            // 
            this.numNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumero.Location = new System.Drawing.Point(212, 221);
            this.numNumero.Name = "numNumero";
            this.numNumero.Size = new System.Drawing.Size(220, 20);
            this.numNumero.TabIndex = 5;
            // 
            // lblNúmero
            // 
            this.lblNúmero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNúmero.AutoSize = true;
            this.lblNúmero.Location = new System.Drawing.Point(144, 223);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(44, 13);
            this.lblNúmero.TabIndex = 0;
            this.lblNúmero.Text = "Número";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVerPerfil.Location = new System.Drawing.Point(212, 257);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(74, 29);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Persona";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAgregar.Location = new System.Drawing.Point(358, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 28);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstLista
            // 
            this.lstLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLista.HideSelection = false;
            this.lstLista.Location = new System.Drawing.Point(210, 310);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(221, 91);
            this.lstLista.TabIndex = 8;
            this.lstLista.UseCompatibleStateImageBehavior = false;
            this.lstLista.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 395);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNúmero);
            this.Controls.Add(this.numNumero);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.chkChocolate);
            this.Controls.Add(this.lvlFecha);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lvlFecha;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.RadioButton rbWizard;
        private System.Windows.Forms.RadioButton rbMuggle;
        private System.Windows.Forms.RadioButton rbSquib;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numNumero;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lstLista;
    }
}

