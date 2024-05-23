using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteka
{
    public partial class ListaRezerwacji : Form
    {
        public ListaRezerwacji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rezerwacja_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sciezka = @"E:\\Biblioteka.txt";
            StreamReader rezerwacje = new StreamReader(sciezka);
            string rezerwacjeDane = rezerwacje.ReadToEnd();
            rezerwacja.Text = rezerwacjeDane.ToString();
            /*if (rezerwacja.Text.Contains((';')))
            {
                string box = "";
                rezerwacja.Text += box + Environment.NewLine;
 
            }*/
            /*var canBreak = ";";
            if(rezerwacja.Text.Contains(canBreak))
            {
                rezerwacja.Text += "\n";
            }
            rezerwacje.Close();*/
        }
    }
}
