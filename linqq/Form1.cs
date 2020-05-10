using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqq
{
    public partial class Form1 : Form
    {
        northwindDataContext db = new northwindDataContext();
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //select * from prdcts...
           // var query1 = from p in db.Products select p;
            //select pid,pname,unit price frm prdcts
            //var query2 = from p in db.Products select new { p.ProductID, p.ProductName, p.UnitPrice };
            //select * frm prdct where pid=1
            //var query3 = from p in db.Products where p.ProductID == 1 select p;
            //var query4 = from p in db.Products where p.SupplierID == 5 && p.UnitPrice > 20 select p;
            var query5 = from p in db.Products where p.SupplierID == 5 && p.SupplierID==6 select p;
            var query6 = from p in db.Products orderby p.ProductID select p;
            var query7 = from p in db.Products orderby p.ProductID descending select p;
            var query8 = from p in db.Products orderby p.CategoryID descending, p.UnitPrice descending select p;
            var query9 = (from p in db.Products select p).Take(10);
            var query11 = (from p in db.Products select p).First();
            var query12 = (from p in db.Products orderby p.ProductID select p).Take(10);
            var query13=(from p in db.Products select p.CategoryID).Distinct();
            var query14 = from p in db.Products group p by p.CategoryID into g select new { CategoryId = g.Key, NewField = g.Count() };
            
            dataGridView1.DataSource = query14.ToList();
        }
    }
}
