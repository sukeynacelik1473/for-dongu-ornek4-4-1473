using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_4_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();//lisbox nesnesine temizle

            int sayi1=Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            //yazdırma

            for(int i=sayi1; i<=sayi2; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
