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
    public partial class EmployeeForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public EmployeeForm()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ANGHE\ONEDRIVE\DOCUMENTS\ICECREAMFACTORY.MDF;Integrated Security=True;Connect Timeout=30");
        }

        private void displayParentsButton_Click(object sender, EventArgs e)
        {
            con.Open();

            parentDataView.Visible = true;
            cmd = new SqlCommand("SELECT * FROM employees", con);

            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "employees");

            parentDataView.DataSource = ds.Tables["employees"];
            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
            addButtonColumn.Name = "addColumn";

            addButtonColumn.HeaderText = "add new child";
            parentDataView.Columns.Insert(ds.Tables["employees"].Columns.Count, addButtonColumn);
            foreach (DataGridViewRow row in parentDataView.Rows)
            {
                row.Cells["addColumn"].Value = "add new programee";
            }

            con.Close();
        }

        private void parentDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            if (e.ColumnIndex == 3)
            {
                addChildBox.Visible = true;
                addId.Text = "";
                addName.Text = "";
               /// MessageBox.Show(parentDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
                addChildBox.Text = "Add a new child for the prg id = " + parentDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            con.Close();
        }

        private void childDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show(e.RowIndex.ToString());
                string id = childDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id.ToString());
                string querry = "DELETE FROM programee WHERE programeeID = " + id;

                cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();
                childDataView.Update();
                childDataView.Refresh();
            }
            else if (e.ColumnIndex == 4)
            {
                updateChildBox.Visible = true;
                updateChildBox.Text = "Update child with id = " + childDataView.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ///MessageBox.Show("clickedadd");
            con.Open();
            string id = addChildBox.Text.Substring(33);
            ///MessageBox.Show(id);
            String querry = "INSERT INTO programee(programeeID,employeeID,duration) VALUES (" + Int32.Parse(addId.Text) + "," + id + "," + Int32.Parse(addName.Text) + ")";
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            addChildBox.Visible = false;
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = updateChildBox.Text.Substring(23);
            Console.WriteLine(id);
            String querry = "UPDATE programee SET duration = " + updateName.Text + "WHERE programeeID = " + id;
            cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            childDataView.Update();
            childDataView.Refresh();
            updateChildBox.Visible = false;
            con.Close();
        }

        private void displayChildrenButton_Click(object sender, EventArgs e)
        {
            con.Open();
            childDataView.Refresh();
            childDataView.Columns.Clear();
            childDataView.DataSource = null;
            childDataView.Visible = true;
            if (parentDataView.SelectedRows.Count == 1)
            {
                int selectedRow = parentDataView.CurrentCell.RowIndex;
                DataGridViewRow row = parentDataView.Rows[selectedRow];
                string selectedId = Convert.ToString(row.Cells["employeeID"].Value);
                String querry = "SELECT * FROM programee WHERE employeeID = " + selectedId;
                cmd = new SqlCommand(querry, con);

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "programee");

                childDataView.DataSource = ds.Tables["programee"];

                DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                removeButtonColumn.Name = "removeColumn";

                removeButtonColumn.HeaderText = "remove programee";
                childDataView.Columns.Insert(ds.Tables["programee"].Columns.Count, removeButtonColumn);

                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
                updateButtonColumn.Name = "updateColumn";

                updateButtonColumn.HeaderText = "update programee";
                childDataView.Columns.Insert(ds.Tables["programee"].Columns.Count + 1, updateButtonColumn);

                foreach (DataGridViewRow r in childDataView.Rows)
                {
                    r.Cells["updateColumn"].Value = "update programee";
                    r.Cells["removeColumn"].Value = "remove programee";
                }
            }
            con.Close();
        }
    }
}

