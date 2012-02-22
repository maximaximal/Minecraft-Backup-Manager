using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace MC_Backup_Tool
{
    public partial class update : Form
    {

        Log log = new Log();

        public update()
        {
            InitializeComponent();
        }

        private void update_official_search_Click(object sender, EventArgs e)
        {
            log.Write("Es wurde nach Update " + textBox1.Text + " gesucht.");
            try
            {
                WebClient wc = new WebClient();
                byte[] data;
                data = wc.DownloadData("http://update.srcttp.org/MC-Backup_Manager/" + textBox1.Text + "/info.txt");
                update_do.Enabled = true;
                string info = Encoding.Default.GetString(data);
                update_info.Text = info;

            }
            catch
            {
                MessageBox.Show("Das Update " + textBox1.Text + " konnte nicht gefunden werden!");
                update_do.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_do_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + textBox1.Text + "/update.exe", "update.exe");
            wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + textBox1.Text + "/update.bat", "update.bat");
            Process update = new Process();
            log.Write("Es wurde das Update" + textBox1.Text + " installiert.");
            update.StartInfo.FileName = "update.bat";
            update.Start();
            System.Windows.Forms.Application.Exit();
        }
    }
}
