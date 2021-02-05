
namespace UD3_Aemet
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
            this.tbComunidades = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEspaña = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtComunidades = new System.Windows.Forms.TextBox();
            this.cboComunidades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAutonomas = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.btnProvincias = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cboLocalidades = new System.Windows.Forms.ComboBox();
            this.btnLocalidades = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnMontañosos = new System.Windows.Forms.Button();
            this.dgvMontañosos = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnPlayas = new System.Windows.Forms.Button();
            this.dgvPlayas = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.cboEstaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstación = new System.Windows.Forms.Button();
            this.dgvEstacion = new System.Windows.Forms.DataGridView();
            this.gbLocalidades = new System.Windows.Forms.GroupBox();
            this.tbComunidades.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontañosos)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayas)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComunidades
            // 
            this.tbComunidades.Controls.Add(this.tabPage1);
            this.tbComunidades.Controls.Add(this.tabPage2);
            this.tbComunidades.Controls.Add(this.tabPage3);
            this.tbComunidades.Controls.Add(this.tabPage4);
            this.tbComunidades.Controls.Add(this.tabPage5);
            this.tbComunidades.Controls.Add(this.tabPage6);
            this.tbComunidades.Controls.Add(this.tabPage7);
            this.tbComunidades.Location = new System.Drawing.Point(13, 13);
            this.tbComunidades.Name = "tbComunidades";
            this.tbComunidades.SelectedIndex = 0;
            this.tbComunidades.Size = new System.Drawing.Size(722, 445);
            this.tbComunidades.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEspaña);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "España";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEspaña
            // 
            this.txtEspaña.Location = new System.Drawing.Point(6, 17);
            this.txtEspaña.Multiline = true;
            this.txtEspaña.Name = "txtEspaña";
            this.txtEspaña.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEspaña.Size = new System.Drawing.Size(702, 396);
            this.txtEspaña.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtComunidades);
            this.tabPage2.Controls.Add(this.cboComunidades);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAutonomas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "C.Autónomas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtComunidades
            // 
            this.txtComunidades.Location = new System.Drawing.Point(6, 44);
            this.txtComunidades.Multiline = true;
            this.txtComunidades.Name = "txtComunidades";
            this.txtComunidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComunidades.Size = new System.Drawing.Size(702, 363);
            this.txtComunidades.TabIndex = 5;
            // 
            // cboComunidades
            // 
            this.cboComunidades.FormattingEnabled = true;
            this.cboComunidades.Location = new System.Drawing.Point(77, 17);
            this.cboComunidades.Name = "cboComunidades";
            this.cboComunidades.Size = new System.Drawing.Size(121, 21);
            this.cboComunidades.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C.Autónoma";
            // 
            // btnAutonomas
            // 
            this.btnAutonomas.Location = new System.Drawing.Point(633, 15);
            this.btnAutonomas.Name = "btnAutonomas";
            this.btnAutonomas.Size = new System.Drawing.Size(75, 23);
            this.btnAutonomas.TabIndex = 2;
            this.btnAutonomas.Text = "Buscar";
            this.btnAutonomas.UseVisualStyleBackColor = true;
            this.btnAutonomas.Click += new System.EventHandler(this.btnAutonomas_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cboProvincias);
            this.tabPage3.Controls.Add(this.btnProvincias);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Provincias";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(702, 365);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Provincia";
            // 
            // cboProvincias
            // 
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(80, 15);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(121, 21);
            this.cboProvincias.TabIndex = 3;
            // 
            // btnProvincias
            // 
            this.btnProvincias.Location = new System.Drawing.Point(633, 15);
            this.btnProvincias.Name = "btnProvincias";
            this.btnProvincias.Size = new System.Drawing.Size(75, 23);
            this.btnProvincias.TabIndex = 2;
            this.btnProvincias.Text = "Buscar";
            this.btnProvincias.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbLocalidades);
            this.tabPage4.Controls.Add(this.cboLocalidades);
            this.tabPage4.Controls.Add(this.btnLocalidades);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(714, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Localidades";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cboLocalidades
            // 
            this.cboLocalidades.FormattingEnabled = true;
            this.cboLocalidades.Location = new System.Drawing.Point(6, 17);
            this.cboLocalidades.Name = "cboLocalidades";
            this.cboLocalidades.Size = new System.Drawing.Size(188, 21);
            this.cboLocalidades.TabIndex = 3;
            // 
            // btnLocalidades
            // 
            this.btnLocalidades.Location = new System.Drawing.Point(633, 17);
            this.btnLocalidades.Name = "btnLocalidades";
            this.btnLocalidades.Size = new System.Drawing.Size(75, 23);
            this.btnLocalidades.TabIndex = 2;
            this.btnLocalidades.Text = "Buscar";
            this.btnLocalidades.UseVisualStyleBackColor = true;
            this.btnLocalidades.Click += new System.EventHandler(this.btnLocalidades_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnMontañosos);
            this.tabPage5.Controls.Add(this.dgvMontañosos);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(714, 419);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Macizos Montañosos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnMontañosos
            // 
            this.btnMontañosos.Location = new System.Drawing.Point(633, 15);
            this.btnMontañosos.Name = "btnMontañosos";
            this.btnMontañosos.Size = new System.Drawing.Size(75, 23);
            this.btnMontañosos.TabIndex = 2;
            this.btnMontañosos.Text = "Buscar";
            this.btnMontañosos.UseVisualStyleBackColor = true;
            // 
            // dgvMontañosos
            // 
            this.dgvMontañosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMontañosos.Location = new System.Drawing.Point(3, 53);
            this.dgvMontañosos.Name = "dgvMontañosos";
            this.dgvMontañosos.Size = new System.Drawing.Size(705, 360);
            this.dgvMontañosos.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnPlayas);
            this.tabPage6.Controls.Add(this.dgvPlayas);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(714, 419);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Playas";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnPlayas
            // 
            this.btnPlayas.Location = new System.Drawing.Point(633, 16);
            this.btnPlayas.Name = "btnPlayas";
            this.btnPlayas.Size = new System.Drawing.Size(75, 23);
            this.btnPlayas.TabIndex = 2;
            this.btnPlayas.Text = "Buscar";
            this.btnPlayas.UseVisualStyleBackColor = true;
            // 
            // dgvPlayas
            // 
            this.dgvPlayas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayas.Location = new System.Drawing.Point(4, 56);
            this.dgvPlayas.Name = "dgvPlayas";
            this.dgvPlayas.Size = new System.Drawing.Size(704, 360);
            this.dgvPlayas.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dtFin);
            this.tabPage7.Controls.Add(this.dtInicio);
            this.tabPage7.Controls.Add(this.cboEstaciones);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.btnEstación);
            this.tabPage7.Controls.Add(this.dgvEstacion);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(714, 419);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Estación Meteorológica";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(412, 19);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 6;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(206, 19);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 5;
            // 
            // cboEstaciones
            // 
            this.cboEstaciones.FormattingEnabled = true;
            this.cboEstaciones.Location = new System.Drawing.Point(62, 18);
            this.cboEstaciones.Name = "cboEstaciones";
            this.cboEstaciones.Size = new System.Drawing.Size(121, 21);
            this.cboEstaciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estación";
            // 
            // btnEstación
            // 
            this.btnEstación.Location = new System.Drawing.Point(633, 19);
            this.btnEstación.Name = "btnEstación";
            this.btnEstación.Size = new System.Drawing.Size(75, 23);
            this.btnEstación.TabIndex = 2;
            this.btnEstación.Text = "Buscar";
            this.btnEstación.UseVisualStyleBackColor = true;
            this.btnEstación.Click += new System.EventHandler(this.btnEstación_Click);
            // 
            // dgvEstacion
            // 
            this.dgvEstacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstacion.Location = new System.Drawing.Point(6, 56);
            this.dgvEstacion.Name = "dgvEstacion";
            this.dgvEstacion.Size = new System.Drawing.Size(702, 360);
            this.dgvEstacion.TabIndex = 1;
            // 
            // gbLocalidades
            // 
            this.gbLocalidades.Location = new System.Drawing.Point(6, 45);
            this.gbLocalidades.Name = "gbLocalidades";
            this.gbLocalidades.Size = new System.Drawing.Size(702, 368);
            this.gbLocalidades.TabIndex = 4;
            this.gbLocalidades.TabStop = false;
            this.gbLocalidades.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 463);
            this.Controls.Add(this.tbComunidades);
            this.Name = "Form1";
            this.Text = "Cliente Aemet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbComunidades.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMontañosos)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayas)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbComunidades;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboComunidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAutonomas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProvincias;
        private System.Windows.Forms.Button btnProvincias;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnLocalidades;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnMontañosos;
        private System.Windows.Forms.DataGridView dgvMontañosos;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnPlayas;
        private System.Windows.Forms.DataGridView dgvPlayas;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.ComboBox cboEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstación;
        private System.Windows.Forms.DataGridView dgvEstacion;
        private System.Windows.Forms.TextBox txtEspaña;
        private System.Windows.Forms.TextBox txtComunidades;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboLocalidades;
        private System.Windows.Forms.GroupBox gbLocalidades;
    }
}

