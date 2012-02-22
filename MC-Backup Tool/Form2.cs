using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MC_Backup_Tool
{
    public partial class showlog : Form
    {
        Log log = new Log();
        TextDatei c_textdatei = new TextDatei();

        public showlog()
        {
            InitializeComponent();
            string text = c_textdatei.ReadFile("log.txt");
            logcontent.Text = text;
        }

        private void logcontent_TextChanged(object sender, EventArgs e)
        {

        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete("log.txt");
                MessageBox.Show("Log Datei wurde gelöscht.");
                log.Write("Log Datei wurde gelöscht.");
                string text = c_textdatei.ReadFile("log.txt");
                logcontent.Text = text;
            }
            catch
            {
                MessageBox.Show("Log Datei konnte nicht gelöscht werden. Ist sie in einem anderen Programm geöffnet?");
                log.Write("Log Datei konnte nicht gelöscht werden.");
            }
        }

        private void showlog_Load(object sender, EventArgs e)
        {

        }
    }
}
