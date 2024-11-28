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


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        private string connectionString = @"Data Source=SetbMagazinov.db;";
        private DatabaseHelper dbHelper;
        public Form2()
        {
            InitializeComponent();
            LoadStores(); // Загружаем данные при открытии формы
            LoadOwners(); // Загружаем владельцев
            dbHelper = new DatabaseHelper();
        }

        private void LoadStores()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Stores"; // Запрос для получения всех магазинов
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Заполняем DataTable данными из базы
                        dataGridViewStores.DataSource = dataTable; // Привязываем DataTable к DataGridView
                    }
                }
            }
        }

        private void LoadOwners()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Owners"; // Запрос для получения всех владельцев
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); // Заполняем DataTable данными из базы
                        dataGridViewOwners.DataSource = dataTable; // Привязываем DataTable к DataGridView
                    }
                }
            }
        }

    
    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            try
            {               
                // Считываем данные из текстовых полей
                string name = textBox6.Text.Trim(); // Убираем лишние пробелы
                decimal charterCapital = decimal.Parse(textBox7.Text); // Преобразование строки в decimal
                string profile = textBox5.Text.Trim();
                string phone = textBox10.Text.Trim();
                string address = textBox9.Text.Trim();

                // Открываем соединение с базой данных
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение

                    // SQL-запрос для добавления нового владельца
                    string query = "INSERT INTO Stores (Name, Address, Phone, CharterCapital, Profile) " +
                                   "VALUES (@name, @address, @phone, @charterCapital, @profile)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Добавляем параметры к команде
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@charterCapital", charterCapital);
                        command.Parameters.AddWithValue("@profile", profile);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@address", address);


                        // Выполняем запрос
                        command.ExecuteNonQuery();
                        LoadStores(); // Метод для загрузки владельцев из базы данных
                    }
                }

                MessageBox.Show("Магазин успешно добавлен!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Магазин при добавлении владельца: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем основное окно
            Form1 newForm = new Form1();
            newForm.Show();
        }





        private void button1_Click(object sender, EventArgs e) // Обработчик нажатия кнопки
        {
            
            try
            {
               
                // Считываем данные из текстовых полей
                string fullName = textBox1.Text.Trim(); // Убираем лишние пробелы
                string address = textBox2.Text.Trim();
                string phone = textBox3.Text.Trim();
                decimal investment = decimal.Parse(textBox4.Text); // Преобразование строки в decimal
                string registrationNumber = textBox5.Text.Trim();
                DateTime registrationDate = dateTimePicker1.Value; // Получаем выбранную дату
                int year = int.Parse(textBox8.Text); // Получаем год из TextBox

                // Открываем соединение с базой данных
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение

                    // SQL-запрос для добавления нового владельца
                    string query = "INSERT INTO Owners (FullName, Address, Phone, Investment, RegistrationNumber, RegistrationDate, YEAR) " +
                                   "VALUES (@fullName, @address, @phone, @investment, @registrationNumber, @registrationDate, @year)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Добавляем параметры к команде
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@investment", investment);
                        command.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                        command.Parameters.AddWithValue("@registrationDate", registrationDate.ToString("yyyy-MM-dd")); // Преобразуем дату в строку
                        command.Parameters.AddWithValue("@year", year);

                        // Выполняем запрос
                        command.ExecuteNonQuery();
                        LoadOwners();
                    }
                   
                }

                MessageBox.Show("Владелец успешно добавлен!");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении владельца: {ex.Message}");
            }
        }

        private void dataGridViewOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewStores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем основное окно
            Form3 newForm = new Form3();
            newForm.Show();
        }
    }
}


