using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random _rnd = new Random();
        private Point _tmpLocation;

        readonly int _w = SystemInformation.PrimaryMonitorSize.Width;
        readonly int _h = SystemInformation.PrimaryMonitorSize.Height;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // переводит координату X в строку и записывает в поля ввода
            textBox1.Text = e.X.ToString();
            // переводит координату Y в строку и записывает в поля ввода
            textBox2.Text = e.Y.ToString();

            if (e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135)
            {
                _tmpLocation = this.Location;
                _tmpLocation.X += _rnd.Next(-100, 100);
                _tmpLocation.Y += _rnd.Next(-100, 100);

                if (_tmpLocation.X < 0 || _tmpLocation.X > (_w - this.Width / 2) || _tmpLocation.Y < 0 || _tmpLocation.Y > (_h - this.Height / 2))
                {
                    _tmpLocation.X = _w / 2;
                    _tmpLocation.Y = _h / 2;
                }

                this.Location = _tmpLocation;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Вывести сообщение с текстом "Вы усердны!"
            MessageBox.Show(@"Вы усердны!");
            // Завершить приложение
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Вывести сообщение с текстом "Мы не сомневались в вашем безразличии."
            // второй параметр - заголовок окна сообщения "Внимание"
            // MessageBoxButtons.OK - тип размещаемой кнопки на форме сообщения
            // MessageBoxIcon.Information - тип сообщения - будет иметь иконку "информация" и соотвествующий звукововой сигнал
            MessageBox.Show(@"Мы не сомневались в вашем безразличии.", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}