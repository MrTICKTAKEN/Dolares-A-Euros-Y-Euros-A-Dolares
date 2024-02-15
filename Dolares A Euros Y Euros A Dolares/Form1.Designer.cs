namespace Dolares_A_Euros_Y_Euros_A_Dolares
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
            this.CAMBDOtextBox1 = new System.Windows.Forms.TextBox();
            this.CANTItextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CONVERbutton1 = new System.Windows.Forms.Button();
            this.EUaDOlabel4 = new System.Windows.Forms.Label();
            this.DOaEUlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CAMBDOtextBox1
            // 
            this.CAMBDOtextBox1.Location = new System.Drawing.Point(59, 85);
            this.CAMBDOtextBox1.Name = "CAMBDOtextBox1";
            this.CAMBDOtextBox1.Size = new System.Drawing.Size(100, 20);
            this.CAMBDOtextBox1.TabIndex = 0;
            // 
            // CANTItextBox2
            // 
            this.CANTItextBox2.Location = new System.Drawing.Point(247, 85);
            this.CANTItextBox2.Name = "CANTItextBox2";
            this.CANTItextBox2.Size = new System.Drawing.Size(100, 20);
            this.CANTItextBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOLARES A EUROS Y EUROS A DOLARES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR ACTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CANTIDAD A CONVERTIR";
            // 
            // CONVERbutton1
            // 
            this.CONVERbutton1.Location = new System.Drawing.Point(163, 113);
            this.CONVERbutton1.Name = "CONVERbutton1";
            this.CONVERbutton1.Size = new System.Drawing.Size(84, 23);
            this.CONVERbutton1.TabIndex = 5;
            this.CONVERbutton1.Text = "RESULTADO";
            this.CONVERbutton1.UseVisualStyleBackColor = true;
            this.CONVERbutton1.Click += new System.EventHandler(this.CONVERbutton1_Click);
            // 
            // EUaDOlabel4
            // 
            this.EUaDOlabel4.AutoSize = true;
            this.EUaDOlabel4.Location = new System.Drawing.Point(92, 161);
            this.EUaDOlabel4.Name = "EUaDOlabel4";
            this.EUaDOlabel4.Size = new System.Drawing.Size(0, 13);
            this.EUaDOlabel4.TabIndex = 6;
            // 
            // DOaEUlabel5
            // 
            this.DOaEUlabel5.AutoSize = true;
            this.DOaEUlabel5.Location = new System.Drawing.Point(277, 161);
            this.DOaEUlabel5.Name = "DOaEUlabel5";
            this.DOaEUlabel5.Size = new System.Drawing.Size(0, 13);
            this.DOaEUlabel5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 270);
            this.Controls.Add(this.DOaEUlabel5);
            this.Controls.Add(this.EUaDOlabel4);
            this.Controls.Add(this.CONVERbutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANTItextBox2);
            this.Controls.Add(this.CAMBDOtextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CAMBDOtextBox1;
        private System.Windows.Forms.TextBox CANTItextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CONVERbutton1;
        private System.Windows.Forms.Label EUaDOlabel4;
        private System.Windows.Forms.Label DOaEUlabel5;
    }
}

