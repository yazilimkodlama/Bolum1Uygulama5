namespace Bolum1Uygulama5
{
    partial class Form1
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
            this.btnMesaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(226, 69);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(75, 23);
            this.btnMesaj.TabIndex = 0;
            this.btnMesaj.Text = "Mesaj Ver";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 221);
            this.Controls.Add(this.btnMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesaj;
    }
}

