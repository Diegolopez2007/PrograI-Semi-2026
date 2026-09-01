namespace DeduccionesSueldo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSueldo, lblISSS, lblAFP, lblISR, lblSueldoNeto;
        private System.Windows.Forms.TextBox txtSueldoBase, txtISSS, txtAFP, txtISR, txtSueldoNeto;
        private System.Windows.Forms.Button btnCalcular, btnLimpiar;
        private System.Windows.Forms.GroupBox grpResultados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldoBase = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.lblISSS = new System.Windows.Forms.Label();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.lblAFP = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.lblISR = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.grpResultados.SuspendLayout();
            this.SuspendLayout();

            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(25, 25);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(122, 20);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo Base $:";

            this.txtSueldoBase.Location = new System.Drawing.Point(153, 25);
            this.txtSueldoBase.Name = "txtSueldoBase";
            this.txtSueldoBase.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBase.TabIndex = 1;

            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(120, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(105, 43);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(255, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 43);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.grpResultados.Controls.Add(this.lblISSS);
            this.grpResultados.Controls.Add(this.txtISSS);
            this.grpResultados.Controls.Add(this.btnLimpiar);
            this.grpResultados.Controls.Add(this.btnCalcular);
            this.grpResultados.Controls.Add(this.lblAFP);
            this.grpResultados.Controls.Add(this.txtAFP);
            this.grpResultados.Controls.Add(this.lblISR);
            this.grpResultados.Controls.Add(this.txtISR);
            this.grpResultados.Controls.Add(this.lblSueldoNeto);
            this.grpResultados.Controls.Add(this.txtSueldoNeto);
            this.grpResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResultados.Location = new System.Drawing.Point(77, 67);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(385, 236);
            this.grpResultados.TabIndex = 4;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resumen de Deducciones";

            this.lblISSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISSS.Location = new System.Drawing.Point(25, 30);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(80, 20);
            this.lblISSS.TabIndex = 0;
            this.lblISSS.Text = "ISSS (3%):";

            this.txtISSS.Location = new System.Drawing.Point(139, 29);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.ReadOnly = true;
            this.txtISSS.Size = new System.Drawing.Size(230, 22);
            this.txtISSS.TabIndex = 1;

            this.lblAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(25, 65);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(108, 20);
            this.lblAFP.TabIndex = 2;
            this.lblAFP.Text = "AFP (7.25%):";

            this.txtAFP.Location = new System.Drawing.Point(139, 64);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(230, 22);
            this.txtAFP.TabIndex = 3;

            this.lblISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(25, 98);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(80, 20);
            this.lblISR.TabIndex = 4;
            this.lblISR.Text = "ISR:";

            this.txtISR.Location = new System.Drawing.Point(139, 97);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(230, 22);
            this.txtISR.TabIndex = 5;

            this.lblSueldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSueldoNeto.Location = new System.Drawing.Point(20, 135);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(90, 20);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "Sueldo Neto:";

            this.txtSueldoNeto.Location = new System.Drawing.Point(139, 132);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.ReadOnly = true;
            this.txtSueldoNeto.Size = new System.Drawing.Size(230, 22);
            this.txtSueldoNeto.TabIndex = 7;

            this.ClientSize = new System.Drawing.Size(514, 328);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSueldoBase);
            this.Controls.Add(this.grpResultados);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Deducciones";
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}