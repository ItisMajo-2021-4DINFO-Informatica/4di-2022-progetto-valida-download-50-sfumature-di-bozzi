using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Diagnostics;
using PgpCore;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace _50SfumatureDiBozziConvalidaAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string basePath = @"C:\DemoFiles\";
        string nomeFile;
        string stringainiziale = "";
        string stringafinale = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            string accorciato;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                nomeFile = openFileDialog.FileName;
                accorciato = nomeFile.Replace("C:\\Users\\Utente\\Desktop\\", "..\\");
                //lblTesto.Content = accorciato;

            }
            else
            {
                //lblTesto.Content = "Riprova, nessun file è stato inserito";
            }
        }

        public string SHA256CheckSum(string nomeFile)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                using (FileStream lettore = File.OpenRead(nomeFile))
                {
                    return BitConverter.ToString(sHA256.ComputeHash(lettore));
                }
            }
        }

        private void btnCalcolaSHA_Click(object sender, RoutedEventArgs e)
        {
            string stringaSHA256 = SHA256CheckSum(nomeFile);
            stringafinale = stringaSHA256.Replace("-", "").ToLower();

            //lblTesto.Content = stringafinale;

            foto2.Visibility = Visibility.Hidden;
            foto1.Visibility = Visibility.Hidden;
            if (stringafinale != "")
            {
                using (FileStream flusso = new FileStream("openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256", FileMode.Open, FileAccess.Read))
                {
                    StreamReader lettore = new StreamReader(flusso);

                    while (!lettore.EndOfStream)
                    {
                        stringainiziale = lettore.ReadLine().Substring(0, 64);
                    }
                }
                if (stringainiziale != "")
                {
                    if (stringafinale == stringainiziale)
                    {
                        foto1.Visibility = Visibility.Visible;
                    }
                    else if (stringafinale != stringainiziale)
                    {
                        foto2.Visibility = Visibility.Visible;
                    }
                }

            }

        }
        private void btnVerifica_Click(object sender, RoutedEventArgs e)
        {
            string asc = "C:\\Users\\Utente\\Desktop\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256.asc";
            string sha = "C:\\Users\\Utente\\Desktop\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256";

            var outputStream = new StreamWriter("output.txt");
            Process process = new Process();
            process.StartInfo.FileName = "ipconfig.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.Arguments = "/k gpg --recv-keys 3DBDC284";
            //process.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;

            process.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                if (!String.IsNullOrEmpty(e.Data))
                {
                    outputStream.WriteLine(e.Data);
                }
            });

            process.Start();
            

            process.BeginOutputReadLine();

            process.WaitForExit();
            process.Close();

            outputStream.Close();
            /*ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "cmd.exe";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.Arguments = "/k gpg --recv-keys 3DBDC284";
            start.Arguments = "/k gpg --verify " + asc + " " + sha;

            using (Process pProcess = Process.Start(start))
            {
                using FileStream flusso = new FileStream("ciaociao.txt", FileMode.OpenOrCreate, FileAccess.Write)
                {
                    StreamReader reader = new StreamReader(flusso);

                    for (; ; )
                    {
                    string textLine = reader.ReadLine();

                    if (textLine == null)
                        break;

                    writer.WriteLine(textLine);
                    }
            
            }

            if (File.Exists("ciaociao.txt"))
            {
                FileInfo info = new FileInfo("ciaociao.txt");

                // if the error info is empty or just contains eof etc.

                if (info.Length < 4)
                    info.Delete();
            }*/

        }




    /*(using (StreamReader lettore = pProcess.StandardOutput)
    {
        string result = lettore.ReadToEnd();
        Frame.Content = result;
    }
    pProcess.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
    {
        Frame.Dispatcher.Invoke(() => { Frame.Content += e.Data + Environment.NewLine; });
    });

    pProcess.Start();*/





    /*ProcessStartInfo pInfo = new ProcessStartInfo("cmd.exe");
    pInfo.WorkingDirectory = @"C:\Windows\System32";

    Process p = Process.Start(pInfo);*/

    private void btnNascondi_Click(object sender, RoutedEventArgs e)
    {
        lblx1.Visibility = Visibility.Hidden;
        lblx2.Visibility = Visibility.Hidden;
        lblx4.Visibility = Visibility.Hidden;
        lblx5.Visibility = Visibility.Hidden;
        btnCopia.Visibility = Visibility.Hidden;
        btnCopia2.Visibility = Visibility.Hidden;
        btnCopia3.Visibility = Visibility.Hidden;
        btnLink.Visibility = Visibility.Hidden;
    }

    private void btnMostra_Click(object sender, RoutedEventArgs e)
    {
        lblx1.Visibility = Visibility.Visible;
        lblx2.Visibility = Visibility.Visible;
        lblx4.Visibility = Visibility.Visible;
        lblx5.Visibility = Visibility.Visible;
        btnCopia.Visibility = Visibility.Visible;
        btnCopia2.Visibility = Visibility.Visible;
        btnCopia3.Visibility = Visibility.Visible;
        btnLink.Visibility = Visibility.Visible;
    }

    private void btnCopia_Click(object sender, RoutedEventArgs e)
    {
        string xyz = "SET PATH=C:\\Program Files (x86)\\Gpg4win\\..\\GnuPG\\bin";

        if (xyz != "")
        {
            Clipboard.SetText(xyz);
            MessageBox.Show("linea di comando copiata negli appunti.");
        }
    }

    private void btnCopia2_Click(object sender, RoutedEventArgs e)
    {
        string abc = "gpg --recv-keys 3DBDC284";

        if (abc != "")
        {
            Clipboard.SetText(abc);
            MessageBox.Show("linea di comando copiata negli appunti.");
        }
    }

    private void btnLink_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btnCopia3_Click(object sender, RoutedEventArgs e)
    {
        string poi = "gpg --verify C:\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256.asc C:\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256";

        if (poi != "")
        {
            Clipboard.SetText(poi);
            MessageBox.Show("linea di comando copiata negli appunti.");
        }
    }
}
}
