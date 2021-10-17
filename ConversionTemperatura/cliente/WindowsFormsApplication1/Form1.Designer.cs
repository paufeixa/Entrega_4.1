namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CambioAC = new System.Windows.Forms.RadioButton();
            this.CambioAF = new System.Windows.Forms.RadioButton();
            this.ConectarButton = new System.Windows.Forms.Button();
            this.DesconectarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura";
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(174, 48);
            this.temperatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(244, 26);
            this.temperatura.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.CambioAC);
            this.groupBox1.Controls.Add(this.CambioAF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.temperatura);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 434);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // CambioAC
            // 
            this.CambioAC.AutoSize = true;
            this.CambioAC.Location = new System.Drawing.Point(174, 140);
            this.CambioAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CambioAC.Name = "CambioAC";
            this.CambioAC.Size = new System.Drawing.Size(354, 24);
            this.CambioAC.TabIndex = 7;
            this.CambioAC.TabStop = true;
            this.CambioAC.Text = "Grados Fahrenheit (ºF) a Grados Celsius (ºC)";
            this.CambioAC.UseVisualStyleBackColor = true;
            // 
            // CambioAF
            // 
            this.CambioAF.AutoSize = true;
            this.CambioAF.Location = new System.Drawing.Point(174, 105);
            this.CambioAF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CambioAF.Name = "CambioAF";
            this.CambioAF.Size = new System.Drawing.Size(354, 24);
            this.CambioAF.TabIndex = 8;
            this.CambioAF.TabStop = true;
            this.CambioAF.Text = "Grados Celsius (ºC) a Grados Fahrenheit (ºF)";
            this.CambioAF.UseVisualStyleBackColor = true;
            // 
            // ConectarButton
            // 
            this.ConectarButton.Location = new System.Drawing.Point(43, 12);
            this.ConectarButton.Name = "ConectarButton";
            this.ConectarButton.Size = new System.Drawing.Size(200, 75);
            this.ConectarButton.TabIndex = 7;
            this.ConectarButton.Text = "Conectar";
            this.ConectarButton.UseVisualStyleBackColor = true;
            this.ConectarButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // DesconectarButton
            // 
            this.DesconectarButton.Location = new System.Drawing.Point(43, 565);
            this.DesconectarButton.Name = "DesconectarButton";
            this.DesconectarButton.Size = new System.Drawing.Size(248, 100);
            this.DesconectarButton.TabIndex = 8;
            this.DesconectarButton.Text = "Desconectar";
            this.DesconectarButton.UseVisualStyleBackColor = true;
            this.DesconectarButton.Click += new System.EventHandler(this.DesconectarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
            this.Controls.Add(this.DesconectarButton);
            this.Controls.Add(this.ConectarButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CambioAC;
        private System.Windows.Forms.RadioButton CambioAF;
        private System.Windows.Forms.Button ConectarButton;
        private System.Windows.Forms.Button DesconectarButton;
    }
}

