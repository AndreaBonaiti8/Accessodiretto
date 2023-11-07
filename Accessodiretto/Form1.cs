using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accessodiretto
{
    public partial class Form1 : Form
    {
        int LunghezzaRecord = 64;
        string Prodottodamod = "";
        public Form1()
        {
            InitializeComponent();
        }
        public int ricercaindice(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        public int ricercaindicecancfisic(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[0] == nome)
                    {
                        sr.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        public string[] ricercaprod(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }
        public string[] ricercaproddarecu(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }
        public int ricercaindicedarecu(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.dat"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "1" && dati[0] == nome)
                    {
                        sr.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }
        public void Aggiunta_Click()
        {
            var file = new FileStream("File.dat", FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine($"{prodotto.Text};{prezzo.Text};1;0;".PadRight(LunghezzaRecord - 4) + "##");
            sw.Close();
            prodotto.Text = null;
            prezzo.Text = null;
        }
        private void Aggiungi_Click_1(object sender, EventArgs e)
        {

            if (prodotto.Text == string.Empty || prezzo.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto e il suo prezzo!", "Cella vuota");
            }
            else if (float.TryParse(prezzo.Text, out _) == false)
            {
                MessageBox.Show("Devi inserire il prezzo in valori numerici!", "Prezzo in Numero");
                prezzo.Text = string.Empty;
            }
            else
            {
                var file = new FileStream("File.dat", FileMode.Append, FileAccess.Write, FileShare.Read);
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine($"{prodotto.Text};{prezzo.Text};1;0;".PadRight(LunghezzaRecord - 4) + "##");
                sw.Close();
                prodotto.Text = null;
                prezzo.Text = null;
            }
        }
        private void reset_Click_1(object sender, EventArgs e)
        {
            var file = new FileStream("File.dat", FileMode.Truncate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(file);
            sw.Write(string.Empty);
            sw.Close();
            MessageBox.Show("File Resetato Correttamente", "Fine Operazione");
        }

        private void cancellalogic_Click(object sender, EventArgs e)
        {
            if (proddacanclogic.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto!", "Cella vuota");
            }
            else
            {
                int indice = ricercaindice(proddacanclogic.Text);
                if (indice == -1)
                {
                    MessageBox.Show("Assicurati che il prodotto esista!", "Prod. non Trovato");
                    proddacanclogic.Text = null;
                }
                else
                {
                    string[] prodotto = ricercaprod(proddacanclogic.Text);
                    string line;
                    var file = new FileStream("File.dat", FileMode.Open, FileAccess.Write);
                    BinaryWriter writer = new BinaryWriter(file);
                    file.Seek(LunghezzaRecord * indice, SeekOrigin.Begin);
                    line = $"{prodotto[0]};{prodotto[1]};{prodotto[3]};1;".PadRight(LunghezzaRecord - 4) + "##";
                    byte[] bytes = Encoding.UTF8.GetBytes(line);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Close();
                    file.Close();
                    proddacanclogic.Text = null;
                    MessageBox.Show("Cancellazone Logica Eseguita Correttamente", "Fine Operazione");
                }
            }
        }

        private void cerca_Click_1(object sender, EventArgs e)
        {
            if (proddacerc.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto!", "Cella vuota");
            }
            else
            {
                string[] nomeprod = ricercaprod(proddacerc.Text);
                if (nomeprod == null)
                {
                    MessageBox.Show("Assicurati che il prodotto esista!", "Prod. non Trovato");
                    proddacerc.Text = null;
                }
                else
                {
                    proddamod.Text = nomeprod[0];
                    prezdamod.Text = nomeprod[1];
                    Prodottodamod = proddacerc.Text;
                    proddacerc.Text = null;
                }
            }
        }

        private void modifica_Click_1(object sender, EventArgs e)
        {
            if (proddamod.Text == string.Empty || prezdamod.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto e il suo prezzo!", "Cella vuota");
            }
            else if (float.TryParse(prezdamod.Text, out _) == false)
            {
                MessageBox.Show("Devi inserire il prezzo in valori numerici!", "Prezzo in Numero");
                prezzo.Text = string.Empty;
            }
            else
            {
                int indice = ricercaindice(Prodottodamod);
                string line;
                var file = new FileStream("File.dat", FileMode.Open, FileAccess.Write);
                BinaryWriter writer = new BinaryWriter(file);
                file.Seek(LunghezzaRecord * indice, SeekOrigin.Begin);
                line = $"{proddamod.Text};{prezdamod.Text};1;0;".PadRight(LunghezzaRecord - 4) + "##";
                byte[] bytes = Encoding.UTF8.GetBytes(line);
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();
                file.Close();
                proddamod.Text = null;
                prezdamod.Text = null;
                Prodottodamod = "";
                MessageBox.Show("Modifica Eseguita Correttamente", "Fine Operazione");
            }
        }

        private void cancfisic_Click_1(object sender, EventArgs e)
        {
            if (cancfisic.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto!", "Cella vuota");
            }
            else
            {
                int indice = ricercaindicecancfisic(cancfisic.Text);
                if (indice == -1)
                {
                    MessageBox.Show("Assicurati che il prodotto esista!", "Prod. non Trovato");
                    cancfisic.Text = null;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Sei sicuro di volerlo cancellare? \n(non potra più essere recuperato!)", "Sei sicuro?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string[] line = File.ReadAllLines("File.dat");
                        for (int i = indice; i < line.Length - 1; i++)
                        {
                            line[i] = line[i + 1];
                        }

                        var file = new FileStream("File.dat", FileMode.Truncate, FileAccess.Write, FileShare.Read);
                        StreamWriter sw = new StreamWriter(file);
                        sw.Write(string.Empty);
                        sw.Close();

                        var files = new FileStream("File.dat", FileMode.Append, FileAccess.Write, FileShare.Read);
                        StreamWriter sws = new StreamWriter(files);
                        for (int i = 0; i < line.Length - 1; i++)
                        {
                            sws.WriteLine(line[i]);
                        }
                        sws.Close();
                        cancfisic.Text = null;
                        MessageBox.Show("Cancellazione Fisica Eseguita Correttamente", "Fine Operazione");
                    }
                    else
                    {
                        cancfisic.Text = null;
                    }
                }
            }
        }

        private void visualizza_Click_1(object sender, EventArgs e)
        {
            string percorsofiles = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "File.dat");
            Process.Start(percorsofiles);
        }

        private void recuperare_Click(object sender, EventArgs e)
        {
            if (proddarecu.Text == string.Empty)
            {
                MessageBox.Show("Devi prima inserire un prodotto!", "Cella vuota");
            }
            else
            {
                int indice = ricercaindicedarecu(proddarecu.Text);
                if (indice == -1)
                {
                    MessageBox.Show("Assicurati che il prodotto esista e che sia cancellato!", "Prod. non Trovato");
                    proddarecu.Text = null;
                }
                else
                {
                    string[] prodotto = ricercaproddarecu(proddarecu.Text);
                    string line;
                    var file = new FileStream("File.dat", FileMode.Open, FileAccess.Write);
                    BinaryWriter writer = new BinaryWriter(file);
                    file.Seek(LunghezzaRecord * indice, SeekOrigin.Begin);
                    line = $"{prodotto[0]};{prodotto[1]};1;0;".PadRight(LunghezzaRecord - 4) + "##";
                    byte[] bytes = Encoding.UTF8.GetBytes(line);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Close();
                    file.Close();
                    proddarecu.Text = null;
                    MessageBox.Show("Prodotto Recuperato Correttamente", "Fine Operazione");
                }
            }
        }
    }
}
