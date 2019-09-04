namespace LBAAutoSplitter
{
    partial class FrmOptions
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
            this.lblLBADir = new System.Windows.Forms.Label();
            this.txtLBADir = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblScanInt = new System.Windows.Forms.Label();
            this.txtScanInterval = new System.Windows.Forms.TextBox();
            this.chkDeleteSaves = new System.Windows.Forms.CheckBox();
            this.lblDeleteSaves = new System.Windows.Forms.Label();
            this.chkAutoSaveSplits = new System.Windows.Forms.CheckBox();
            this.lblAutoSaveSplits = new System.Windows.Forms.Label();
            this.lblShowSubArea = new System.Windows.Forms.Label();
            this.chkShowSubArea = new System.Windows.Forms.CheckBox();
            this.lblShowMessageBoxOnRunEnd = new System.Windows.Forms.Label();
            this.chkShowMessageBoxOnRunEnd = new System.Windows.Forms.CheckBox();
            this.lblPrecisionDigits = new System.Windows.Forms.Label();
            this.txtPrecisionDigits = new System.Windows.Forms.TextBox();
            this.lblStoreColumnWidth = new System.Windows.Forms.Label();
            this.rbSave = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.lblAlwaysOnTop = new System.Windows.Forms.Label();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.chkDisableAutoZoom = new System.Windows.Forms.CheckBox();
            this.lblDisableAutoZoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLBADir
            // 
            this.lblLBADir.AutoSize = true;
            this.lblLBADir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBADir.Location = new System.Drawing.Point(12, 19);
            this.lblLBADir.Name = "lblLBADir";
            this.lblLBADir.Size = new System.Drawing.Size(88, 13);
            this.lblLBADir.TabIndex = 24;
            this.lblLBADir.Text = "LBA Install Dir";
            // 
            // txtLBADir
            // 
            this.txtLBADir.Location = new System.Drawing.Point(174, 16);
            this.txtLBADir.Name = "txtLBADir";
            this.txtLBADir.Size = new System.Drawing.Size(200, 20);
            this.txtLBADir.TabIndex = 23;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(380, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(58, 20);
            this.btnOpen.TabIndex = 22;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblScanInt
            // 
            this.lblScanInt.AutoSize = true;
            this.lblScanInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanInt.Location = new System.Drawing.Point(12, 49);
            this.lblScanInt.Name = "lblScanInt";
            this.lblScanInt.Size = new System.Drawing.Size(124, 13);
            this.lblScanInt.TabIndex = 27;
            this.lblScanInt.Text = "Refresh interval (ms)";
            // 
            // txtScanInterval
            // 
            this.txtScanInterval.Location = new System.Drawing.Point(174, 46);
            this.txtScanInterval.Name = "txtScanInterval";
            this.txtScanInterval.Size = new System.Drawing.Size(45, 20);
            this.txtScanInterval.TabIndex = 28;
            this.txtScanInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkDeleteSaves
            // 
            this.chkDeleteSaves.AutoSize = true;
            this.chkDeleteSaves.Location = new System.Drawing.Point(174, 74);
            this.chkDeleteSaves.Name = "chkDeleteSaves";
            this.chkDeleteSaves.Size = new System.Drawing.Size(15, 14);
            this.chkDeleteSaves.TabIndex = 29;
            this.chkDeleteSaves.UseVisualStyleBackColor = true;
            this.chkDeleteSaves.Click += new System.EventHandler(this.ChkDeleteSaves_Click);
            // 
            // lblDeleteSaves
            // 
            this.lblDeleteSaves.AutoSize = true;
            this.lblDeleteSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSaves.Location = new System.Drawing.Point(12, 75);
            this.lblDeleteSaves.Name = "lblDeleteSaves";
            this.lblDeleteSaves.Size = new System.Drawing.Size(158, 13);
            this.lblDeleteSaves.TabIndex = 30;
            this.lblDeleteSaves.Text = "Delete ALL Saves on Start";
            // 
            // chkAutoSaveSplits
            // 
            this.chkAutoSaveSplits.AutoSize = true;
            this.chkAutoSaveSplits.Location = new System.Drawing.Point(174, 97);
            this.chkAutoSaveSplits.Name = "chkAutoSaveSplits";
            this.chkAutoSaveSplits.Size = new System.Drawing.Size(15, 14);
            this.chkAutoSaveSplits.TabIndex = 31;
            this.chkAutoSaveSplits.UseVisualStyleBackColor = true;
            // 
            // lblAutoSaveSplits
            // 
            this.lblAutoSaveSplits.AutoSize = true;
            this.lblAutoSaveSplits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoSaveSplits.Location = new System.Drawing.Point(12, 98);
            this.lblAutoSaveSplits.Name = "lblAutoSaveSplits";
            this.lblAutoSaveSplits.Size = new System.Drawing.Size(95, 13);
            this.lblAutoSaveSplits.TabIndex = 32;
            this.lblAutoSaveSplits.Text = "AutoSave splits";
            // 
            // lblShowSubArea
            // 
            this.lblShowSubArea.AutoSize = true;
            this.lblShowSubArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowSubArea.Location = new System.Drawing.Point(241, 75);
            this.lblShowSubArea.Name = "lblShowSubArea";
            this.lblShowSubArea.Size = new System.Drawing.Size(91, 13);
            this.lblShowSubArea.TabIndex = 33;
            this.lblShowSubArea.Text = "Show sub area";
            // 
            // chkShowSubArea
            // 
            this.chkShowSubArea.AutoSize = true;
            this.chkShowSubArea.Location = new System.Drawing.Point(403, 75);
            this.chkShowSubArea.Name = "chkShowSubArea";
            this.chkShowSubArea.Size = new System.Drawing.Size(15, 14);
            this.chkShowSubArea.TabIndex = 34;
            this.chkShowSubArea.UseVisualStyleBackColor = true;
            // 
            // lblShowMessageBoxOnRunEnd
            // 
            this.lblShowMessageBoxOnRunEnd.AutoSize = true;
            this.lblShowMessageBoxOnRunEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowMessageBoxOnRunEnd.Location = new System.Drawing.Point(241, 99);
            this.lblShowMessageBoxOnRunEnd.Name = "lblShowMessageBoxOnRunEnd";
            this.lblShowMessageBoxOnRunEnd.Size = new System.Drawing.Size(130, 13);
            this.lblShowMessageBoxOnRunEnd.TabIndex = 35;
            this.lblShowMessageBoxOnRunEnd.Text = "Show Congratulations";
            // 
            // chkShowMessageBoxOnRunEnd
            // 
            this.chkShowMessageBoxOnRunEnd.AutoSize = true;
            this.chkShowMessageBoxOnRunEnd.Location = new System.Drawing.Point(403, 98);
            this.chkShowMessageBoxOnRunEnd.Name = "chkShowMessageBoxOnRunEnd";
            this.chkShowMessageBoxOnRunEnd.Size = new System.Drawing.Size(15, 14);
            this.chkShowMessageBoxOnRunEnd.TabIndex = 36;
            this.chkShowMessageBoxOnRunEnd.UseVisualStyleBackColor = true;
            // 
            // lblPrecisionDigits
            // 
            this.lblPrecisionDigits.AutoSize = true;
            this.lblPrecisionDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecisionDigits.Location = new System.Drawing.Point(241, 49);
            this.lblPrecisionDigits.Name = "lblPrecisionDigits";
            this.lblPrecisionDigits.Size = new System.Drawing.Size(90, 13);
            this.lblPrecisionDigits.TabIndex = 37;
            this.lblPrecisionDigits.Text = "Time Precision";
            // 
            // txtPrecisionDigits
            // 
            this.txtPrecisionDigits.Location = new System.Drawing.Point(400, 46);
            this.txtPrecisionDigits.Name = "txtPrecisionDigits";
            this.txtPrecisionDigits.Size = new System.Drawing.Size(38, 20);
            this.txtPrecisionDigits.TabIndex = 38;
            this.txtPrecisionDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStoreColumnWidth
            // 
            this.lblStoreColumnWidth.AutoSize = true;
            this.lblStoreColumnWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreColumnWidth.Location = new System.Drawing.Point(12, 143);
            this.lblStoreColumnWidth.Name = "lblStoreColumnWidth";
            this.lblStoreColumnWidth.Size = new System.Drawing.Size(85, 13);
            this.lblStoreColumnWidth.TabIndex = 39;
            this.lblStoreColumnWidth.Text = "Column Width";
            // 
            // rbSave
            // 
            this.rbSave.AutoSize = true;
            this.rbSave.Location = new System.Drawing.Point(174, 139);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(50, 17);
            this.rbSave.TabIndex = 40;
            this.rbSave.TabStop = true;
            this.rbSave.Text = "Save";
            this.rbSave.UseVisualStyleBackColor = true;
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(244, 139);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(59, 17);
            this.rbDefault.TabIndex = 41;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default";
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // lblAlwaysOnTop
            // 
            this.lblAlwaysOnTop.AutoSize = true;
            this.lblAlwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlwaysOnTop.Location = new System.Drawing.Point(12, 121);
            this.lblAlwaysOnTop.Name = "lblAlwaysOnTop";
            this.lblAlwaysOnTop.Size = new System.Drawing.Size(111, 13);
            this.lblAlwaysOnTop.TabIndex = 42;
            this.lblAlwaysOnTop.Text = "Keep Splits on top";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(174, 120);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(15, 14);
            this.chkAlwaysOnTop.TabIndex = 43;
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // chkDisableAutoZoom
            // 
            this.chkDisableAutoZoom.AutoSize = true;
            this.chkDisableAutoZoom.Location = new System.Drawing.Point(403, 121);
            this.chkDisableAutoZoom.Name = "chkDisableAutoZoom";
            this.chkDisableAutoZoom.Size = new System.Drawing.Size(15, 14);
            this.chkDisableAutoZoom.TabIndex = 44;
            this.chkDisableAutoZoom.UseVisualStyleBackColor = true;
            // 
            // lblDisableAutoZoom
            // 
            this.lblDisableAutoZoom.AutoSize = true;
            this.lblDisableAutoZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableAutoZoom.Location = new System.Drawing.Point(241, 121);
            this.lblDisableAutoZoom.Name = "lblDisableAutoZoom";
            this.lblDisableAutoZoom.Size = new System.Drawing.Size(112, 13);
            this.lblDisableAutoZoom.TabIndex = 45;
            this.lblDisableAutoZoom.Text = "Disable Auto-zoom";
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(468, 234);
            this.ControlBox = false;
            this.Controls.Add(this.lblDisableAutoZoom);
            this.Controls.Add(this.chkDisableAutoZoom);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.lblAlwaysOnTop);
            this.Controls.Add(this.rbDefault);
            this.Controls.Add(this.rbSave);
            this.Controls.Add(this.lblStoreColumnWidth);
            this.Controls.Add(this.txtPrecisionDigits);
            this.Controls.Add(this.lblPrecisionDigits);
            this.Controls.Add(this.chkShowMessageBoxOnRunEnd);
            this.Controls.Add(this.lblShowMessageBoxOnRunEnd);
            this.Controls.Add(this.chkShowSubArea);
            this.Controls.Add(this.lblShowSubArea);
            this.Controls.Add(this.lblAutoSaveSplits);
            this.Controls.Add(this.chkAutoSaveSplits);
            this.Controls.Add(this.lblDeleteSaves);
            this.Controls.Add(this.chkDeleteSaves);
            this.Controls.Add(this.txtScanInterval);
            this.Controls.Add(this.lblScanInt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLBADir);
            this.Controls.Add(this.txtLBADir);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLBADir;
        private System.Windows.Forms.TextBox txtLBADir;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblScanInt;
        private System.Windows.Forms.TextBox txtScanInterval;
        private System.Windows.Forms.CheckBox chkDeleteSaves;
        private System.Windows.Forms.Label lblDeleteSaves;
        private System.Windows.Forms.CheckBox chkAutoSaveSplits;
        private System.Windows.Forms.Label lblAutoSaveSplits;
        private System.Windows.Forms.Label lblShowSubArea;
        private System.Windows.Forms.CheckBox chkShowSubArea;
        private System.Windows.Forms.Label lblShowMessageBoxOnRunEnd;
        private System.Windows.Forms.CheckBox chkShowMessageBoxOnRunEnd;
        private System.Windows.Forms.Label lblPrecisionDigits;
        private System.Windows.Forms.TextBox txtPrecisionDigits;
        private System.Windows.Forms.Label lblStoreColumnWidth;
        private System.Windows.Forms.RadioButton rbSave;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.Label lblAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkDisableAutoZoom;
        private System.Windows.Forms.Label lblDisableAutoZoom;
    }
}