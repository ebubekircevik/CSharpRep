using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ETradeContex contex = new ETradeContex();
            
            using (ETradeContext contex = new ETradeContext())//boyle yazıldığında nesne ile işlem bittiğinde bellekten temizler
            {
                dgwProducts.DataSource = contex.Products.ToList();
            }
            
        }
    }
}
