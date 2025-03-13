using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKirala
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        carrentaldbEntities conn=new carrentaldbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //select * from Admin Where user='aafa' and pass='125'
            var sonuc = conn.Admin.Where(x => x.username == textBox1.Text && x.userpass == textBox2.Text).FirstOrDefault();
            if (sonuc != null)
            {
                //gelen veri dolu ise
                Form1 yeni=new Form1();
                yeni.Show();
                this.Hide();
            }
            else
            {
                //gelen veri boş ise
                MessageBox.Show("Kullanıcı adı ve Şifre Hatalı");
            }
            
        }
    }
}
