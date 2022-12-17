
namespace OrtalamaHesaplamaUygulaması
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOrtaokul = new System.Windows.Forms.Button();
            this.BtnLise = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ortalama Hesaplama Uygulaması";
            // 
            // BtnOrtaokul
            // 
            this.BtnOrtaokul.Location = new System.Drawing.Point(197, 96);
            this.BtnOrtaokul.Name = "BtnOrtaokul";
            this.BtnOrtaokul.Size = new System.Drawing.Size(169, 52);
            this.BtnOrtaokul.TabIndex = 1;
            this.BtnOrtaokul.Text = "Ortaokul";
            this.BtnOrtaokul.UseVisualStyleBackColor = true;
            this.BtnOrtaokul.Click += new System.EventHandler(this.BtnOrtaokul_Click);
            // 
            // BtnLise
            // 
            this.BtnLise.Location = new System.Drawing.Point(197, 175);
            this.BtnLise.Name = "BtnLise";
            this.BtnLise.Size = new System.Drawing.Size(169, 52);
            this.BtnLise.TabIndex = 2;
            this.BtnLise.Text = "Lise";
            this.BtnLise.UseVisualStyleBackColor = true;
            this.BtnLise.Click += new System.EventHandler(this.BtnLise_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 144);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(560, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnLise);
            this.Controls.Add(this.BtnOrtaokul);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOrtaokul;
        private System.Windows.Forms.Button BtnLise;
        private System.Windows.Forms.Label label3;
    }
}

