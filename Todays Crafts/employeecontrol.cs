using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Todays_Crafts
{
    public partial class employeecontrol : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BUHG7VK\SQLEXPRESS01;Initial Catalog=TodaysCrafts;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        //ID variable used in Updating and Deleting Record  
        int id = 0;

        public employeecontrol()
        {
            InitializeComponent();
            DisplayData();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.todaysCrafts);
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from employee", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            
        }

        //Insert Data 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && dateTimePicker2.Text != "" && dateTimePicker3.Text != "")
            {
                cmd = new SqlCommand("insert into employee(first_name,last_name,username,password,birthday,address,email,contact_no,gender,date_applied,date_resigned) values(@first_name,@last_name,@username,@password,@birthday,@address,@email,@contact_no,@gender,@date_applied,@date_resigned)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@first_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@username", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                cmd.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@address", textBox7.Text);
                cmd.Parameters.AddWithValue("@email", textBox8.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox9.Text);
                cmd.Parameters.AddWithValue("@gender", textBox10.Text);
                cmd.Parameters.AddWithValue("@date_applied", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@date_resigned", dateTimePicker3.Text); ;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Update Record 
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && dateTimePicker2.Text != "" && dateTimePicker3.Text != "")
            {
                cmd = new SqlCommand("update employee set first_name=@first_name,last_name=@last_name,username=@username,password=@password,birthday=@birthday,address=@address,email=@email,contact_no=@contact_no,gender=@gender,date_applied=@date_applied,date_resigned=@date_resigned where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@first_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@username", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                cmd.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@address", textBox7.Text);
                cmd.Parameters.AddWithValue("@email", textBox8.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox9.Text);
                cmd.Parameters.AddWithValue("@gender", textBox10.Text);
                cmd.Parameters.AddWithValue("@date_applied", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@date_resigned", dateTimePicker3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //Delete Record
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM employee WHERE id = '" + textBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Selected Contact Details Deleted");
                adapt = new SqlDataAdapter("SELECT * FROM employee ORDER BY id ", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            dateTimePicker3.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void employeecontrol_Load_1(object sender, EventArgs e)
        {
            label15.Text = dataGridView1.Rows.Count.ToString();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM employee WHERE CONCAT(first_name,last_name) LIKE '%" + valueToFind + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(searchQuery, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

    }
}