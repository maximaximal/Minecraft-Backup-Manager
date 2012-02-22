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
    public partial class changeinfo : Form
    {
        Log log = new Log();
        Backup backup = new Backup();
        TextDatei c_textdatei = new TextDatei();
        string oldtitle;
        public changeinfo(string title)
        {
            InitializeComponent();
            oldtitle = title;
            log.Write("Backup ändern wird ausgeführt...");
            newinfo.Text = c_textdatei.ReadFile("Backups/" + title + "/info.txt");
            newmods.Text = c_textdatei.ReadFile("Backups/" + title + "/mods.txt");
            newtitle.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backup.Change(oldtitle, newtitle.Text, newinfo.Text, newmods.Text);
            this.Close();
        }
    }
}
