using System;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

class Mod
{
    Log log = new Log();
    public void Add(string source)
    {
        
    }
}

class Backup
{
    Log log = new Log();
    file file = new file();
    ///<summary>
    /// Erstellt ein Backup (Nach den übergebenen Informationen
    ///</summary>
    ///<param name="title">Titel des Backups</param>
    ///<param name="mods">Installierte Mods</param>
    ///<param name="info">Angefügte Informationen an das Backup</param>
    public void Create(string title, string mods, string info)
    {
        if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft") == true)
        {
            if (System.IO.Directory.Exists("Backups/" + title + "/") == false || mods == null || info == null)
            {
                if (mods == null || info == null)
                {
                    TextDatei c_textdatei = new TextDatei();
                    log.Write("Backup " + title + " wird erstellt... Info: \n" + info + "\n , Mods: " + mods + ".");
                    Directory.Delete("Backups/" + title + "/.minecraft/", true);
                    file.CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft", "Backups/" + title + "/.minecraft/");
                    log.Write("Backup \"" + title + "\" wurde erfolgreich aktualisiert!");
                    MessageBox.Show("Backup \"" + title + "\" wurde erfolgreich aktualisiert!");
                }
                else
                {
                    TextDatei c_textdatei = new TextDatei();
                    log.Write("Backup " + title + " wird erstellt... Info: \n" + info + "\n , Mods: " + mods + ".");
                    file.CopyDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft", "Backups/" + title + "/.minecraft/");
                    c_textdatei.WriteFile("Backups/" + title + "/info.txt", info);      //Info.txt schreiben
                    c_textdatei.WriteFile("Backups/" + title + "/mods.txt", mods);      //Mods.txt schreiben
                    log.Write("Backup \"" + title + "\" wurde erfolgreich erstellt!");
                    MessageBox.Show("Backup \"" + title + "\" wurde erfolgreich erstellt!");
                }
            }
            else
            {
                log.Write("Backup \"" + title + "\" konnte nicht erstellt werden (Backup bereits vorhanden!");
                MessageBox.Show("Backup \"" + title + "\" konnte nicht erstellt werden (Backup bereits vorhanden!");
            }
        }
        else
        {
            log.Write("Backup \"" + title + "\" konnte nicht erstellt werden (.minecraft Ordner nicht vorhanden!");
            MessageBox.Show("Backup \"" + title + "\" konnte nicht erstellt werden (.minecraft Ordner nicht vorhanden!");
        }
    }
    ///<summary>
    /// Ändert die Backup-Information
    ///</summary>
    ///<param name="title">(Alter) Titel des Backups</param>
    ///<param name="newtitle">Neuer Titel des Backups</param>
    ///<param name="newinfo">Neue Info des Backups</param>
    ///<param name="newmods">Neue Mods-Info des Backups</param>
    public void Change(string title, string newtitle, string newinfo, string newmods)
    {
        if (System.IO.Directory.Exists("Backups/" + title + "/") == true)
        {
            TextDatei c_textdatei = new TextDatei();
            log.Write("Backup \"" + title + "\" wurde in \"" + newtitle + "\" umbenannt.");
            c_textdatei.WriteFile("Backups/" + title + "/info.txt", newinfo);      //Info.txt schreiben
            c_textdatei.WriteFile("Backups/" + title + "/mods.txt", newmods);      //Mods.txt schreiben
            try
            {
                System.IO.Directory.Move("Backups/" + title + "/", "Backups/" + newtitle + "/");
            }
            catch
            {
            }
        }
        else
        {
            log.Write("Backup \"" + title + "\" konnte nicht in \"" + newtitle + "\" umbenannt werden (Backup nicht vorhanden!");
            MessageBox.Show("Backup \"" + title + "\" konnte nicht in \"" + newtitle + "\" umbenannt werden (Backup nicht vorhanden!");
        }
    }
    ///<summary>
    /// Löscht  ein Backup
    ///</summary>
    ///<param name="title">Titel des Backups</param>
    public void Delete(string title)
    {
        if (System.IO.Directory.Exists("Backups/" + title + "/") == false)
        {
            MessageBox.Show("Backup >> " + title + " << nicht vorhanden!");
        }
        else if (System.IO.Directory.Exists("Backups/" + title + "/") == true)
        {
            try
            {
                Directory.Delete("Backups/" + title + "/", true);
                MessageBox.Show("Backup >> " + title + " << erfolgreich entfernt!");
                log.Write("Backup " + title + " wurde erfolgreich entfernt.");
            }
            catch
            {
                log.Write("Beim Entfernen des Backups " + title + " ist ein Fehler aufgetreten.");
                MessageBox.Show("Beim löschen ist ein Fehler aufgetreten...");
            }
        }
    }
    ///<summary>
    /// Stellt ein Backup wieder her
    ///</summary>
    ///<param name="title">Titel des Backups</param>
    public void Recover(string title)
    {
        if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft") == true)
        {
            Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft", true);
            log.Write(".minecraft Ordner erfolgreich gelöscht");
            file.CopyDirectory("Backups/" + title + "/.minecraft/", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/");
            log.Write("Backup \"" + title + "\" wurde erfolgreich wiederhergestellt!");
            MessageBox.Show("Backup \"" + title + "\" wurde erfolgreich wiederhergestellt!");
        }
        else
        {
            file.CopyDirectory("Backups/" + title + "/.minecraft/", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/");
            log.Write("Backup \"" + title + "\" wurde erfolgreich wiederhergestellt!");
            MessageBox.Show(title + " erfolgreich wiederhergestellt!");
        }
    }
}

class Log
{
    ///<summary>
    /// Schreibt eine Meldung in das Log-File log.txt
    ///</summary>
    ///<param name="sWrite">Zu schreibender Text/Meldung</param>
    public void Write(String sWrite)
    {
        TextDatei c_textdatei = new TextDatei();
        c_textdatei.Append("log.txt", "[" + DateTime.Now.ToString("dd. MM. yyyy hh:mm:ss") + "] " + sWrite + "\n");
    }
}

class file
{
    ///<summary>
    /// Kopiert ein Verzeichnis (http://csharp-tricks.blogspot.com/2010/07/dateien-ordner-kopieren.html)
    ///</summary>
    ///<param name="sourceDirectory">Quellpfad</param>
    ///<param name="destDirectory">Zielpfad</param>
    public void CopyDirectory(string sourceDirectory, string destDirectory)
    {
        DirectoryInfo ds = new DirectoryInfo(sourceDirectory); // diese Klasse wird zum Auslesen des Verzeichnisinhaltes benötigt

        // Zielverzeichnis anlegen falls noch nicht vorhanden
        if (!Directory.Exists(destDirectory))
            Directory.CreateDirectory(destDirectory);

        // Rekursiv CoypDirectory() mit allen Unterverzeichnissen aufrufen,
        // auch im Zielordner die Verzeichnisstruktur beibehalten.
        foreach (DirectoryInfo d in ds.GetDirectories())
        {
            CopyDirectory(d.FullName, destDirectory + "\\" + d.Name);
        }

        // Alle Dateien in ds durchlaufen, GetFiles() liefert jedoch kein File - Objekt sondern ein FileInfo - Objekt zurück.
        // Dieses besitzt aber ähnliche Eigenschaften, MoveTo() und CopyTo() sind z.B. auch vorhanden.
        foreach (FileInfo f in ds.GetFiles())
        {
            f.CopyTo(destDirectory + "\\" + f.Name, true);
        }
        
    }
}

class TextDatei
{
    ///<summary>
    /// Liefert den Inhalt der Datei zurück.
    ///</summary>
    ///<param name="sFilename">Dateipfad</param>
    public string ReadFile(String sFilename)
    {
        string sContent = "";

        if (File.Exists(sFilename))
        {
            StreamReader myFile = new StreamReader(sFilename, System.Text.Encoding.Default);
            sContent = myFile.ReadToEnd();
            myFile.Close();
        }
        return sContent;
    }

    ///<summary>
    /// Schreibt den übergebenen Inhalt in eine Textdatei.
    ///</summary>
    ///<param name="sFilename">Pfad zur Datei</param>
    ///<param name="sLines">zu schreibender Text</param>
    public void WriteFile(String sFilename, String sLines)
    {
        StreamWriter myFile = new StreamWriter(sFilename);
        myFile.Write(sLines);
        myFile.Close();
    }

    ///<summary>
    /// Fügt den übergebenen Text an das Ende einer Textdatei an.
    ///</summary>
    ///<param name="sFilename">Pfad zur Datei</param>
    ///<param name="sLines">anzufügender Text</param>
    public void Append(string sFilename, string sLines)
    {
        StreamWriter myFile = new StreamWriter(sFilename, true);
        myFile.Write(sLines);
        myFile.Close();
    }

    ///<summary>
    /// Liefert den Inhalt der übergebenen Zeilennummer zurück.
    ///</summary>
    ///<param name="sFilename">Pfad zur Datei</param>
    ///<param name="iLine">Zeilennummer</param>
    public string ReadLine(String sFilename, int iLine)
    {
        string sContent = "";
        float fRow = 0;
        if (File.Exists(sFilename))
        {
            StreamReader myFile = new StreamReader(sFilename, System.Text.Encoding.Default);
            while (!myFile.EndOfStream && fRow < iLine)
            {
                fRow++;
                sContent = myFile.ReadLine();
            }
            myFile.Close();
            if (fRow < iLine)
                sContent = "";
        }
        return sContent;
    }

    /// <summary>
    /// Schreibt den übergebenen Text in eine definierte Zeile.
    ///</summary>
    ///<param name="sFilename">Pfad zur Datei</param>
    ///<param name="iLine">Zeilennummer</param>
    ///<param name="sLines">Text für die übergebene Zeile</param>
    ///<param name="bReplace">Text in dieser Zeile überschreiben (t) oder einfügen (f)</param>
    public void WriteLine(String sFilename, int iLine, string sLines, bool bReplace)
    {
        string sContent = "";
        string[] delimiterstring = { "\r\n" };

        if (File.Exists(sFilename))
        {
            StreamReader myFile = new StreamReader(sFilename, System.Text.Encoding.Default);
            sContent = myFile.ReadToEnd();
            myFile.Close();
        }

        string[] sCols = sContent.Split(delimiterstring, StringSplitOptions.None);

        if (sCols.Length >= iLine)
        {
            if (!bReplace)
                sCols[iLine - 1] = sLines + "\r\n" + sCols[iLine - 1];
            else
                sCols[iLine - 1] = sLines;

            sContent = "";
            for (int x = 0; x < sCols.Length - 1; x++)
            {
                sContent += sCols[x] + "\r\n";
            }
            sContent += sCols[sCols.Length - 1];

        }
        else
        {
            for (int x = 0; x < iLine - sCols.Length; x++)
                sContent += "\r\n";

            sContent += sLines;
        }


        StreamWriter mySaveFile = new StreamWriter(sFilename);
        mySaveFile.Write(sContent);
        mySaveFile.Close();
    }
}