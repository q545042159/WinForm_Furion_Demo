using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var hello = new HelloService();
            textBox1.Text = hello.SayHello();

            var csroomtype = "select * from CSRoomType".SqlQuery();

            dataGridView1.DataSource = csroomtype;

        }
    }
}
