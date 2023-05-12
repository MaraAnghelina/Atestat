using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_Gelatarie
{
    public partial class GuestLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public static int id;

        public GuestLogin()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ANGHE\ONEDRIVE\DOCUMENTS\ICECREAMFACTORY.MDF;Integrated Security=True;Connect Timeout=30");
            textBoxParolaInregistrare.PasswordChar = '*';
            textBoxParolaConectare.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            string nume = textBoxNumeConectare.Text;
            string parola = textBoxParolaConectare.Text;

            cmd = new SqlCommand("SELECT Id FROM Utilizatori WHERE Nume=@Nume", con);
            cmd.Parameters.AddWithValue("Nume", nume);
            id = Convert.ToInt32(cmd.ExecuteScalar());

            if (id == 0)
            {
                MessageBox.Show("This username does not exist! Please try again or register first!"); ;
                textBoxNumeConectare.Clear();
                textBoxParolaConectare.Clear();
                con.Close();
                return;
            }

            cmd = new SqlCommand("SELECT Parola FROM Utilizatori WHERE Nume=@Nume", con);
            cmd.Parameters.AddWithValue("Nume", nume);
            string parolaBaza = Convert.ToString(cmd.ExecuteScalar());

            if (!parolaBaza.Equals(parola))
            {
                MessageBox.Show("Inccorect Password!"); ;
                textBoxNumeConectare.Clear();
                textBoxParolaConectare.Clear();
                con.Close();
                return;
            }

            MessageBox.Show("You have successfully logged in!"); ;
            textBoxNumeConectare.Clear();
            textBoxParolaConectare.Clear();

            this.Close();
            IceCreamForm f = new IceCreamForm();
            f.Show();

            con.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string nume = textBoxNumeInregistrare.Text;
            string parola = textBoxParolaInregistrare.Text;

            if (parola.Length < 8)
            {
                MessageBox.Show("The Password is to short! The Password needs to have at least 8 characters.");
                return;
            }

            con.Open();

            cmd = new SqlCommand("SELECT Id FROM Utilizatori WHERE Nume=@Nume", con);
            cmd.Parameters.AddWithValue("Nume", nume);
            id = Convert.ToInt32(cmd.ExecuteScalar());

            if (id != 0)
            {
                MessageBox.Show("This username already exists!");
                textBoxNumeInregistrare.Clear();
                textBoxParolaInregistrare.Clear();
                con.Close();
                return;
            }

            cmd = new SqlCommand("INSERT INTO Utilizatori(Nume, Parola) VALUES (@Nume, @Parola)", con);
            cmd.Parameters.AddWithValue("Nume", nume);
            cmd.Parameters.AddWithValue("Parola", parola);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Account successfully created!");
            textBoxNumeInregistrare.Clear();
            textBoxParolaInregistrare.Clear();

            con.Close();
        }
    }
}
