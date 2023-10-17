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
    public partial class Form1 : Form
    {
        OleDbConnection oleDbConnection = null;

        OleDbDataAdapter oleDbDataAdapter = null;

        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Database2.accdb");
            oleDbConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CS = "SELECT * From Видеокарты";
            oleDbDataAdapter = new OleDbDataAdapter(CS, oleDbConnection);
            dt = new DataTable();
            dt.Clear();

            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string comDel = "DELETE FROM Видеокарты WHERE Код = " + tb_Id.Text;
            oleDbDataAdapter = new OleDbDataAdapter(comDel, oleDbConnection);
            dt = new DataTable();
            dt.Clear();

            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (tb_CN.Text != "")
            {
                string comChange = "UPDATE Видеокарты SET Название ='" + tb_CN.Text + "' WHERE Код =" + tb_Id.Text;
                oleDbDataAdapter = new OleDbDataAdapter(comChange, oleDbConnection);
                dt = new DataTable();
                dt.Clear();

                oleDbDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (tb_CC.Text != "")
            {
                string comChange = "UPDATE Видеокарты SET Производитель = " + tb_CC.Text + " WHERE Код =" + tb_Id.Text;
                oleDbDataAdapter = new OleDbDataAdapter(comChange, oleDbConnection);
                dt = new DataTable();
                dt.Clear();

                oleDbDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (rt_CI.Text != "")
            {
                string comChange = "UPDATE Видеокарты SET Стоимость = '" + rt_CI.Text + "' WHERE Код =" + tb_Id.Text;
                oleDbDataAdapter = new OleDbDataAdapter(comChange, oleDbConnection);
                dt = new DataTable();
                dt.Clear();

                oleDbDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string comCreate = $"INSERT INTO Видеокарты (Код, Название, Производитель, Стоимость) VALUES ('{tb_Id.Text}', '{tb_CN.Text}', '{tb_CC.Text}', '{rt_CI.Text}')";
            oleDbDataAdapter = new OleDbDataAdapter(comCreate, oleDbConnection);
            dt = new DataTable();
            dt.Clear();

            oleDbDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
