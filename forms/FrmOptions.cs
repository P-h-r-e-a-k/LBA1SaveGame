using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBAAutoSplitter
{
    public partial class FrmOptions : Form
    {
        Options options;

        public FrmOptions()
        {
            InitializeComponent();
            options = new Options();
            LoadOptions();
        }

        private void LoadOptions()
        {
            //Load Directory
            if (0 != options.LBADir.Length)
                txtLBADir.Text = options.LBADir;
            //Load Interval
            txtScanInterval.Text = options.interval;
            txtPrecisionDigits.Text = options.precisionDigits;
            chkDisableAutoZoom.Checked = options.disableAutoZoom;
            chkDeleteSaves.Checked = options.deleteSaves;
            chkAutoSaveSplits.Checked = options.autoSaveSplits;
            chkShowSubArea.Checked = options.showSubArea;
            chkShowMessageBoxOnRunEnd.Checked = options.showMessageBoxOnRunEnd;
            chkAlwaysOnTop.Checked = options.alwaysOnTop;
            rbSave.Checked = options.saveColumnWidths;
            rbDefault.Checked = !options.saveColumnWidths;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdLBADir = new FolderBrowserDialog();
            fbdLBADir.ShowDialog();
            txtLBADir.Text = fbdLBADir.SelectedPath;
            fbdLBADir.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            options.LBADir = txtLBADir.Text;
            options.interval = txtScanInterval.Text;
            options.precisionDigits = txtPrecisionDigits.Text;
            options.disableAutoZoom = chkDisableAutoZoom.Checked;
            options.deleteSaves = chkDeleteSaves.Checked;
            options.autoSaveSplits = chkAutoSaveSplits.Checked;
            options.showSubArea = chkShowSubArea.Checked;
            options.showMessageBoxOnRunEnd = chkShowMessageBoxOnRunEnd.Checked;
            options.alwaysOnTop = chkAlwaysOnTop.Checked;
            options.saveColumnWidths = rbSave.Checked;
            options.save();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChkDeleteSaves_Click(object sender, EventArgs e)
        {
            if (chkDeleteSaves.Checked)
                MessageBox.Show("Warning, this will delete all save files in the LBA directory");
        }
    }
}
