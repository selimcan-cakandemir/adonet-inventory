using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        //PUT YOUR CONNECTION STRING HERE
        string connectionString = "Server=DESKTOP-92AU4IL;Database=InventAnalytics;Trusted_Connection=True;";

        private void GetSales()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select SalesId, ProductName, StoreName, Date, SalesQuantity, Stock from Sales s inner join Products p on p.Id=s.ProductId inner join Stores st on st.Id=s.StoreId", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
     

        private void btnGetSalesHistory_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn()
            {
                Name = "Select one row to be deleted"
            };
            dataGridView1.Columns.Add(col);
            
            GetSales();
 

        }

        private void btnGetMostProfitable_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select StoreName,SUM((SalesPrice-Cost)*SalesQuantity) as TotalProfits from Sales s inner join Stores st on st.Id=s.StoreId inner join Products p on p.Id=s.ProductId group by StoreName order by TotalProfits desc", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

             


        }

        private void btnBestSellingProductByQuantity_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select ProductName, SUM(SalesQuantity) as TotalSold from Sales s inner join Stores st on st.Id = s.StoreId inner join Products p on p.Id = s.ProductId group by ProductName order by TotalSold desc", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Cevahir");
            //comboBox1.Items.Add("Istiklal");
            //comboBox1.Items.Add("Kadikoy");

            SqlDataAdapter dataAdapter = new SqlDataAdapter("select StoreName from Stores", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "StoreName";
            comboBox1.ValueMember = "StoreName";

            for (int i = 1; i <= 50; i++)
            {
                comboBox4.Items.Add(i);
                comboBox5.Items.Add(i);
            }

            

        }

        private void comboBox2_MouseClick_1(object sender, MouseEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select ProductName from Products", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductName";
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select StoreName from Stores", connectionString);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "StoreName";
            comboBox3.ValueMember = "StoreName";
        }

        private void btnGetProfitsByCompany_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select StoreName,SUM((SalesPrice-Cost)*SalesQuantity) as TotalProfits from Sales s inner join Stores st on st.Id=s.StoreId inner join Products p on p.Id=s.ProductId group by StoreName having StoreName like '%" + comboBox1.Text +"%'", connectionString);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnAddNewSales_Click(object sender, EventArgs e)
        {
            int productId = comboBox2.SelectedIndex + 1;
            int storeId = comboBox3.SelectedIndex + 1;
            int quantity = Convert.ToInt32(comboBox4.SelectedItem);
            int stock = Convert.ToInt32(comboBox5.SelectedItem);

            SqlDataAdapter dataAdapter = new SqlDataAdapter("insert into Sales (ProductId, StoreId, Date, SalesQuantity, Stock) values ("+productId+","+storeId+ ",CURRENT_TIMESTAMP," + quantity+","+stock+")", connectionString);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            GetSales();

        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    int id = Convert.ToInt16(row.Cells[1].Value);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("delete from Sales where SalesId=" + id, connectionString);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            GetSales();
        }

        private void btnUpdateSales_Click(object sender, EventArgs e)
        {
            int productId = comboBox2.SelectedIndex + 1;
            int storeId = comboBox3.SelectedIndex + 1;
            int quantity = Convert.ToInt32(comboBox4.SelectedItem);
            int stock = Convert.ToInt32(comboBox5.SelectedItem);

            DataGridViewRow row = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    int id = Convert.ToInt16(row.Cells[1].Value);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("update Sales set ProductId="+productId+", StoreId="+storeId+",SalesQuantity="+quantity+",Stock="+stock+" where SalesId="+id, connectionString);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            GetSales();



           
        }
    }
}