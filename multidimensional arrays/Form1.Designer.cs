namespace multidimensional_arrays
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
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnPrint1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(80, 99);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(571, 291);
            this.txtResultaat.TabIndex = 0;
            // 
            // btnPrint1
            // 
            this.btnPrint1.Location = new System.Drawing.Point(243, 29);
            this.btnPrint1.Name = "btnPrint1";
            this.btnPrint1.Size = new System.Drawing.Size(281, 51);
            this.btnPrint1.TabIndex = 1;
            this.btnPrint1.Text = "Print";
            this.btnPrint1.UseVisualStyleBackColor = true;
            this.btnPrint1.Click += new System.EventHandler(this.btnPrint1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint1);
            this.Controls.Add(this.txtResultaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Button btnPrint1;
    }
}

