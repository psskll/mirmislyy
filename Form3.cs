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

namespace мирмыслей
{
    public partial class Form3 : Form
    {
        private Form4 form4; // Экземпляр Form4
        public Form3()
        {
            InitializeComponent();
            form4 = new Form4();
            // Добавление обработчика события при выборе строки в DataGridView1
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }
        public class DatabaseConnection
        {
            public static MySqlConnection GetConnection()
            {
                string connectionString = "server=localhost;database=userss;username=root;password=pussykiller21!;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }

        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {

            string poo = "SELECT * FROM books"; // Исправленное название таблицы
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(poo, connection))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    // Устанавливаем русские заголовки для столбцов
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Название";
                    dataGridView1.Columns[2].HeaderText = "Автор";
                    dataGridView1.Columns[3].HeaderText = "Количество страниц";
                    dataGridView1.Columns[4].HeaderText = "Жанр";
                    dataGridView1.Columns[5].HeaderText = "Цена";
                    connection.Close();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"title LIKE '%{guna2TextBox1.Text}%'";
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"cost <=200";
                    break;
                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"cost >=200 AND cost <=500";
                    break;
                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"cost >=500";
                    break;
                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    break;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            // Проверяем, есть ли выбранная строка в DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Извлекаем данные из ячеек выбранной строки
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    string id = selectedRow.Cells[0].Value?.ToString() ?? "Не указано"; // ID
                    string title = selectedRow.Cells[1].Value?.ToString() ?? "Не указано"; // Название
                    string author = selectedRow.Cells[2].Value?.ToString() ?? "Не указано"; // Автор
                    string numberOfPages = selectedRow.Cells[3].Value?.ToString() ?? "Не указано"; // Количество страниц
                    string genre = selectedRow.Cells[4].Value?.ToString() ?? "Не указано"; // Жанр
                    string cost = selectedRow.Cells[5].Value?.ToString() ?? "Не указано"; // Цена

                    // Формируем строку для добавления в CheckedListBox
                    string itemToAdd = $"{title} - {author} ({numberOfPages} стр., Жанр: {genre}, Цена: {cost})";

                    // Получаем экземпляр формы 4 (если она уже открыта)
                    Form4 form4 = Application.OpenForms.OfType<Form4>().FirstOrDefault();

                    if (form4 == null)
                    {
                        // Если форма не открыта, создаем новую
                        form4 = new Form4();
                        form4.Show();
                    }
                    else
                    {
                        // Если форма уже открыта, активируем её
                        form4.Activate();
                    }

                    // Добавляем элемент в CheckedListBox на форме 4
                    form4.AddItemToCheckedListBox(itemToAdd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку из таблицы.");
            }


        }
    }
}
