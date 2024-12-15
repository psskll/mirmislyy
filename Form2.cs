using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace мирмыслей
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Color activeBackroundColor = Color.FromArgb(199, 159, 239);
        private Color activeForegroundColor = Color.FromArgb(106, 90, 205);

        private Color defaultBackgroundColor = Color.FromArgb(230, 230, 250);
        private Color defaultForekgroundColor = Color.FromArgb(200, 200, 200);

        //для перетаскивания формы
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private void SetButtonColors(IconButton button, Color backcolor, Color forecolor)
        {
            button.BackColor = backcolor;
            button.ForeColor = forecolor;
            button.IconColor = forecolor;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState |= FormWindowState.Maximized;
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackroundColor, activeForegroundColor);

            leftPanel1.Visible = true;

            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForekgroundColor);
            SetButtonColors(iconButton1, defaultBackgroundColor, defaultForekgroundColor);

            leftPanel2.Visible = false;
            leftPanel1.Visible = false;

            // Создаем и открываем Form5
            Form3 form3 = new Form3();

            // Устанавливаем форму как безрамочную (если требуется)
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.TopLevel = false; // Убираем верхний уровень
            form3.Dock = DockStyle.Fill; // Заполняем панель

            // Очищаем панель3 перед добавлением новой формы (если нужно)
            panel3.Controls.Clear();

            // Добавляем Form5 в панель3
            panel3.Controls.Add(form3);

            // Показываем форму
            form3.Show();
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackroundColor, activeForegroundColor);

            leftPanel2.Visible = true;

            SetButtonColors(iconButton1, defaultBackgroundColor, defaultForekgroundColor);
            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForekgroundColor);

            leftPanel2.Visible = false;
            leftPanel1.Visible = false;

            // Создаем и открываем Form5
            Form4 form4 = new Form4();

            // Устанавливаем форму как безрамочную (если требуется)
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.TopLevel = false; // Убираем верхний уровень
            form4.Dock = DockStyle.Fill; // Заполняем панель

            // Очищаем панель3 перед добавлением новой формы (если нужно)
            panel3.Controls.Clear();

            // Добавляем Form5 в панель3
            panel3.Controls.Add(form4);

            // Показываем форму
            form4.Show();
        }

       

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location; // Запоминаем начальное положение формы
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, (Size)dragCursorPoint); // Использовать Point для вычисления разницы
                this.Location = Point.Add(this.Location, (Size)dif); // Использовать Point для вычисления нового положения
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackroundColor, activeForegroundColor);

            leftPanel2.Visible = true;

            SetButtonColors(iconButton1, defaultBackgroundColor, defaultForekgroundColor);
            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForekgroundColor);

            leftPanel2.Visible = false;
            leftPanel1.Visible = false;

            // Создаем и открываем Form5
            Form4 form4 = new Form4();

            // Устанавливаем форму как безрамочную (если требуется)
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.TopLevel = false; // Убираем верхний уровень
            form4.Dock = DockStyle.Fill; // Заполняем панель

            // Очищаем панель3 перед добавлением новой формы (если нужно)
            panel3.Controls.Clear();

            // Добавляем Form5 в панель3
            panel3.Controls.Add(form4);

            // Показываем форму
            form4.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Каждый день Ангелина Ланская получает цветы. Цветов всегда чётное количество, и она понятия не имеет, кто их отправитель. Загадочный поклонник намеренно сводит её с ума, играет, сажает на иглу адреналина и ожидания. Этот человек точно знает, чем её зацепить.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Семнадцатилетняя Лика Вернер после покушения на её жизнь обнаруживает, что в состоянии стресса может ненадолго перемещаться в тела других людей. Лика уверена, что сходит с ума, пока не встречает человека, который подозрительно хорошо осведомлен о такого рода «симптомах».");

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меня зовут Долорес Макбрайд, и я с рождения страдаю от очень редкой формы аллергии: прикосновения к другим людям вызывают у меня сильнейшие ожоги. Я не могу поцеловать парня, обнять родителей, выйти из дому, не надев перчатки. Я неприкасаемая. Я словно живу в заколдованном замке, который держит меня в плену и наказывает ожогами и шрамами за каждую попытку «побега». Даже придумала имя для своей тюрьмы: Стигмалион.");

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тесса ждала идеального момента, идеального парня, идеального поцелуя. Она полагала, что у нее еще есть время. Но у девушки неизлечимая болезнь, порок сердца, бороться с которой бесполезно.\r\nВстреча с Оскаром переворачивает жизнь Тессы. Молодой человек подарил ей идеальное лето и путешествие по Италии. Лето, где время не имеет значения, а чувства — это все, ради чего стоит жить...");

        }
    }
}
