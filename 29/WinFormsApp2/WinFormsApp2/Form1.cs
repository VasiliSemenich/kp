using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace RunningTextApp
{
    public partial class Form1 : Form
    {
        private Bitmap? bmp; // ������ ��������� null
        private int bannerWidth;
        private int bannerHeight;
        private int x;
        private System.Windows.Forms.Timer? timer; // ������ ��������� null

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                // ��������� ����������� �� ����� � ����������
                string imagePath = Path.Combine(Application.StartupPath, "banner.jpg");
                MessageBox.Show("������� ���������: " + imagePath);

                if (!File.Exists(imagePath))
                {
                    MessageBox.Show("���� �� ������: " + imagePath);
                    return;
                }

                bmp = new Bitmap(imagePath);
                bannerWidth = bmp.Width;
                bannerHeight = bmp.Height;
                x = -bannerWidth;

                MessageBox.Show("����������� ���������!");

                timer = new System.Windows.Forms.Timer { Interval = 50 };
                timer.Tick += Timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ �������� �����������: " + ex.Message);
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Console.WriteLine("������ ��������! x = " + x);
            x += 5;
            if (x > ClientSize.Width) x = -bannerWidth;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Console.WriteLine("OnPaint ������!");

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            if (bmp != null)
            {
                g.DrawImage(bmp, x, ClientSize.Height / 2 - bannerHeight / 2);
            }
            else
            {
                Console.WriteLine("������: bmp == null!");
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
