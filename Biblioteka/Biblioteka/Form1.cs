using SqlLib;
using System.Data;

namespace Biblioteka
{
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Zasob zasob = new Zasob();
            zasob.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 regulamin = new Form2();
            regulamin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Klasa.Value > 8 || Klasa.Value <= 0)
            {
                MessageBox.Show("Niepoprawne dane klasy.", "B³¹d");
            }
            else if (Imie.Text.Length == 0 || Nazwisko.Text.Length == 0 || Nazwisko.Text.Length == 0)
            {
                MessageBox.Show("Nie wprowadzono odpowiednich danych.", "B³¹d");
            }

            else
            {
                MessageBox.Show("Proœba o rezerwacje zosta³a wys³ana.", "Rezerwacja");

                using (StreamWriter txt = new StreamWriter("E:\\Biblioteka.txt", true)) // œcie¿ka do pliku txt, mo¿na zmieniæ
                {
                    txt.Write(Imie.Text + " ");
                    txt.Write(Nazwisko.Text + " ");
                    txt.Write("kl." + Klasa.Value + " - ");
                    //txt.Write("''" + Tytul.Text + "''");
                    txt.Write(" Data rozp. rezerwacji: " + DataRezerwacji.Value.Date + "\n");
                }

                //Imie.Clear(); Nazwisko.Clear(); Klasa.Value = 0; Tytul.Clear();
            }
        }

        private void Imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lista_Click(object sender, EventArgs e)
        {
            ListaRezerwacji rezerwacje = new ListaRezerwacji();
            rezerwacje.Show();
        }

        private void ListaKsiazek_Click(object sender, EventArgs e)
        {
            CdbSQL db = new CdbSQL();
            string query = "SELECT id,tytul FROM ksiazki";
            DataTable result = db.ExecuteQuery(query);
            ListaKsiazek.DataSource = result;
            ListaKsiazek.DisplayMember = "tytul";
            ListaKsiazek.ValueMember = "id";
        }
        }
    }



