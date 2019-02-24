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

namespace Todays_Crafts.Employee
{
    public partial class FrmEmpInfo : UserControl
    {
        dbclass con = new dbclass(); // to be called in forms where you created your class create object 
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet dt;

        public FrmEmpInfo()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.conDB.Open();
            DataSet ds = new DataSet();
            adapt = new SqlDataAdapter("select * from customer_info", con.conDB);
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
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "")
            {
                cmd = new SqlCommand("insert into customer_info(first_name,last_name,contact_no,color,size,quantity,company_name,address,email,date,remarks) values(@first_name,@last_name,@contact_no,@color,@size,@quantity,@company_name,@address,@email,@date,@remarks)", con.conDB);
                con.conDB.Open();
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

        private void FrmEmpInfo_Load(object sender, EventArgs e)
        {
            label15.Text = dataGridView1.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                cmd = new SqlCommand("update customer_info set brand = @brand,serial_number = @serial_number,product_code = @product_code,description = @description,category = @category,on_stack = @on_stack,out_of_stack = @out_of_stack,unit_price = @unit_price,wholesale_price = @wholesale_price,minimum_order = @minimum_order,manufacturer = @manufacturer,supplier_address = @supplier_address,email = @email,contact_no = @contact_no,date_of_purchase = @date_of_purchase,remarks = @remarks where id=@id", con.conDB);
                con.conDB.Open();
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
                con.conDB.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.conDB.Open();
                cmd = new SqlCommand("DELETE FROM customer_info WHERE id = '" + textBox1.Text + "'", con.conDB);
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

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            searchData(search_txt.Text);
        }

        public void searchData(string valueToFind)
        {
            string searchQuery = "SELECT * FROM customer_info WHERE CONCAT(first_name,last_name) LIKE '%" + valueToFind + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(searchQuery, con.conDB);
            DataSet dt = new DataSet();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];

        }
    }
}
