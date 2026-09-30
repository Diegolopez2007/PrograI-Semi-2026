namespace miPrimeaAplicacion
{
    partial class frmNotas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResultadoPromedio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblResultadoEstado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grdNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(30, 25);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno:";
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(90, 22);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(220, 21);
            this.cmbAlumno.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(30, 60);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia:";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(90, 57);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(220, 21);
            this.cmbMateria.TabIndex = 3;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(30, 95);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 4;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(90, 92);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(220, 21);
            this.cmbPeriodo.TabIndex = 5;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(330, 25);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(42, 13);
            this.lblNota1.TabIndex = 6;
            this.lblNota1.Text = "Nota 1:";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(380, 22);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(60, 20);
            this.txtNota1.TabIndex = 7;
            this.txtNota1.Text = "0";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(330, 60);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(42, 13);
            this.lblNota2.TabIndex = 8;
            this.lblNota2.Text = "Nota 2:";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(380, 57);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(60, 20);
            this.txtNota2.TabIndex = 9;
            this.txtNota2.Text = "0";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(330, 95);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(42, 13);
            this.lblNota3.TabIndex = 10;
            this.lblNota3.Text = "Nota 3:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(380, 92);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(60, 20);
            this.txtNota3.TabIndex = 11;
            this.txtNota3.Text = "0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(460, 25);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(63, 13);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblResultadoPromedio
            // 
            this.lblResultadoPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoPromedio.Location = new System.Drawing.Point(530, 20);
            this.lblResultadoPromedio.Name = "lblResultadoPromedio";
            this.lblResultadoPromedio.Size = new System.Drawing.Size(60, 23);
            this.lblResultadoPromedio.TabIndex = 13;
            this.lblResultadoPromedio.Text = "0.0";
            this.lblResultadoPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(460, 60);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado:";
            // 
            // lblResultadoEstado
            // 
            this.lblResultadoEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultadoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEstado.Location = new System.Drawing.Point(530, 55);
            this.lblResultadoEstado.Name = "lblResultadoEstado";
            this.lblResultadoEstado.Size = new System.Drawing.Size(90, 23);
            this.lblResultadoEstado.TabIndex = 15;
            this.lblResultadoEstado.Text = "-";
            this.lblResultadoEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(545, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(463, 90);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grdNotas
            // 
            this.grdNotas.AllowUserToAddRows = false;
            this.grdNotas.AllowUserToDeleteRows = false;
            this.grdNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotas.Location = new System.Drawing.Point(30, 135);
            this.grdNotas.MultiSelect = false;
            this.grdNotas.Name = "grdNotas";
            this.grdNotas.ReadOnly = true;
            this.grdNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNotas.Size = new System.Drawing.Size(590, 200);
            this.grdNotas.TabIndex = 18;
            this.grdNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNotas_CellContentClick);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 360);
            this.Controls.Add(this.grdNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultadoEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblResultadoPromedio);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Name = "frmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Notas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResultadoPromedio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblResultadoEstado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grdNotas;
    }
}