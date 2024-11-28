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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=E:\SetbMagazinov.db;";
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        public class DatabaseHelper
        {
            private string connectionString = @"Data Source=E:\SetbMagazinov.db;"; // Укажите путь к вашей базе данных

            public DataTable GetOwners()
            {
                DataTable dataTable = new DataTable();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT * FROM Owners;";
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                return dataTable;
            }

            public DataTable GetStores()
            {
                DataTable dataTable = new DataTable();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT * FROM Stores;";
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                return dataTable;
            }
            public DataTable GetSuppliers()
            {
                DataTable dataTable = new DataTable();
                using (var connection = new SQLiteConnection(connectionString))
                {
                    string query = "SELECT * FROM Suppliers;";
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var adapter = new SQLiteDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                return dataTable;
            }
            // Добавьте другие методы для других таблиц по аналогии...
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ownersData = dbHelper.GetOwners();
            dataGridView1.DataSource = ownersData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var storesData = dbHelper.GetStores();
            dataGridView2.DataSource = storesData;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var suppliersData = dbHelper.GetSuppliers();
            dataGridView3.DataSource = suppliersData;
        }
    }
}
