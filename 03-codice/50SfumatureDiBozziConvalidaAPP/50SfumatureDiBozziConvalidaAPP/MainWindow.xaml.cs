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
        string stringafinale;
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
                    lblNomeFile.Content = nomeFile;
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

            private void btnCalcolaCheckSum_Click(object sender, RoutedEventArgs e)
            {
                string stringaSHA256 = SHA256CheckSum(nomeFile);
                string stringafinale = stringaSHA256.Replace("-", "");
            string stringainiziale = "f83be101c5e9c23740d6fde55fd8fefebf4fafb7badcb3756d1f574b5ad37507";
            lblTesto3.Content = stringafinale;
            if (stringafinale == stringainiziale)
            {
                lblTesto4.Content = "Stringa Checksum SHA256 CONVALIDATA!";
            }
        }
    }
}