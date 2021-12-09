namespace AppInguiri
{
    partial class FrmProductoActualiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoActualiza));
            this.PanSuperior = new System.Windows.Forms.Panel();
            this.NdMinimo = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbxPresentacion = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbxLaboratorio = new System.Windows.Forms.ComboBox();
            this.txtPrincipioActivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkAlternativo = new System.Windows.Forms.CheckBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.CmdGuardar = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.PanSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NdMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSuperior
            // 
            this.PanSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanSuperior.Controls.Add(this.NdMinimo);
            this.PanSuperior.Controls.Add(this.Label4);
            this.PanSuperior.Controls.Add(this.Label3);
            this.PanSuperior.Controls.Add(this.cbxPresentacion);
            this.PanSuperior.Controls.Add(this.Label2);
            this.PanSuperior.Controls.Add(this.cbxLaboratorio);
            this.PanSuperior.Controls.Add(this.txtPrincipioActivo);
            this.PanSuperior.Controls.Add(this.label1);
            this.PanSuperior.Controls.Add(this.ChkAlternativo);
            this.PanSuperior.Controls.Add(this.LblCodigo);
            this.PanSuperior.Controls.Add(this.Label6);
            this.PanSuperior.Controls.Add(this.txtDescripcion);
            this.PanSuperior.Controls.Add(this.Label10);
            this.PanSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanSuperior.Name = "PanSuperior";
            this.PanSuperior.Size = new System.Drawing.Size(483, 246);
            this.PanSuperior.TabIndex = 6;
            // 
            // NdMinimo
            // 
            this.NdMinimo.Location = new System.Drawing.Point(404, 216);
            this.NdMinimo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NdMinimo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NdMinimo.Name = "NdMinimo";
            this.NdMinimo.Size = new System.Drawing.Size(67, 20);
            this.NdMinimo.TabIndex = 46;
            this.NdMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NdMinimo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(316, 220);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 13);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "Stock Mínimo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(11, 219);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(81, 13);
            this.Label3.TabIndex = 44;
            this.Label3.Text = "Presentación";
            // 
            // cbxPresentacion
            // 
            this.cbxPresentacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPresentacion.FormattingEnabled = true;
            this.cbxPresentacion.Location = new System.Drawing.Point(99, 215);
            this.cbxPresentacion.Name = "cbxPresentacion";
            this.cbxPresentacion.Size = new System.Drawing.Size(205, 21);
            this.cbxPresentacion.TabIndex = 42;
            this.cbxPresentacion.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 193);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 43;
            this.Label2.Text = "Laboratorio";
            // 
            // cbxLaboratorio
            // 
            this.cbxLaboratorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLaboratorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLaboratorio.FormattingEnabled = true;
            this.cbxLaboratorio.Location = new System.Drawing.Point(99, 188);
            this.cbxLaboratorio.Name = "cbxLaboratorio";
            this.cbxLaboratorio.Size = new System.Drawing.Size(371, 21);
            this.cbxLaboratorio.TabIndex = 41;
            this.cbxLaboratorio.TabStop = false;
            // 
            // txtPrincipioActivo
            // 
            this.txtPrincipioActivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrincipioActivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrincipioActivo.ForeColor = System.Drawing.Color.Black;
            this.txtPrincipioActivo.Location = new System.Drawing.Point(99, 110);
            this.txtPrincipioActivo.MaxLength = 500;
            this.txtPrincipioActivo.Multiline = true;
            this.txtPrincipioActivo.Name = "txtPrincipioActivo";
            this.txtPrincipioActivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrincipioActivo.Size = new System.Drawing.Size(372, 73);
            this.txtPrincipioActivo.TabIndex = 39;
            this.txtPrincipioActivo.Tag = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Principio\r\nActivo\r\n";
            // 
            // ChkAlternativo
            // 
            this.ChkAlternativo.AutoSize = true;
            this.ChkAlternativo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkAlternativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAlternativo.Location = new System.Drawing.Point(383, 7);
            this.ChkAlternativo.Name = "ChkAlternativo";
            this.ChkAlternativo.Size = new System.Drawing.Size(87, 17);
            this.ChkAlternativo.TabIndex = 38;
            this.ChkAlternativo.TabStop = false;
            this.ChkAlternativo.Text = "Alternativo";
            this.ChkAlternativo.UseVisualStyleBackColor = true;
            // 
            // LblCodigo
            // 
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Green;
            this.LblCodigo.Location = new System.Drawing.Point(99, 7);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(122, 20);
            this.LblCodigo.TabIndex = 34;
            this.LblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(11, 11);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(46, 13);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "Código";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(99, 33);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 73);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Tag = "2";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(11, 36);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(74, 13);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "Descripcion";
            // 
            // CmdGuardar
            // 
            this.CmdGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("CmdGuardar.Image")));
            this.CmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdGuardar.Location = new System.Drawing.Point(298, 252);
            this.CmdGuardar.Name = "CmdGuardar";
            this.CmdGuardar.Size = new System.Drawing.Size(84, 26);
            this.CmdGuardar.TabIndex = 4;
            this.CmdGuardar.Text = "&Guardar";
            this.CmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdGuardar.UseVisualStyleBackColor = true;
            this.CmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancelar.Image")));
            this.CmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancelar.Location = new System.Drawing.Point(388, 252);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(84, 26);
            this.CmdCancelar.TabIndex = 5;
            this.CmdCancelar.Text = "&Cancelar";
            this.CmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // FrmProductoActualiza
            // 
            this.AcceptButton = this.CmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.CmdCancelar;
            this.ClientSize = new System.Drawing.Size(483, 282);
            this.ControlBox = false;
            this.Controls.Add(this.PanSuperior);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductoActualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actualizar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProveedorActualiza_FormClosing);
            this.Load += new System.EventHandler(this.FrmProveedorActualiza_Load);
            this.PanSuperior.ResumeLayout(false);
            this.PanSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NdMinimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CmdCancelar;
        protected System.Windows.Forms.Button CmdGuardar;
        internal System.Windows.Forms.Panel PanSuperior;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.CheckBox ChkAlternativo;
        internal System.Windows.Forms.NumericUpDown NdMinimo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbxPresentacion;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbxLaboratorio;
        internal System.Windows.Forms.TextBox txtPrincipioActivo;
        internal System.Windows.Forms.Label label1;
    }
}