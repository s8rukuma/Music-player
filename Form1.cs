using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] Mp3files, Mp3path;        

        private void btn_choosemp3files_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Mp3files = openFileDialog1.SafeFileNames;
                Mp3path = openFileDialog1.FileNames;
                for (int i = 0; i < Mp3files.Length;i++)
                {
                    listBoxMp3Files.Items.Add(Mp3files[i]);                    
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            listBoxMp3Files.Items.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            listBoxMp3Files.Items.Remove(listBoxMp3Files.Items[listBoxMp3Files.SelectedIndex]);
        }

        private void listBoxMp3Files_DoubleClick(object sender, EventArgs e)
        {
            WMP.URL = Mp3path[listBoxMp3Files.SelectedIndex];
        }
    }
}
