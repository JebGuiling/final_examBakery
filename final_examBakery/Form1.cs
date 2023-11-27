using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace final_examBakery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();

        }
        private void BindGrid()
        {
            string constring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView1.DataSource = dt;
                    dataGridView6.DataSource = dt;


                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ingredient", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView2.DataSource = dt;

                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM equipment", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView3.DataSource = dt;

                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe_ingredient", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView4.DataSource = dt;
                    dataGridView7.DataSource = dt;


                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe_equipment", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView5.DataSource = dt;
                    dataGridView8.DataSource = dt;


                    con.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Insert into recipe (recipe_id, product_name, recipe_makes, work_time, total_time) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Delete from recipe where recipe_id='" + textBox1.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Insert into ingredient (ingredient_id, ingredient_name, unit_of_measurement) values ('" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Insert into equipment (equipment_id, equipment_name) values ('" + textBox9.Text + "', '" + textBox10.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Delete from equipment where equipment_id='" + textBox9.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Insert into recipe_ingredient (recipe_id, ingredient_id, quantity) values ('" + textBox11.Text + "', '" + textBox12.Text + "', '" + textBox13.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Insert into recipe_equipment (recipe_id, equipment_id) values ('" + textBox14.Text + "', '" + textBox15.Text + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Delete from ingredient where ingredient_id='" + textBox6.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Delete from recipe_ingredient where ingredient_id='" + textBox12.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;
            sql = "Delete from recipe_equipment where equipment_id='" + textBox15.Text + "'";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            BindGrid();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=JEB\SQLEXPRESS;database=Bakery;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe where recipe_id = '" + textBox16.Text + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView6.DataSource = dt;
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe_ingredient where recipe_id = '" + textBox16.Text + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView7.DataSource = dt;
                    con.Close();
                }
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM recipe_equipment where recipe_id = '" + textBox16.Text + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dataGridView8.DataSource = dt;
                    con.Close();
                }

            }
        }
    }
}
