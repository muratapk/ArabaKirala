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

namespace ArabaKirala
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        carrentaldbEntities conn = new carrentaldbEntities();
        private void Kullanici_Load(object sender, EventArgs e)
        {
            doldur();
        }
        void doldur()
        {
            var veri = conn.Users.ToList();
            //linq lambda expression
            dataGridView1.DataSource = veri;
            //sürekli datagrid doldurun bir method
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.first_name = textBox1.Text;
            users.last_name = textBox2.Text;
            users.email = textBox3.Text;
            users.phone_number = textBox4.Text;
            users.address = textBox5.Text;
            users.date_of_birth = dateTimePicker1.Value;
            conn.Users.Add(users);
            conn.SaveChanges();
            doldur();
            temizle();

        }
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentRow.Index;
            //satir numarasını al varsayılan satır numarasını bul
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[satir].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[satir].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[satir].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[satir].Cells[5].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[satir].Cells[6].Value.ToString();
            textBox6.Text= dataGridView1.Rows[satir].Cells[0].Value.ToString();
            //id numarası olduğu için buraya sifir datagrid siralaması
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru=MessageBox.Show("Bu Kaydı Silmek İstiyor musun?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(soru==DialogResult.Yes) {
                int Id = Convert.ToInt32(textBox6.Text);
                var bul = conn.Users.Where(x => x.user_id == Id).FirstOrDefault();
                conn.Users.Remove(bul);
                conn.SaveChanges();
                doldur();
                temizle();
               }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bu Kaydı Düzeltmek İstiyor musun?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (soru == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(textBox6.Text);
                var bul = conn.Users.Where(x => x.user_id == Id).FirstOrDefault();
                bul.first_name = textBox1.Text;
                bul.last_name = textBox2.Text;
                bul.email = textBox3.Text;
                bul.phone_number = textBox4.Text;
                bul.address = textBox5.Text;
                bul.date_of_birth = dateTimePicker1.Value;
                conn.SaveChanges();
                doldur();
                temizle();
            }

        }
        List<Users> bul;//liste olarak tanımla
        private void button5_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Arama Bilgi Boş Lütfen Kayıt Girin");
            }
            else
            {
                if(radioButton1.Checked)
                {
                     bul = conn.Users.Where(x => x.first_name.Contains(textBox7.Text)).ToList();

                }
                else if(radioButton2.Checked)
                {
                     bul = conn.Users.Where(x => x.last_name.Contains(textBox7.Text)).ToList();
                }
                else if(radioButton3.Checked)
                {
                     bul = conn.Users.Where(x => x.email.Contains(textBox7.Text)).ToList();
                }
                else
                {
                    MessageBox.Show("Seçim Yapmadınız");
                }
                dataGridView1.DataSource = bul;
            }
        }
    }
}
