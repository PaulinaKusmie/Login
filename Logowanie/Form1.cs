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

namespace Logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dell\source\repos\Logowanie\Logowanie\Database1.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From TABLE where Username='" + textBox1.Text + "' and Password = '" + textBox2.Text + " ' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();

                Main ss = new Main();
                ss.Show();

            }
            else
            {
                MessageBox.Show("Chcek IT!");
            }






        }
    }
}
