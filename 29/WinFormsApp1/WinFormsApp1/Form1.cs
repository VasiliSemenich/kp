using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        private System.Windows.Forms.Timer timer; // Явное указание пространства имен

        public Form1()
        {
            InitializeComponent();

            // Создание и настройка таймера
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 100; // Длина стрелки
            a = 0; // Угол поворота
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;

            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 + (int)(r * Math.Sin(a));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            a -= Math.PI / 30; // Угол поворота (360° / 60 секунд = 6° = π/30)
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 + (int)(r * Math.Sin(a));

            Invalidate(); // Перерисовываем форму
        }
    }
}
