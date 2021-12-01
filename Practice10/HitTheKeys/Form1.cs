using System;
using System.Windows.Forms;

namespace HitTheKeys
{
    public partial class Form1 : Form
    {
        //Добавляем экземпляр класса Random, он нам понадобиться для получения слуйчаной буквы.
        Random _random = new Random();
        Stats _stats = new Stats();

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true; //Делаем таймер активным
            timer1.Start(); //Запускаем таймер 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)_random.Next(65, 90)); //Добавляем в listBox случайную букву.
            if (listBox1.Items.Count > 7) //Если букв больше 7 игра считается оконченной.
            {
                listBox1.Items.Clear(); //Очищаем listBox
                listBox1.Items.Add("Игра окончена!");
                timer1.Stop(); // Останавливаем таймер.
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Если пользователь правильно нажимает клавиши, то буквы удаляются, а скорость их появления увеличивается.
            if (listBox1.Items.Contains(e.KeyCode)) //Проверка на правильность нажатия.
            {
                listBox1.Items.Remove(e.KeyCode); //удаление буквы из listBox`а
                listBox1.Refresh();
                if (timer1.Interval > 400) timer1.Interval -= 10;
                if (timer1.Interval > 250) timer1.Interval -= 7;
                if (timer1.Interval > 100) timer1.Interval -= 2;

                difficultyProgressBar.Value = 800 - timer1.Interval;//Заполнение ProgressBar`а
                _stats.Update(true); //Обновляем статистику.
            }
            else
            {
                _stats.Update(false);
            }

            correctLabel.Text = "Correct: " + _stats.Correct;
            missedLabel.Text = "Missed " + _stats.Missed;
            totalLabel.Text = "Total " + _stats.Total;
            accuracyLabel.Text = "Accuracy: " + _stats.Accuracy + "%";
        }
    }
}