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
        string nomeFile;
        string NomeFile;
        string stringainiziale = "";
        string stringafinale = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCercaFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                nomeFile = openFileDialog.FileName;
                foto5.Visibility = Visibility.Visible;
                foto6.Visibility = Visibility.Hidden;
            }
            else
            {
                foto6.Visibility = Visibility.Visible;
                foto5.Visibility = Visibility.Hidden;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                NomeFile = openFileDialog.FileName.Replace("C:\\Users\\Utente\\Desktop\\","");
            }

            string stringaSHA256 = SHA256CheckSum(nomeFile);
            stringafinale = stringaSHA256.Replace("-", "").ToLower();

            foto4.Visibility = Visibility.Hidden;
            foto3.Visibility = Visibility.Hidden;
            if (stringafinale != "")
            {
                using (FileStream flusso = new FileStream(NomeFile, FileMode.Open, FileAccess.Read))
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
                        foto3.Visibility = Visibility.Visible;
                    }
                    else if (stringafinale != stringainiziale)
                    {
                        foto4.Visibility = Visibility.Visible;
                    }
                }

            }

        }
        private void btnVerifica_Click(object sender, RoutedEventArgs e)
        {
            string asc = "C:\\Users\\Utente\\Desktop\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256.asc";
            string sha = "C:\\Users\\Utente\\Desktop\\openSUSE-Leap-15.3-3-NET-x86_64-Build38.1-Media.iso.sha256";

            using (Process start = new Process())
            {
                start.StartInfo.FileName = "cmd.exe";
                start.StartInfo.UseShellExecute = false;
                start.StartInfo.RedirectStandardOutput = true;
                start.StartInfo.Arguments = "/k gpg --recv-keys 3DBDC284";
                start.StartInfo.CreateNoWindow = true;
                //start.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;

                start.Start();
                start.WaitForExit(1000);

                using (Process start1 = new Process())
                {
                    start1.StartInfo.FileName = "cmd.exe";
                    start1.StartInfo.UseShellExecute = false;
                    start1.StartInfo.RedirectStandardOutput = true;
                    //start1.StartInfo.Arguments = "/k gpg --recv-keys 3DBDC284";
                    start1.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;

                    start1.Start();
                    start1.WaitForExit();
                }

                btnCalcolaSHA.Visibility = Visibility.Hidden;
                btnCercaFile.Visibility = Visibility.Hidden;
                btnVerifica.Visibility = Visibility.Hidden;
                ciao.Visibility = Visibility.Hidden;
                ciao1.Visibility = Visibility.Hidden;
                ciao2.Visibility = Visibility.Hidden;
                label2.Visibility = Visibility.Hidden;
                label3.Visibility = Visibility.Hidden;
                label4.Visibility = Visibility.Hidden;
                linea1.Visibility = Visibility.Hidden;
                linea3.Visibility = Visibility.Hidden;
                linea5.Visibility = Visibility.Hidden;

                lblFinale.Visibility = Visibility.Visible;
                rbtnNO.Visibility = Visibility.Visible;
                rbtnSI.Visibility = Visibility.Visible;
                rect1.Visibility = Visibility.Visible;
                ciao5.Visibility = Visibility.Visible;
                btnExtra.Visibility = Visibility.Visible;
                label6.Visibility = Visibility.Visible;
                Linea.Visibility = Visibility.Visible;
            }

        }





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
            Process Chrome = new Process();
            Chrome.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            Chrome.StartInfo.Arguments = "https://www.gpg4win.org/thanks-for-download.html"; // If you have any arguments
            Chrome.Start();
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

        private void rbtnSI_Click(object sender, RoutedEventArgs e)
        {
            foto1.Visibility = Visibility.Visible;
            foto2.Visibility = Visibility.Hidden;
        }

        private void rbtnNO_Click(object sender, RoutedEventArgs e)
        {
            foto2.Visibility = Visibility.Visible;
            foto1.Visibility = Visibility.Hidden;
        }

        private void btnExtra_Click(object sender, RoutedEventArgs e)
        {
            btnNascondi.Visibility = Visibility.Visible;
            btnMostra.Visibility = Visibility.Visible;
        }

    }
}
