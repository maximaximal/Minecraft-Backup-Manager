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
    public partial class Backup_Create : Form
    {
        Log log = new Log();
        Backup backup = new Backup();

        public Backup_Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backup.Create(backup_name.Text, backup_mods.Text, backup_info.Text);
            this.Close();
        }

    }
}
