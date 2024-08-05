using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace İLİŞKİTABLOWİNFORM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS;Initial Catalog=iliskiveritablo;Integrated Security=True;");



        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            bgl.Open();
          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select HAREKETID,URUNAD,(ad+'' +soyad) as 'MÜŞTERİ',ADSOYAD,URUNAD  from tblhareket\r\ninner join urunler on tblhareket.URUN=urunler.URUNID\r\n\r\ninner join MUSTERİ \r\non tblhareket.MUSTERİ = MUSTERİ.ID\r\n\r\ninner join PERSONEL \r\non PERSONEL.ID =tblhareket.PERSONEL", bgl);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.Close();

        }

       
    }
}
