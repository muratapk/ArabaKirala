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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kullanici yeni = new Kullanici();
        Arabalar araba = new Arabalar();

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //bu class bunu türettik
            yeni.MdiParent = this;
            //formun alt elemanı olduğu belirtiyoruz
            yeni.Show();
            araba.Hide();

        }

        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            araba.MdiParent = this; 
            araba.Show();
            yeni.Hide();
            
        }
    }
}
