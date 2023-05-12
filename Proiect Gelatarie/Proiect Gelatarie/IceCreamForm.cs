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
    public partial class IceCreamForm : Form
    {
        SqlCommand cmd;
        SqlConnection con;

        public IceCreamForm()
        {
            InitializeComponent();
            textBoxCVC.PasswordChar = '*';
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ANGHE\ONEDRIVE\DOCUMENTS\ICECREAMFACTORY.MDF;Integrated Security=True;Connect Timeout=30");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int nrCups = 0;
        double price, hst, totalPrice;

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked == true)
            {
                ListViewItem item = new ListViewItem("Small Ice Cream");
                item.SubItems.Add("1");
                item.SubItems.Add("4.00");
                listView1.Items.Add(item);
                nrCups = 5;
            }
            else if (radioButtonRegular.Checked == true)
            {
                ListViewItem item = new ListViewItem("Regular Ice Cream");
                item.SubItems.Add("1");
                item.SubItems.Add("7.00");
                nrCups = 8;
                listView1.Items.Add(item);
            }
            else if (radioButtonMedium.Checked == true)
            {
                ListViewItem item = new ListViewItem("Regular Ice Cream");
                item.SubItems.Add("1");
                item.SubItems.Add("10.00");
                nrCups = 10;
                listView1.Items.Add(item);
            }
            else if (radioButtonLarge.Checked == true)
            {
                ListViewItem item = new ListViewItem("Large Ice Cream");
                item.SubItems.Add("1");
                item.SubItems.Add("13.00");
                nrCups = 15;
                listView1.Items.Add(item);
            }

            int cups = 0;

            ///Flavours
            if (checkBoxVanilla.Checked == true)
            {
                ListViewItem item = new ListViewItem("Vanilla");
                item.SubItems.Add(textBox1.Text);
                cups = cups + Convert.ToInt32(textBox1.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if (checkBoxChocolate.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chocolate");
                item.SubItems.Add(textBox2.Text);
                cups = cups + Convert.ToInt32(textBox2.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if (checkBoxCookie.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cookie Dough");
                item.SubItems.Add(textBox3.Text);
                cups = cups + Convert.ToInt32(textBox3.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if (checkBoxOreo.Checked == true)
            {
                ListViewItem item = new ListViewItem("Oreo Cookie");
                item.SubItems.Add(textBox4.Text);
                cups = cups + Convert.ToInt32(textBox4.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if (checkBoxPecan.Checked == true)
            {
                ListViewItem item = new ListViewItem("Butter Pecan");
                item.SubItems.Add(textBox5.Text);
                cups = cups + Convert.ToInt32(textBox5.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if (checkBoxKinder.Checked == true)
            {
                ListViewItem item = new ListViewItem("Kinder");
                item.SubItems.Add(textBox6.Text);
                cups = cups + Convert.ToInt32(textBox6.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxMint.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chocolate Mint Chip");
                item.SubItems.Add(textBox7.Text);
                cups = cups + Convert.ToInt32(textBox7.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxCream.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cream and Baileys");
                item.SubItems.Add(textBox8.Text);
                cups = cups + Convert.ToInt32(textBox8.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxCoconut.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coconut");
                item.SubItems.Add(textBox9.Text);
                cups = cups + Convert.ToInt32(textBox9.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxCherry.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cherry Vanilla");
                item.SubItems.Add(textBox10.Text);
                cups = cups + Convert.ToInt32(textBox10.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxMango.Checked == true)
            {
                ListViewItem item = new ListViewItem("Kinder");
                item.SubItems.Add(textBox11.Text);
                cups = cups + Convert.ToInt32(textBox11.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxStrawberry.Checked == true)
            {
                ListViewItem item = new ListViewItem("Strawberry");
                item.SubItems.Add(textBox12.Text);
                cups = cups + Convert.ToInt32(textBox12.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxRum.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coconut Rum");
                item.SubItems.Add(textBox13.Text);
                cups = cups + Convert.ToInt32(textBox13.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxPistachio.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pistachio");
                item.SubItems.Add(textBox14.Text);
                cups = cups + Convert.ToInt32(textBox14.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxGinger.Checked == true)
            {
                ListViewItem item = new ListViewItem("Gingerbread");
                item.SubItems.Add(textBox15.Text);
                cups = cups + Convert.ToInt32(textBox15.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }
            if(checkBoxBanana.Checked == true)
            {
                ListViewItem item = new ListViewItem("Banana chocolate chip");
                item.SubItems.Add(textBox16.Text);
                cups = cups + Convert.ToInt32(textBox16.Text);
                item.SubItems.Add("");
                listView1.Items.Add(item);
            }

            ///Toppings
            if(checkBoxHaribo.Checked == true)
            {
                ListViewItem item = new ListViewItem("Haribo Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }
            if(checkBoxSprinkles.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprinkles Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }
            if(checkBoxVanillaT.Checked == true)
            {
                ListViewItem item = new ListViewItem("Vanilla Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }
            if(checkBoxChocolateT.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chocolate Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }
            if(checkBoxOreosT.Checked == true)
            {
                ListViewItem item = new ListViewItem("Oreo Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }
            if(checkBoxKitKat.Checked == true)
            {
                ListViewItem item = new ListViewItem("Kit Kat Topping");
                item.SubItems.Add("");
                item.SubItems.Add("0.5");
                listView1.Items.Add(item);
            }

            ///Other Items
            if(checkBoxCoke.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coke");
                item.SubItems.Add("");
                item.SubItems.Add("1.45");
                listView1.Items.Add(item);
            }
            if(checkBoxDietCoke.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coke");
                item.SubItems.Add("");
                item.SubItems.Add("1.45");
                listView1.Items.Add(item);
            }
            if(checkBoxWater.Checked == true)
            {
                ListViewItem item = new ListViewItem("Water");
                item.SubItems.Add("");
                item.SubItems.Add("1.45");
                listView1.Items.Add(item);
            }
            if(checkBoxLemonade.Checked == true)
            {
                ListViewItem item = new ListViewItem("Lemonade");
                item.SubItems.Add("");
                item.SubItems.Add("3");
                listView1.Items.Add(item);
            }
            if(checkBoxCake.Checked == true)
            {
                ListViewItem item = new ListViewItem("Ice Cream Cake");
                item.SubItems.Add("");
                item.SubItems.Add("11");
                listView1.Items.Add(item);
            }
            if(checkBoxGingerbread.Checked == true)
            {
                ListViewItem item = new ListViewItem("Gingerbread 4 pcs");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);
            }

            price = hst = totalPrice = 0;

            foreach (ListViewItem item in listView1.Items)
                if(item.SubItems[2].Text != "")
                    price = price + Convert.ToDouble(item.SubItems[2].Text);

            hst = price * 0.13;
            totalPrice = price + hst;
            textBoxAmount.Text = Convert.ToString(price);
            textBoxTax.Text = Convert.ToString(hst);
            textBoxTotal.Text = Convert.ToString(totalPrice);

            if (cups > nrCups) 
            { 
                MessageBox.Show("You have to many cups! You can change the size of the ice cream or put fewer cups.");
                listView1.Items.Clear();
                return;
            }
            else if (cups < nrCups)
            {
                MessageBox.Show("You have fewer cups than the size can fit! You can change the size of the ice cream or put some more cups");
                listView1.Items.Clear();
                return;
            }
            else tabControl1.SelectedTab = tabPage2;
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("A small ice cream has 5 cups");
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("A regular ice cream has 8 cups");
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBoxAmount.Clear();
            textBoxTax.Clear();
            textBoxTotal.Clear();
        }

        void clearFirstPage()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

            checkBoxBanana.Checked = false;
            checkBoxCake.Checked = false;
            checkBoxCherry.Checked = false;
            checkBoxChocolate.Checked = false;
            checkBoxChocolateT.Checked = false;
            checkBoxCoconut.Checked = false;
            checkBoxCoke.Checked = false;
            checkBoxCookie.Checked = false;
            checkBoxCream.Checked = false;
            checkBoxDietCoke.Checked = false;
            checkBoxGinger.Checked = false;
            checkBoxGingerbread.Checked = false;
            checkBoxHaribo.Checked = false;
            checkBoxKinder.Checked = false;
            checkBoxKitKat.Checked = false;
            checkBoxLemonade.Checked = false;
            checkBoxMango.Checked = false;
            checkBoxMint.Checked = false;
            checkBoxOreo.Checked = false;
            checkBoxOreosT.Checked = false;
            checkBoxPecan.Checked = false;
            checkBoxPistachio.Checked = false;
            checkBoxRum.Checked = false;
            checkBoxSprinkles.Checked = false;
            checkBoxStrawberry.Checked = false;
            checkBoxVanilla.Checked = false;
            checkBoxVanillaT.Checked = false;
            checkBoxWater.Checked = false;

            radioButtonLarge.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonRegular.Checked = false;
            radioButtonSmall.Checked = false;
        }

        private void orderAgainButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            clearFirstPage();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            textBoxAmmount.Text = textBoxAmount.Text;
            tabControl1.SelectedTab = tabPage3;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "" || textBoxAdress.Text == "" || textBoxState.Text == "" || textBoxCity.Text == "" || textBoxContact.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill in al the information needed!");
                return;
            }

            if(comboBox1.SelectedItem == "Credit Card" || comboBox1.SelectedItem == "Debit Card" || comboBox1.SelectedItem == "Promo Card")
                if(textBoxCardNo.Text == "" || textBoxCardName.Text == "" || textBoxCVC.Text == "")
                {
                    MessageBox.Show("Please fill in al the information needed!");
                    return;
                }
                
            submitOrderButton.Enabled = true;
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at Ice Cream Factory. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

            ///Add data in the sql table
            con.Open();

            cmd = new SqlCommand("INSERT INTO IceCream(IdGuest, Name, LastName, Adress, State, City, PostalCode, Contact, Email, CardNumber, CVV, CardName) VALUES (@id, @name, @lastname, @adress, @state, @city, @postalcode, @contact, @email, @cardnumber, @cvv, @cardname)  ",  con);
            cmd.Parameters.AddWithValue("id", GuestLogin.id);
            cmd.Parameters.AddWithValue("name", textBoxName.Text);
            cmd.Parameters.AddWithValue("lastname", textBoxLastName.Text);
            cmd.Parameters.AddWithValue("adress", textBoxAdress.Text);
            cmd.Parameters.AddWithValue("state", textBoxState.Text);
            cmd.Parameters.AddWithValue("city", textBoxCity.Text);
            cmd.Parameters.AddWithValue("postalcode", textBoxPostal.Text);
            cmd.Parameters.AddWithValue("contact", Convert.ToInt32(textBoxContact.Text));
            cmd.Parameters.AddWithValue("email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("cardnumber", textBoxCardNo.Text);
            cmd.Parameters.AddWithValue("cvv", Convert.ToInt32(textBoxCVC.Text));
            cmd.Parameters.AddWithValue("cardname", textBoxCardName.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            if (dialog == DialogResult.Yes)
            {
                clearFirstPage();
                textBoxName.Clear();
                textBoxLastName.Clear();
                textBoxAdress.Clear();
                textBoxState.Clear();
                textBoxCity.Clear();
                textBoxPostal.Clear();
                textBoxContact.Clear();
                textBoxEmail.Clear();
                textBoxCardName.Clear();
                textBoxCardNo.Clear();
                textBoxCVC.Clear();
                tabControl1.SelectedTab = tabPage1;
            }
            else if (dialog == DialogResult.No)
                this.Close();
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("A medium ice cream has 10 cups");
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("A large ice cream has 14 cups");
        }
    }
}
