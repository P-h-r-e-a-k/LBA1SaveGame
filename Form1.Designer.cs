namespace LBA1SaveGame
{
    partial class LBA1SaveGame
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
            this.btnSetDir = new System.Windows.Forms.Button();
            this.txtLBADir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetDir
            // 
            this.btnSetDir.Location = new System.Drawing.Point(407, 10);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(75, 23);
            this.btnSetDir.TabIndex = 0;
            this.btnSetDir.Text = "Set LBA dir";
            this.btnSetDir.UseVisualStyleBackColor = true;
            this.btnSetDir.Click += new System.EventHandler(this.BtnSetDir_Click);
            // 
            // txtLBADir
            // 
            this.txtLBADir.Location = new System.Drawing.Point(35, 12);
            this.txtLBADir.Name = "txtLBADir";
            this.txtLBADir.Size = new System.Drawing.Size(353, 20);
            this.txtLBADir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Press F7 to save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press F9 if you need a key";
            // 
            // LBA1SaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 125);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLBADir);
            this.Controls.Add(this.btnSetDir);
            this.Name = "LBA1SaveGame";
            this.Text = "LBA1SaveGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetDir;
        private System.Windows.Forms.TextBox txtLBADir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

