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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ArabaKirala
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GRV4CB6\\SQLEXPRESS;Initial Catalog=carrentaldb;Integrated Security=True;TrustServerCertificate=True");
        //sqlconnection içine veritabanı bağlantısı
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "insert into Admin (username,userpass) values (@username,@userpass)";
            SqlCommand cmd=new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@userpass", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Eklendi");
            conn.Close();
            doldur();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            doldur();
            textBox4.Visible = false;
        }
        void doldur()
        {
            string cumle = "Select * from admin";
            SqlDataAdapter da=new SqlDataAdapter(cumle,conn);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            textBox3.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Tablodan Bir Seçim Yapmadınız");
            }
            else
            {
                conn.Open();
                string cumle = "Update admin set username=@username,userpass=@userpassword where Admin_Id=@Id";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@userpassword", textBox2.Text);
                cmd.Parameters.AddWithValue("@Id", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi");
                conn.Close();
                doldur();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Tablodan Bir Seçim Yapmadınız");
            }
            else
            {
                conn.Open();
                string cumle = "delete from admin where Admin_Id=@Id";
                SqlCommand cmd = new SqlCommand(cumle, conn);
                cmd.Parameters.Clear();
               
                cmd.Parameters.AddWithValue("@Id", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silinmiştir");
                conn.Close();
                doldur();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
     string cumle = "select * from admin where username like '%" + textBox4.Text + "%'";
            SqlCommand cmd=new SqlCommand(cumle, conn);
           
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            dataGridView1.DataSource = tb;
        }
    }
}
