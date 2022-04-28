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
        }
        static async Task<string> Verifica(string publicKeyFilename, string signedFilename)
        {
            FileInfo publicKey = new FileInfo(basePath + publicKeyFilename);
            EncryptionKeys encryptionKeys = new EncryptionKeys(publicKey);

            FileInfo inputFile = new FileInfo(basePath + signedFilename);

            PGP pgp = new PGP(encryptionKeys);
            bool verified = await pgp.VerifyFileAsync(inputFile);

            if (verified)
            {
                return "The content is signed with the given public key";
            }
            else
            {
                return "WARNING The content is NOT signed with the given public key";
            }
        }

        /*public class iTransactVerifier
        {
            private const string PublicKey = @"-----BEGIN PGP PUBLIC KEY BLOCK-----
Version: 4.5

mQCNAjZu
-----END PGP PUBLIC KEY BLOCK-----";

            public static bool Verify(string signature, string data)
            {
                var inputStream = ASCIIEncoding.ASCII.GetBytes(signature);

                PgpPublicKey publicKey = ReadPublicKeyFromString();
                var stream = PgpUtilities.GetDecoderStream(inputStream);

                PgpObjectFactory pgpFact = new PgpObjectFactory(stream);

                PgpSignatureList sList = pgpFact.NextPgpObject() as PgpSignatureList;
                if (sList == null)
                {
                    throw new InvalidOperationException("PgpObjectFactory could not create signature list");
                }
                PgpSignature firstSig = sList[0];

                firstSig.InitVerify(publicKey);
                firstSig.Update(Encoding.UTF8.GetBytes(data));

                var verified = firstSig.Verify();
                return verified;
            }

    private static PgpPublicKey ReadPublicKeyFromString()
            {
                var varstream = ASCIIEncoding.ASCII.GetBytes(PublicKey);
                var stream = PgpUtilities.GetDecoderStream(varstream);

                PgpObjectFactory pgpFact = new PgpObjectFactory(stream);
                var keyRing = (PgpPublicKeyRing)pgpFact.NextPgpObject();
                return keyRing.GetPublicKey();
            }
        }*

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