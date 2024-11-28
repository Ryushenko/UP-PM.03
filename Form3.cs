using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        private string connectionString = @"Data Source=SetbMagazinov.db;";
        private DatabaseHelper dbHelper;

        public Form3()
        {
            dbHelper = new DatabaseHelper();
            InitializeComponent();
        }


        private void buttonFindYoungest_Click(object sender, EventArgs e)
        {

        }

        // Обработчик для поиска случаев регистрации владения лицами младше 18 лет
        private void buttonFindUnderage_Click(object sender, EventArgs e)
        {

        }

        // Обработчик для поиска случаев, когда более 50% уставного капитала магазина внесено предпринимателем из другого района
        private void buttonFindHighInvestment_Click(object sender, EventArgs e)
        {

        }

        // Обработчик для вывода списка профилей магазинов, которыми владеет предприниматель "Кузнецов"
        private void buttonFindProfiles_Click(object sender, EventArgs e)
        {

        }

        private void LoadSuppliers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Suppliers"; // Запрос для получения всех магазинов
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Заполняем DataTable данными из базы
                        dataGridViewSuppliers.DataSource = dataTable; // Привязываем DataTable к DataGridView
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSuppliers(); // Загружаем поставщиков при загрузке формы
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем данные из текстовых полей
                string fullName = textBox6.Text.Trim(); // Убираем лишние пробелы
                decimal supplyCost = decimal.Parse(textBox1.Text); // Преобразование строки в decimal
                string phone = textBox10.Text.Trim();
                string address = textBox9.Text.Trim();

                // Открываем соединение с базой данных
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение

                    // SQL-запрос для добавления нового владельца
                    string query = "INSERT INTO Suppliers (FullName, Address, Phone, SupplyCost) " +
                                   "VALUES (@fullName, @address, @phone, @supplyCost)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Добавляем параметры к команде
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@supplyCost", supplyCost);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);


                        // Выполняем запрос
                        command.ExecuteNonQuery();
                        LoadSuppliers(); // Метод для загрузки владельцев из базы данных
                    }
                }

                MessageBox.Show("Поставщик успешно добавлен!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Поставщик при добавлении : {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем основное окно
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class DatabaseHelper
        {
            private string connectionString = @"Data Source=SetbMagazinov.db;"; // Укажите путь к вашей базе данных
            public DataTable ExecuteQuery(string query)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    connection.Open();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

         
        }

        private void buttonFindProfiles_Click_1(object sender, EventArgs e)
        {
            string query = @"SELECT s.Profile FROM Stores s
                         JOIN OwnerStores os ON s.StoreID = os.StoreID
                         JOIN Owners o ON os.OwnerID = o.OwnerID
                         WHERE o.FullName = 'Кузнецов'
                         ORDER BY o.Investment DESC;";
            dataGridViewResults.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void buttonFindUnderage_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Owners WHERE YEAR < 18;";
            dataGridViewResults.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void buttonFindYoungest_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT FullName FROM Owners WHERE Address LIKE '%Киевский%' ORDER BY RegistrationDate DESC LIMIT 1;";
            dataGridViewResults.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void buttonFindHighInvestment_Click_1(object sender, EventArgs e)
        {
            string query = @"SELECT s.StoreID, s.Name FROM Stores s
                         JOIN OwnerStores os ON s.StoreID = os.StoreID
                         JOIN Owners o ON os.OwnerID = o.OwnerID
                         WHERE o.Address NOT LIKE '%Киевский%'
                         AND s.CharterCapital * 0.5 < o.Investment;";
            dataGridViewResults.DataSource = dbHelper.ExecuteQuery(query);
        }
    }
}
    

