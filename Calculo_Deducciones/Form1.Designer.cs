namespace Calculo_Deducciones
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;

        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.TextBox txtISSS;

        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.TextBox txtAFP;

        private System.Windows.Forms.Label lblGravable;
        private System.Windows.Forms.TextBox txtGravable;

        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.TextBox txtISR;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.TextBox txtLiquido;

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblISSS = new System.Windows.Forms.Label();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.lblAFP = new System.Windows.Forms.Label();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.lblGravable = new System.Windows.Forms.Label();
            this.txtGravable = new System.Windows.Forms.TextBox();
            this.lblISR = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(139, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 32);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Calculo De Las Deducciones";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(59, 74);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(107, 17);
            this.lblSueldo.TabIndex = 15;
            this.lblSueldo.Text = "Sueldo mensual:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSueldo.Location = new System.Drawing.Point(230, 71);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(300, 25);
            this.txtSueldo.TabIndex = 0;
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISSS.Location = new System.Drawing.Point(59, 113);
            this.lblISSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(69, 17);
            this.lblISSS.TabIndex = 14;
            this.lblISSS.Text = "ISSS (3%):";
            // 
            // txtISSS
            // 
            this.txtISSS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISSS.Location = new System.Drawing.Point(230, 110);
            this.txtISSS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.ReadOnly = true;
            this.txtISSS.Size = new System.Drawing.Size(300, 25);
            this.txtISSS.TabIndex = 1;
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAFP.Location = new System.Drawing.Point(59, 152);
            this.lblAFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(86, 17);
            this.lblAFP.TabIndex = 13;
            this.lblAFP.Text = "AFP (7.25%):";
            // 
            // txtAFP
            // 
            this.txtAFP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAFP.Location = new System.Drawing.Point(230, 149);
            this.txtAFP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(300, 25);
            this.txtAFP.TabIndex = 2;
            // 
            // lblGravable
            // 
            this.lblGravable.AutoSize = true;
            this.lblGravable.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravable.Location = new System.Drawing.Point(59, 191);
            this.lblGravable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGravable.Name = "lblGravable";
            this.lblGravable.Size = new System.Drawing.Size(114, 17);
            this.lblGravable.TabIndex = 12;
            this.lblGravable.Text = "Salario gravable:";
            // 
            // txtGravable
            // 
            this.txtGravable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGravable.Location = new System.Drawing.Point(230, 188);
            this.txtGravable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGravable.Name = "txtGravable";
            this.txtGravable.ReadOnly = true;
            this.txtGravable.Size = new System.Drawing.Size(300, 25);
            this.txtGravable.TabIndex = 3;
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISR.Location = new System.Drawing.Point(59, 230);
            this.lblISR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(31, 17);
            this.lblISR.TabIndex = 11;
            this.lblISR.Text = "ISR:";
            // 
            // txtISR
            // 
            this.txtISR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISR.Location = new System.Drawing.Point(230, 227);
            this.txtISR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(300, 25);
            this.txtISR.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Agency FB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(59, 269);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total deducciones:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(230, 266);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(300, 25);
            this.txtTotal.TabIndex = 5;
            // 
            // lblLiquido
            // 
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.Font = new System.Drawing.Font("Agency FB", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.Location = new System.Drawing.Point(59, 308);
            this.lblLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(92, 18);
            this.lblLiquido.TabIndex = 9;
            this.lblLiquido.Text = "SUELDO LÍQUIDO:";
            // 
            // txtLiquido
            // 
            this.txtLiquido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtLiquido.Location = new System.Drawing.Point(230, 305);
            this.txtLiquido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.ReadOnly = true;
            this.txtLiquido.Size = new System.Drawing.Size(300, 27);
            this.txtLiquido.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.Location = new System.Drawing.Point(145, 355);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 35);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(315, 355);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 35);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 425);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLiquido);
            this.Controls.Add(this.lblLiquido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtISR);
            this.Controls.Add(this.lblISR);
            this.Controls.Add(this.txtGravable);
            this.Controls.Add(this.lblGravable);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.lblAFP);
            this.Controls.Add(this.txtISSS);
            this.Controls.Add(this.lblISSS);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Deducciones ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}