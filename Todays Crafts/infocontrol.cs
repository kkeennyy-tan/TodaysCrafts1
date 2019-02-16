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
    public partial class infocontrol : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BUHG7VK\SQLEXPRESS01;Initial Catalog=TodaysCrafts;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        //ID variable used in Updating and Deleting Record  
        

        public infocontrol()
        {
            InitializeComponent();
            DisplayData();
        }

        private void infocontrol_Load(object sender, EventArgs e)
        {
            label15.Text = dataGridView1.Rows.Count.ToString();
        }
        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from customer_info", con);
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
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != ""  && textBox12.Text != "")
            {
                cmd = new SqlCommand("insert into customer_info(first_name,last_name,contact_no,color,size,quantity,company_name,address,email,date,remarks) values(@first_name,@last_name,@contact_no,@color,@size,@quantity,@company_name,@address,@email,@date,@remarks)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@first_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox4.Text);
                cmd.Parameters.AddWithValue("@color", textBox5.Text);
                cmd.Parameters.AddWithValue("@size", textBox6.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox7.Text);
                cmd.Parameters.AddWithValue("@company_name", textBox8.Text);
                cmd.Parameters.AddWithValue("@address", textBox9.Text);
                cmd.Parameters.AddWithValue("@email", textBox10.Text);
                cmd.Parameters.AddWithValue("@date", textBox11.Text);
                cmd.Parameters.AddWithValue("@remarks", textBox12.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" )
            {
                cmd = new SqlCommand("update customer_info set brand = @brand,serial_number = @serial_number,product_code = @product_code,description = @description,category = @category,on_stack = @on_stack,out_of_stack = @out_of_stack,unit_price = @unit_price,wholesale_price = @wholesale_price,minimum_order = @minimum_order,manufacturer = @manufacturer,supplier_address = @supplier_address,email = @email,contact_no = @contact_no,date_of_purchase = @date_of_purchase,remarks = @remarks where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@first_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox3.Text);
                cmd.Parameters.AddWithValue("@contact_no", textBox4.Text);
                cmd.Parameters.AddWithValue("@color", textBox5.Text);
                cmd.Parameters.AddWithValue("@size", textBox6.Text);
                cmd.Parameters.AddWithValue("@company_name", textBox7.Text);
                cmd.Parameters.AddWithValue("@address", textBox8.Text);
                cmd.Parameters.AddWithValue("@email", textBox9.Text);
                cmd.Parameters.AddWithValue("@date", textBox10.Text);
                cmd.Parameters.AddWithValue("@remarks", textBox11.Text);
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM customer_info WHERE id = '" + textBox1.Text + "'", con);
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }
        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM customer_info WHERE CONCAT(first_name,last_name) LIKE '%" + valueToFind + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(searchQuery, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
