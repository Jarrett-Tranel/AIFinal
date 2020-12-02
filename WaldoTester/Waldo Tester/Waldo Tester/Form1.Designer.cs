namespace Waldo_Tester
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yesBT = new System.Windows.Forms.Button();
            this.noBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label1.Location = new System.Drawing.Point(82, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Does this image contain Waldo?";
            // 
            // yesBT
            // 
            this.yesBT.BackColor = System.Drawing.Color.LimeGreen;
            this.yesBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.yesBT.Location = new System.Drawing.Point(53, 463);
            this.yesBT.Name = "yesBT";
            this.yesBT.Size = new System.Drawing.Size(359, 81);
            this.yesBT.TabIndex = 2;
            this.yesBT.Text = "YES";
            this.yesBT.UseVisualStyleBackColor = false;
            this.yesBT.Click += new System.EventHandler(this.yesBT_Click);
            // 
            // noBT
            // 
            this.noBT.BackColor = System.Drawing.Color.Red;
            this.noBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.noBT.Location = new System.Drawing.Point(466, 463);
            this.noBT.Name = "noBT";
            this.noBT.Size = new System.Drawing.Size(363, 81);
            this.noBT.TabIndex = 3;
            this.noBT.Text = "NO";
            this.noBT.UseVisualStyleBackColor = false;
            this.noBT.Click += new System.EventHandler(this.noBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 568);
            this.Controls.Add(this.noBT);
            this.Controls.Add(this.yesBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Waldo Detector";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesBT;
        private System.Windows.Forms.Button noBT;
    }
}

