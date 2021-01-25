namespace Arquitetura_de_Computadores_UFPR
{
    partial class FormHexDec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHexDec));
            this.lblBInario = new System.Windows.Forms.Label();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblBInario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBInario.ForeColor = System.Drawing.Color.White;
            this.lblBInario.Location = new System.Drawing.Point(116, 197);
            this.lblBInario.Name = "lblBInario";
            this.lblBInario.Size = new System.Drawing.Size(0, 22);
            this.lblBInario.TabIndex = 10;
            // 
            // tbBin
            // 
            this.tbBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBin.Location = new System.Drawing.Point(18, 39);
            this.tbBin.Name = "tbBin";
            this.tbBin.Size = new System.Drawing.Size(134, 26);
            this.tbBin.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decimal
            // 
            this.Decimal.AutoSize = true;
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(14, 12);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(104, 20);
            this.Decimal.TabIndex = 7;
            this.Decimal.Text = "Hexadecimal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbBin);
            this.panel1.Controls.Add(this.Decimal);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 77);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "Converter Hexadecimal para \r\nDecimal";
            // 
            // FormHexDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(298, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBInario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHexDec";
            this.Text = "Hexadecimal para Decimal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBInario;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Decimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}