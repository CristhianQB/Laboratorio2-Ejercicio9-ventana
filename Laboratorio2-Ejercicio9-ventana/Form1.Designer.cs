namespace Laboratorio2_Ejercicio9_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            txtb2 = new System.Windows.Forms.TextBox();
            txtb3 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(126, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(64, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Número 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(64, 116);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "Número 2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(64, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(81, 21);
            label4.TabIndex = 3;
            label4.Text = "Número 3";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(184, 65);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(116, 23);
            txtb1.TabIndex = 4;
            // 
            // txtb2
            // 
            txtb2.Location = new System.Drawing.Point(184, 114);
            txtb2.Name = "txtb2";
            txtb2.Size = new System.Drawing.Size(116, 23);
            txtb2.TabIndex = 5;
            // 
            // txtb3
            // 
            txtb3.Location = new System.Drawing.Point(184, 162);
            txtb3.Name = "txtb3";
            txtb3.Size = new System.Drawing.Size(117, 23);
            txtb3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(48, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(97, 21);
            label5.TabIndex = 7;
            label5.Text = "El mayor es :";
            label5.Click += label5_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(173, 259);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(45, 28);
            lbl.TabIndex = 8;
            lbl.Text = "000";
            lbl.Click += label6_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(110, 318);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(71, 32);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(509, 450);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(label5);
            Controls.Add(txtb3);
            Controls.Add(txtb2);
            Controls.Add(txtb1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
    }
}
