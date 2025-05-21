using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RunningTextApp
{
    public partial class Form1 : Form
    {
        private Bitmap? bmp; // Теперь допускает null
        private int bannerWidth;
        private int bannerHeight;
        private int x;
        private System.Windows.Forms.Timer? timer; // Теперь допускает null

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                // Загружаем изображение из папки с программой
                string imagePath = Path.Combine(Application.StartupPath, "banner.jpg");
                MessageBox.Show("Пытаюсь загрузить: " + imagePath);

                if (!File.Exists(imagePath))
                {
                    MessageBox.Show("Файл не найден: " + imagePath);
                    return;
                }

                bmp = new Bitmap(imagePath);
                bannerWidth = bmp.Width;
                bannerHeight = bmp.Height;
                x = -bannerWidth;

                MessageBox.Show("Изображение загружено!");

                timer = new System.Windows.Forms.Timer { Interval = 50 };
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Console.WriteLine("Таймер сработал! x = " + x);
            x += 5;
            if (x > ClientSize.Width) x = -bannerWidth;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Console.WriteLine("OnPaint вызван!");

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (bmp != null)
            {
                g.DrawImage(bmp, x, ClientSize.Height / 2 - bannerHeight / 2);
            }
            else
            {
                Console.WriteLine("Ошибка: bmp == null!");
            }
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            timer!.Enabled = e.X <= ClientSize.Width / 2;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(800, 400);
            Name = "Form1";
            Text = "Running Banner";
            Load += new EventHandler(Form1_Load);
            MouseMove += new MouseEventHandler(Form1_MouseMove);
            ResumeLayout(false);
        }
    }
}
