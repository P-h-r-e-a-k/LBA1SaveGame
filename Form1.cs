using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBA1SaveGame
{
    public partial class LBA1SaveGame : Form
    {

        private HotKey hotkeyF7;
        //private HotKey hotkeyF8;
        private HotKey hotkeyF9;

        public LBA1SaveGame()
        {
            InitializeComponent();
            //txtLBADir.Text = @"R:\GOG Games\Little Big Adventure_Clean";
        }

        private void BtnSetDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdLBADir = new FolderBrowserDialog();
            fbdLBADir.ShowDialog();
            txtLBADir.Text = fbdLBADir.SelectedPath;
            fbdLBADir.Dispose();
            Options opt = new Options();
            opt.LBADir = txtLBADir.Text;
            opt.save();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotkeyF7.UnRegisterHotKeys();
            //hotkeyF8.UnRegisterHotKeys();
            hotkeyF9.UnRegisterHotKeys();
        }

        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                if (118 == (int)keyPressed.WParam)
                {
                    SaveGame sg = new SaveGame();
                    sg.save(txtLBADir.Text);
                }
                /*if (119 == (int)keyPressed.WParam)
                    MessageBox.Show("F8");*/
                //Add a key
                if (120 == (int)keyPressed.WParam)
                    new mem().WriteVal(0xE26, 1);
            }
            base.WndProc(ref keyPressed);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtLBADir.Text = new Options().LBADir;
            hotkeyF7 = new HotKey(this.Handle);
            hotkeyF7.RegisterHotKeys((int)Keys.F7, (uint)Keys.F7);
            /*
            hotkeyF8 = new HotKey(this.Handle);
            hotkeyF8.RegisterHotKeys((int)Keys.F8, (uint)Keys.F8);*/
            hotkeyF9 = new HotKey(this.Handle);
            hotkeyF9.RegisterHotKeys((int)Keys.F9, (uint)Keys.F9);
        }
    }
}
