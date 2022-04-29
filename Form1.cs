using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace график_из_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string constr = "server=localhost;port=3306;username=root;password=Misha13242704;database=рубрика_эксперементы;";
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                MessageBox.Show("DB CONNECT");
                mycon.Close();

            }
            catch

            {
               
                MessageBox.Show("connection lost");

            }
        }

        class DB
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Misha13242704;database=рубрика_эксперементы;");

            public void OpenConnection()
            {
                
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

            }

            public void CloseConnection()
            {
               
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();

            }

            public MySqlConnection GetConnection()
            {

                return connection;

            }
        }



    }
}
