namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonLoadTours = new Button();
            buttonAddTourist = new Button();
            buttonUpdateTourist = new Button();
            buttonDeleteTour = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxMiddleName = new TextBox();
            textBoxNewName = new TextBox();
            textBoxTouristId = new TextBox();
            textBoxTourId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 289);
            dataGridView1.TabIndex = 0;
            // 
            // buttonLoadTours
            // 
            buttonLoadTours.Location = new Point(12, 385);
            buttonLoadTours.Name = "buttonLoadTours";
            buttonLoadTours.Size = new Size(164, 29);
            buttonLoadTours.TabIndex = 1;
            buttonLoadTours.Text = "Загрузить туры";
            buttonLoadTours.UseVisualStyleBackColor = true;
            buttonLoadTours.Click += buttonLoadTours_Click;
            // 
            // buttonAddTourist
            // 
            buttonAddTourist.Location = new Point(182, 385);
            buttonAddTourist.Name = "buttonAddTourist";
            buttonAddTourist.Size = new Size(164, 29);
            buttonAddTourist.TabIndex = 2;
            buttonAddTourist.Text = "Добавить туристов";
            buttonAddTourist.UseVisualStyleBackColor = true;
            buttonAddTourist.Click += buttonAddTourist_Click;
            // 
            // buttonUpdateTourist
            // 
            buttonUpdateTourist.Location = new Point(352, 385);
            buttonUpdateTourist.Name = "buttonUpdateTourist";
            buttonUpdateTourist.Size = new Size(164, 29);
            buttonUpdateTourist.TabIndex = 3;
            buttonUpdateTourist.Text = "Обновить  туристов";
            buttonUpdateTourist.UseVisualStyleBackColor = true;
            buttonUpdateTourist.Click += buttonUpdateTourist_Click;
            // 
            // buttonDeleteTour
            // 
            buttonDeleteTour.Location = new Point(522, 385);
            buttonDeleteTour.Name = "buttonDeleteTour";
            buttonDeleteTour.Size = new Size(164, 29);
            buttonDeleteTour.TabIndex = 4;
            buttonDeleteTour.Text = "Удалить тур";
            buttonDeleteTour.UseVisualStyleBackColor = true;
            buttonDeleteTour.Click += buttonDeleteTour_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 340);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(143, 340);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Location = new Point(274, 340);
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(125, 27);
            textBoxMiddleName.TabIndex = 7;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(405, 340);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(125, 27);
            textBoxNewName.TabIndex = 8;
            // 
            // textBoxTouristId
            // 
            textBoxTouristId.Location = new Point(536, 340);
            textBoxTouristId.Name = "textBoxTouristId";
            textBoxTouristId.Size = new Size(125, 27);
            textBoxTouristId.TabIndex = 9;
            // 
            // textBoxTourId
            // 
            textBoxTourId.Location = new Point(667, 340);
            textBoxTourId.Name = "textBoxTourId";
            textBoxTourId.Size = new Size(125, 27);
            textBoxTourId.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 317);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 317);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 12;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 317);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 13;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 317);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 14;
            label4.Text = "Новое имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(536, 317);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 15;
            label5.Text = "ID туриста";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(667, 317);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 16;
            label6.Text = "ID тура";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTourId);
            Controls.Add(textBoxTouristId);
            Controls.Add(textBoxNewName);
            Controls.Add(textBoxMiddleName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(buttonDeleteTour);
            Controls.Add(buttonUpdateTourist);
            Controls.Add(buttonAddTourist);
            Controls.Add(buttonLoadTours);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonLoadTours;
        private Button buttonAddTourist;
        private Button buttonUpdateTourist;
        private Button buttonDeleteTour;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxMiddleName;
        private TextBox textBoxNewName;
        private TextBox textBoxTouristId;
        private TextBox textBoxTourId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
