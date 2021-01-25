namespace Arquitetura_de_Computadores_UFPR
{
    partial class FormDecHexa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDecHexa));
            this.lblBInario = new System.Windows.Forms.Label();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBInario
            // 
            this.lblBInario.AutoSize = true;
            this.lblBInario.BackColor = System.Drawing.Color.Transparent;
            this.lblBInario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBInario.ForeColor = System.Drawing.Color.White;
            this.lblBInario.Location = new System.Drawing.Point(28, 195);
            this.lblBInario.Name = "lblBInario";
            this.lblBInario.Size = new System.Drawing.Size(0, 18);
            this.lblBInario.TabIndex = 14;
            // 
            // tbDec
            // 
            this.tbDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDec.Location = new System.Drawing.Point(16, 39);
            this.tbDec.Name = "tbDec";
            this.tbDec.Size = new System.Drawing.Size(120, 26);
            this.tbDec.TabIndex = 13;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(142, 39);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(95, 26);
            this.btnConverter.TabIndex = 12;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // Decimal
            // 
            this.Decimal.AutoSize = true;
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(12, 16);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(70, 20);
            this.Decimal.TabIndex = 11;
            this.Decimal.Text = "Decimal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConverter);
            this.panel1.Controls.Add(this.Decimal);
            this.panel1.Controls.Add(this.tbDec);
            this.panel1.Location = new System.Drawing.Point(15, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 81);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 16;
            this.label1.Text = "Converter Decimal para \r\nHexadecimal\r\n";
            // 
            // FormDecHexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(299, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBInario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDecHexa";
            this.Text = "Decimal para Hexadecimal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBInario;
        private System.Windows.Forms.TextBox tbDec;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label Decimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}