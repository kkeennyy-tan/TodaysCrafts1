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
using Todays_Crafts.Class;

namespace Todays_Crafts
{
    public partial class employeecontrol : UserControl
    {
        dbclass con = new dbclass(); // to be called in forms where you created your class create object 
        // dbclass= connection string
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet dt;

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
            con.conDB.Open();
            DataSet ds = new DataSet();
            adapt = new SqlDataAdapter("select * from employee", con.conDB);
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.conDB.Close();
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

        //Insert Record 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && dateTimePicker1.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && dateTimePicker2.Text != "" && dateTimePicker3.Text != "")
            {
                cmd = new SqlCommand("insert into employee(first_name,last_name,username,password,birthday,address,email,contact_no,gender,date_applied,date_resigned) values(@first_name,@last_name,@username,@password,@birthday,@address,@email,@contact_no,@gender,@date_applied,@date_resigned)", con.conDB);
                con.conDB.Open();
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
                con.conDB.Close();
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
                cmd = new SqlCommand("update employee set first_name=@first_name,last_name=@last_name,username=@username,password=@password,birthday=@birthday,address=@address,email=@email,contact_no=@contact_no,gender=@gender,date_applied=@date_applied,date_resigned=@date_resigned where id=@id", con.conDB);
                con.conDB.Open();
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
                con.conDB.Close();
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
                con.conDB.Open();
                cmd = new SqlCommand("DELETE FROM employee WHERE id = '" + textBox1.Text + "'", con.conDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Selected Contact Details Deleted");
                adapt = new SqlDataAdapter("SELECT * FROM employee ORDER BY id ", con.conDB);
                dt = new DataSet();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.conDB.Close();

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

        // contact no record
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

        // Search Record
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM employee WHERE CONCAT(first_name,last_name) LIKE '%" + valueToFind + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(searchQuery, con.conDB);
            DataSet dt = new DataSet();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

        }

    }
}