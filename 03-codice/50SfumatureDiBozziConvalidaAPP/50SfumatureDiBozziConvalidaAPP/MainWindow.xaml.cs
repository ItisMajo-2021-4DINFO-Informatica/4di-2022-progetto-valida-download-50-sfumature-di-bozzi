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

namespace _50SfumatureDiBozziConvalidaAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        private void btnVerificaPGP_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo("cmd.exe");
            pInfo.WorkingDirectory = @"C:\Windows\system32";
            
            Process p = Process.Start(pInfo);
        }

        private void btnNascondi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCopia_Click(object sender, RoutedEventArgs e)
        {
            string abc = "gpg --recv-keys 3DBDC284";

            if(abc != "")
            {
                Clipboard.SetText(abc);
                MessageBox.Show("linea di comando copiata negli appunti.");
            }
        }
        /* var name = "PATH";
var scope = EnvironmentVariableTarget.Machine; // or User
var oldValue = Environment.GetEnvironmentVariable(name, scope);
var newValue  = oldValue + @";C:\Program Files\MySQL\MySQL Server 5.1\bin\\";
Environment.SetEnvironmentVariable(name, newValue, scope); */
    }
}