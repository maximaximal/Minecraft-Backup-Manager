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

    public partial class Form1 : Form
    {

        Log log = new Log();
        file file = new file();
        Backup backup = new Backup();


        string versionid = "RELEASE:1.1.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void neu_Click(object sender, EventArgs e)
        {
            Backup_Create Backup = new Backup_Create();
            Backup.Show();

        }

        private void updater_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("http://update.srcttp.org/MC-Backup_Manager/version.txt");
            string text = Encoding.Default.GetString(data);
            if (text != versionid)
            {

                data = wc.DownloadData("http://update.srcttp.org/MC-Backup_Manager/" + text + "/info.txt");
                string msg = Encoding.Default.GetString(data);
                DialogResult result;
                result = MessageBox.Show(msg, "Update Installieren?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    log.Write("Die Installation des Updates " + text + " wurde abgebrochen.");
                }
                if (result == DialogResult.Yes)
                {
                    wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + text + "/update.exe", "update.exe");
                    wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + text + "/update.bat", "update.bat");
                    Process update = new Process();
                    update.StartInfo.FileName = "update.bat";
                    log.Write("Es wurde das empfohlene Update" + text + " installiert.");
                    update.Start();
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                log.Write("Diese Version ist die aktuelle, empfohlene Version.");
            }
        }
        public void Auswahl_Update()
        {
            try
            {
                Auswahl.Items.Clear();
                string[] Folders = System.IO.Directory.GetDirectories("Backups/");
                string[] names = System.IO.Directory.GetDirectories("Backups/");
                for (int i = 0; i < Folders.Length; i++)
                {
                    names[i] = Folders[i].Substring(8, Folders[i].Length - 8);
                    Auswahl.Items.Add(names[i]);
                }
                log.Write("Liste wurde aktualisiert.");
            }
            catch
            {
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Write("Programm gestartet!");
            log.Write("Version: " + versionid);
            updater.RunWorkerAsync();
            Auswahl_Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StreamReader mods = File.OpenText("Backups/" + Auswahl.SelectedItem + "/mods.txt");
                Mods.Text = (mods.ReadToEnd());
                mods.Close();
                StreamReader beschreibung = new
                StreamReader("Backups/" + Auswahl.SelectedItem + "/info.txt", System.Text.Encoding.UTF8, true);
                Beschreibung.Text = beschreibung.ReadToEnd();
                beschreibung.Close();
            }
            catch
            {
                log.Write("Das Backup " + Auswahl.SelectedItem + " hat ein falsches Format und/oder ist korrupt bzw der Ordner ist nicht vorhanden.");
            }
        }

        private void recover_Click(object sender, EventArgs e)
        {
            backup.Recover(Auswahl.SelectedItem + "");
            Auswahl_Update();
        }


        // http://dotnet-snippets.de/dns/alle-dateien-eines-ordners-auflisten---c-version---SID627.aspx
        public List<string> GetFileList(string Root, bool SubFolders)
        {
            List<string> FileArray = new List<string>();
            try
            {
                string[] Files = System.IO.Directory.GetFiles(Root);
                string[] Folders = System.IO.Directory.GetDirectories(Root);

                for (int i = 0; i < Files.Length; i++)
                {
                    FileArray.Add(Files[i].ToString());
                }

                if (SubFolders == true)
                {
                    for (int i = 0; i < Folders.Length; i++)
                    {
                        FileArray.AddRange(GetFileList(Folders[i], SubFolders));
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
            return FileArray;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("http://update.srcttp.org/MC-Backup_Manager/version.txt");
            string text = Encoding.Default.GetString(data);
            if (text != "RELEASE:1.0.0")
            {
                data = wc.DownloadData("http://update.srcttp.org/MC-Backup_Manager/" + text + "/info.txt");
                string msg = Encoding.Default.GetString(data);
                MessageBox.Show(msg);
                wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + text + "/update.exe", "update.exe");
                wc.DownloadFile("http://update.srcttp.org/MC-Backup_Manager/" + text + "/update.bat", "update.bat");
                Process update = new Process();
                update.StartInfo.FileName = "update.bat";
                update.Start();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            update update = new update();
            update.Show();

        }

        private void überDiesesProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dieses Programm wurde von Roland Ruckerbauer und Max Heisinger geschrieben. Es soll dazu dienen, ein schnelles und qualitiv hochwertiges Backup-Tool für Minecraft Modder bereitzustellen.");
            log.Write("About-Dialog wurde aufgerufen.");
        }

        private void derzeitigeVersionAusgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sie haben die Version " + versionid + " installiert. Wenn sie eine andere Version installieren wollen, rufen sie bitte den Versionsmanager auf.");
            log.Write("Versionsnummer wurde abgefragt. Version: " + versionid);
        }

        private void aktuellsteVersionInstallierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                updater.RunWorkerAsync();
            }
            catch
            {
                log.Write("Es konnte kein update ausgeführt werden.");
            }
        }

        private void andereVersionInstallierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update update = new update();
            update.Show();
        }

        private void listeAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auswahl_Update();
        }

        private void backupErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup_Create Backup = new Backup_Create();
            Backup.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            backup.Delete( Auswahl.SelectedItem + "" );
            Auswahl_Update();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Auswahl_Update();
        }

        private void logAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showlog showlog = new showlog();
            showlog.Show();
        }

        private void backupBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeinfo change = new changeinfo(Auswahl.SelectedItem + "");
            change.Show();
            Auswahl_Update();
        }

        private void backupAktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup.Create(Auswahl.SelectedItem + "", null, null);
        }
    }
}
