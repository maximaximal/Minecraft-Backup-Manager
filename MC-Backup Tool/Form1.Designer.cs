namespace MC_Backup_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Auswahl = new System.Windows.Forms.ListBox();
            this.recover = new System.Windows.Forms.Button();
            this.neu = new System.Windows.Forms.Button();
            this.updater = new System.ComponentModel.BackgroundWorker();
            this.Mods = new System.Windows.Forms.Label();
            this.Beschreibung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überDiesesProgrammToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.andereVersionInstallierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktuellsteVersionInstallierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derzeitigeVersionAusgebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.backupBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.backupAktualisierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Auswahl
            // 
            resources.ApplyResources(this.Auswahl, "Auswahl");
            this.Auswahl.FormattingEnabled = true;
            this.Auswahl.Name = "Auswahl";
            this.Auswahl.SelectedIndexChanged += new System.EventHandler(this.Auswahl_SelectedIndexChanged);
            // 
            // recover
            // 
            resources.ApplyResources(this.recover, "recover");
            this.recover.Name = "recover";
            this.recover.UseVisualStyleBackColor = true;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // neu
            // 
            resources.ApplyResources(this.neu, "neu");
            this.neu.Name = "neu";
            this.neu.UseVisualStyleBackColor = true;
            this.neu.Click += new System.EventHandler(this.neu_Click);
            // 
            // updater
            // 
            this.updater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updater_DoWork);
            // 
            // Mods
            // 
            resources.ApplyResources(this.Mods, "Mods");
            this.Mods.Name = "Mods";
            // 
            // Beschreibung
            // 
            resources.ApplyResources(this.Beschreibung, "Beschreibung");
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.versionToolStripMenuItem1,
            this.backupToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überDiesesProgrammToolStripMenuItem,
            this.logAnzeigenToolStripMenuItem});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            resources.ApplyResources(this.überToolStripMenuItem, "überToolStripMenuItem");
            // 
            // überDiesesProgrammToolStripMenuItem
            // 
            this.überDiesesProgrammToolStripMenuItem.Name = "überDiesesProgrammToolStripMenuItem";
            resources.ApplyResources(this.überDiesesProgrammToolStripMenuItem, "überDiesesProgrammToolStripMenuItem");
            this.überDiesesProgrammToolStripMenuItem.Click += new System.EventHandler(this.überDiesesProgrammToolStripMenuItem_Click);
            // 
            // logAnzeigenToolStripMenuItem
            // 
            this.logAnzeigenToolStripMenuItem.Name = "logAnzeigenToolStripMenuItem";
            resources.ApplyResources(this.logAnzeigenToolStripMenuItem, "logAnzeigenToolStripMenuItem");
            this.logAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.logAnzeigenToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem1
            // 
            this.versionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.andereVersionInstallierenToolStripMenuItem,
            this.aktuellsteVersionInstallierenToolStripMenuItem,
            this.derzeitigeVersionAusgebenToolStripMenuItem});
            this.versionToolStripMenuItem1.Name = "versionToolStripMenuItem1";
            resources.ApplyResources(this.versionToolStripMenuItem1, "versionToolStripMenuItem1");
            // 
            // andereVersionInstallierenToolStripMenuItem
            // 
            this.andereVersionInstallierenToolStripMenuItem.Name = "andereVersionInstallierenToolStripMenuItem";
            resources.ApplyResources(this.andereVersionInstallierenToolStripMenuItem, "andereVersionInstallierenToolStripMenuItem");
            this.andereVersionInstallierenToolStripMenuItem.Click += new System.EventHandler(this.andereVersionInstallierenToolStripMenuItem_Click);
            // 
            // aktuellsteVersionInstallierenToolStripMenuItem
            // 
            this.aktuellsteVersionInstallierenToolStripMenuItem.Name = "aktuellsteVersionInstallierenToolStripMenuItem";
            resources.ApplyResources(this.aktuellsteVersionInstallierenToolStripMenuItem, "aktuellsteVersionInstallierenToolStripMenuItem");
            this.aktuellsteVersionInstallierenToolStripMenuItem.Click += new System.EventHandler(this.aktuellsteVersionInstallierenToolStripMenuItem_Click);
            // 
            // derzeitigeVersionAusgebenToolStripMenuItem
            // 
            this.derzeitigeVersionAusgebenToolStripMenuItem.Name = "derzeitigeVersionAusgebenToolStripMenuItem";
            resources.ApplyResources(this.derzeitigeVersionAusgebenToolStripMenuItem, "derzeitigeVersionAusgebenToolStripMenuItem");
            this.derzeitigeVersionAusgebenToolStripMenuItem.Click += new System.EventHandler(this.derzeitigeVersionAusgebenToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupErstellenToolStripMenuItem,
            this.listeAktualisierenToolStripMenuItem,
            this.delete,
            this.backupBearbeitenToolStripMenuItem,
            this.backupAktualisierenToolStripMenuItem});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            resources.ApplyResources(this.backupToolStripMenuItem, "backupToolStripMenuItem");
            // 
            // backupErstellenToolStripMenuItem
            // 
            this.backupErstellenToolStripMenuItem.Name = "backupErstellenToolStripMenuItem";
            resources.ApplyResources(this.backupErstellenToolStripMenuItem, "backupErstellenToolStripMenuItem");
            this.backupErstellenToolStripMenuItem.Click += new System.EventHandler(this.backupErstellenToolStripMenuItem_Click);
            // 
            // listeAktualisierenToolStripMenuItem
            // 
            this.listeAktualisierenToolStripMenuItem.Name = "listeAktualisierenToolStripMenuItem";
            resources.ApplyResources(this.listeAktualisierenToolStripMenuItem, "listeAktualisierenToolStripMenuItem");
            this.listeAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.listeAktualisierenToolStripMenuItem_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            resources.ApplyResources(this.delete, "delete");
            this.delete.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // backupBearbeitenToolStripMenuItem
            // 
            this.backupBearbeitenToolStripMenuItem.Name = "backupBearbeitenToolStripMenuItem";
            resources.ApplyResources(this.backupBearbeitenToolStripMenuItem, "backupBearbeitenToolStripMenuItem");
            this.backupBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.backupBearbeitenToolStripMenuItem_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backupAktualisierenToolStripMenuItem
            // 
            this.backupAktualisierenToolStripMenuItem.Name = "backupAktualisierenToolStripMenuItem";
            resources.ApplyResources(this.backupAktualisierenToolStripMenuItem, "backupAktualisierenToolStripMenuItem");
            this.backupAktualisierenToolStripMenuItem.Click += new System.EventHandler(this.backupAktualisierenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Beschreibung);
            this.Controls.Add(this.Mods);
            this.Controls.Add(this.neu);
            this.Controls.Add(this.recover);
            this.Controls.Add(this.Auswahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Auswahl;
        private System.Windows.Forms.Button recover;
        private System.Windows.Forms.Button neu;
        private System.ComponentModel.BackgroundWorker updater;
        private System.Windows.Forms.Label Mods;
        private System.Windows.Forms.RichTextBox Beschreibung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überDiesesProgrammToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem andereVersionInstallierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktuellsteVersionInstallierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derzeitigeVersionAusgebenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeAktualisierenToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem logAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupAktualisierenToolStripMenuItem;
    }
}

