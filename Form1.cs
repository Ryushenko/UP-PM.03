using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            DatabaseHelper dbHelper = new DatabaseHelper();

            if (dbHelper.ValidateUser(username, password))
            {
                MessageBox.Show("Успешный вход!");
                // Здесь можно открыть основное окно приложения
                this.Hide(); // Скрыть форму авторизации
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            DatabaseHelper dbHelper = new DatabaseHelper();

            try
            {
                dbHelper.RegisterUser(username, password);
                MessageBox.Show("Пользователь успешно зарегистрирован!");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



public class DatabaseHelper
{
    private string connectionString = @"Data Source=SetbMagazinov.db;";
    

    // Метод для регистрации нового пользователя
    public void RegisterUser(string username, string password)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@username, @password)";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Добавление параметров
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", HashPassword(password)); // Хэширование пароля
                command.ExecuteNonQuery(); // Выполнение запроса
            }
        }
    }

    public bool UserExists(string username)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                return Convert.ToInt32(command.ExecuteScalar()) > 0; // Возвращает true, если пользователь существует
            }
        }
    }

    public bool ValidateUser(string username, string password)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT PasswordHash FROM Users WHERE Username = @username";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                var result = command.ExecuteScalar();

                if (result != null)
                {
                    string storedHash = result.ToString();
                    return VerifyPassword(password, storedHash); // Проверка пароля
                }
            }
        }
        return false; // Если пользователь не найден или пароль неверен
    }

    internal object ExecuteQuery(string query)
    {
        throw new NotImplementedException();
    }

    private string HashPassword(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    private bool VerifyPassword(string password, string storedHash)
    {
        string hashOfInput = HashPassword(password); // Хэшируем введенный пароль
        return hashOfInput.Equals(storedHash); // Сравниваем хэши
    }
}