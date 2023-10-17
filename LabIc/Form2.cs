using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lbl11
{
    public partial class Form2 : Form
    {
        OleDbConnection oleDbConnection = null;

        OleDbDataAdapter oleDbDataAdapter = null;

        DataTable dt = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Database2.accdb");
            oleDbConnection.Open();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string CS = "SELECT * FROM Реки";
            oleDbDataAdapter = new OleDbDataAdapter(CS, oleDbConnection);

            DataSet ds = new DataSet("Реки");
            DataTable dt = new DataTable("Реки");
            ds.Tables.Add(dt);
            oleDbDataAdapter.Fill(ds.Tables["Реки"]);

            ds.WriteXml("Rekidb.xml");
            Console.WriteLine("Данные сохранены в файл");

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Rekidb.xml");
            dt = new DataTable();
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
