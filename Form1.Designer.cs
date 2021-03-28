
namespace IMT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WomenButton = new System.Windows.Forms.RadioButton();
            this.MenButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IMTBox = new System.Windows.Forms.TextBox();
            this.resault = new System.Windows.Forms.Button();
            this.rost = new System.Windows.Forms.TextBox();
            this.ves = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AgeBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WomenButton);
            this.panel1.Controls.Add(this.MenButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IMTBox);
            this.panel1.Controls.Add(this.resault);
            this.panel1.Controls.Add(this.rost);
            this.panel1.Controls.Add(this.ves);
            this.panel1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 447);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(558, 175);
            this.label7.TabIndex = 15;
            this.label7.Text = "         label 7 ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(260, 390);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 30);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(558, 134);
            this.label6.TabIndex = 13;
            this.label6.Text = "label 6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(35, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите свой возраст (от 18):";
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AgeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeBox.Location = new System.Drawing.Point(260, 126);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(2);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(101, 22);
            this.AgeBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(106, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберете ваш пол:";
            // 
            // WomenButton
            // 
            this.WomenButton.AutoSize = true;
            this.WomenButton.BackColor = System.Drawing.Color.Transparent;
            this.WomenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WomenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WomenButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WomenButton.ForeColor = System.Drawing.Color.Blue;
            this.WomenButton.Location = new System.Drawing.Point(367, 63);
            this.WomenButton.Name = "WomenButton";
            this.WomenButton.Size = new System.Drawing.Size(92, 23);
            this.WomenButton.TabIndex = 9;
            this.WomenButton.TabStop = true;
            this.WomenButton.Text = "Женский";
            this.WomenButton.UseVisualStyleBackColor = false;
            this.WomenButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // MenButton
            // 
            this.MenButton.AutoSize = true;
            this.MenButton.BackColor = System.Drawing.Color.Transparent;
            this.MenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenButton.ForeColor = System.Drawing.Color.Blue;
            this.MenButton.Location = new System.Drawing.Point(266, 61);
            this.MenButton.Name = "MenButton";
            this.MenButton.Size = new System.Drawing.Size(95, 23);
            this.MenButton.TabIndex = 8;
            this.MenButton.TabStop = true;
            this.MenButton.Text = "Мужской";
            this.MenButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(168, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваш ИМТ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(115, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите свой вес:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(108, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите свой рост:";
            // 
            // IMTBox
            // 
            this.IMTBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMTBox.Location = new System.Drawing.Point(260, 339);
            this.IMTBox.Margin = new System.Windows.Forms.Padding(2);
            this.IMTBox.Name = "IMTBox";
            this.IMTBox.Size = new System.Drawing.Size(90, 22);
            this.IMTBox.TabIndex = 3;
            this.IMTBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resault
            // 
            this.resault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resault.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resault.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resault.Location = new System.Drawing.Point(244, 392);
            this.resault.Margin = new System.Windows.Forms.Padding(2);
            this.resault.Name = "resault";
            this.resault.Size = new System.Drawing.Size(117, 28);
            this.resault.TabIndex = 2;
            this.resault.Text = "Рассчитать";
            this.resault.UseVisualStyleBackColor = true;
            this.resault.Click += new System.EventHandler(this.resault_Click);
            // 
            // rost
            // 
            this.rost.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rost.Location = new System.Drawing.Point(260, 289);
            this.rost.Margin = new System.Windows.Forms.Padding(2);
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(101, 22);
            this.rost.TabIndex = 1;
            this.rost.TextChanged += new System.EventHandler(this.rost_TextChanged);
            // 
            // ves
            // 
            this.ves.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ves.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ves.Location = new System.Drawing.Point(260, 227);
            this.ves.Margin = new System.Windows.Forms.Padding(2);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(101, 22);
            this.ves.TabIndex = 0;
            this.ves.TextChanged += new System.EventHandler(this.ves_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculator IMT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resault;
        private System.Windows.Forms.TextBox rost;
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.TextBox IMTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton WomenButton;
        private System.Windows.Forms.RadioButton MenButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
    }
}

