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
                lblTesto.Content = accorciato;
                MessageBox.Show("File inserito con successo!");

            }
            else
            {
                MessageBox.Show("Riprova, nessun file è stato inserito");
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
            stringafinale = stringaSHA256.Replace("-", "");

            lblTesto.Content = stringafinale;

            if (stringafinale != "")
            {
                using (FileStream flusso = new FileStream("", FileMode.Open, FileAccess.Read))
                {
                    StreamReader lettore = new StreamReader(flusso);

                    while (!lettore.EndOfStream)
                    {
                        stringainiziale = lettore.ReadLine();
                    }
                }
                if (stringainiziale != "")
                {
                    if (stringafinale == stringainiziale)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Non è stato possibile leggere una checksum SHA256");
                }
            }
        }

        private void btnVerificaPGP_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}