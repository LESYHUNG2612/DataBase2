using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnReloadCategory_Click(object sender, EventArgs e)
        {

        }
        private List<Category>GetCategories()
        {
            //khoi tao doi tuong Context
            var dbContext = new RestaurantContext();
            //lay danh sach tat ca nhom thuc an sap xep theo ten
            return dbContext.Categories.OrderBy(x => x.Name).ToList();

        }
    }
}
