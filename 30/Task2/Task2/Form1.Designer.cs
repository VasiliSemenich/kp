namespace Task2
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
            btnShowTours = new Button();
            btnDeleteTour = new Button();
            btnUpdateTourist = new Button();
            btnAddTourist = new Button();
            txtDeleteTourId = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtUpdateTouristId = new TextBox();
            listBoxTours = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnShowTours
            // 
            btnShowTours.Location = new Point(40, 374);
            btnShowTours.Name = "btnShowTours";
            btnShowTours.Size = new Size(132, 29);
            btnShowTours.TabIndex = 0;
            btnShowTours.Text = "показать туры";
            btnShowTours.UseVisualStyleBackColor = true;
            btnShowTours.Click += btnShowTours_Click;
            // 
            // btnDeleteTour
            // 
            btnDeleteTour.Location = new Point(178, 374);
            btnDeleteTour.Name = "btnDeleteTour";
            btnDeleteTour.Size = new Size(140, 29);
            btnDeleteTour.TabIndex = 1;
            btnDeleteTour.Text = "Удалить тур";
            btnDeleteTour.UseVisualStyleBackColor = true;
            btnDeleteTour.Click += btnDeleteTour_Click;
            // 
            // btnUpdateTourist
            // 
            btnUpdateTourist.Location = new Point(324, 374);
            btnUpdateTourist.Name = "btnUpdateTourist";
            btnUpdateTourist.Size = new Size(129, 29);
            btnUpdateTourist.TabIndex = 2;
            btnUpdateTourist.Text = "Обновить туристов";
            btnUpdateTourist.UseVisualStyleBackColor = true;
            btnUpdateTourist.Click += btnUpdateTourist_Click;
            // 
            // btnAddTourist
            // 
            btnAddTourist.Location = new Point(459, 374);
            btnAddTourist.Name = "btnAddTourist";
            btnAddTourist.Size = new Size(143, 29);
            btnAddTourist.TabIndex = 3;
            btnAddTourist.Text = "Добавить туристов";
            btnAddTourist.UseVisualStyleBackColor = true;
            btnAddTourist.Click += btnAddTourist_Click;
            // 
            // txtDeleteTourId
            // 
            txtDeleteTourId.Location = new Point(40, 321);
            txtDeleteTourId.Name = "txtDeleteTourId";
            txtDeleteTourId.Size = new Size(125, 27);
            txtDeleteTourId.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(178, 321);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(309, 321);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(440, 321);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(125, 27);
            txtMiddleName.TabIndex = 7;
            // 
            // txtUpdateTouristId
            // 
            txtUpdateTouristId.Location = new Point(571, 321);
            txtUpdateTouristId.Name = "txtUpdateTouristId";
            txtUpdateTouristId.Size = new Size(125, 27);
            txtUpdateTouristId.TabIndex = 8;
            // 
            // listBoxTours
            // 
            listBoxTours.FormattingEnabled = true;
            listBoxTours.Location = new Point(40, 27);
            listBoxTours.Name = "listBoxTours";
            listBoxTours.Size = new Size(656, 244);
            listBoxTours.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 298);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "ID тура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 298);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 298);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 12;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 298);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 13;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 298);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 14;
            label5.Text = "ID туриста";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTours);
            Controls.Add(txtUpdateTouristId);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtDeleteTourId);
            Controls.Add(btnAddTourist);
            Controls.Add(btnUpdateTourist);
            Controls.Add(btnDeleteTour);
            Controls.Add(btnShowTours);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowTours;
        private Button btnDeleteTour;
        private Button btnUpdateTourist;
        private Button btnAddTourist;
        private TextBox txtDeleteTourId;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtUpdateTouristId;
        private ListBox listBoxTours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
