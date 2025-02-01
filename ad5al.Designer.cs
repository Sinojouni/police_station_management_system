namespace WinFormsApp1
{
    partial class ad5al
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            investBindingSource = new BindingSource(components);
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            checkBox2 = new CheckBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            investBindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(50, 50, 50);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1452, 107);
            label1.TabIndex = 0;
            label1.Text = "ادخال";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(902, 110);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(367, 59);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "هل يوجد ملخص";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(905, 635);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // investBindingSource
            // 
            investBindingSource.DataSource = typeof(Repositories.Models.Invest);
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(82, 131);
            label3.Name = "label3";
            label3.Size = new Size(358, 47);
            label3.TabIndex = 5;
            label3.Text = "تاريخ الادخال";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(82, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(358, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(82, 295);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(358, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(82, 238);
            label2.Name = "label2";
            label2.Size = new Size(358, 47);
            label2.TabIndex = 8;
            label2.Text = "تاريخ المعاملة";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            checkBox2.BackColor = Color.Transparent;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(902, 159);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(367, 59);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "هل يوجد مضبوطات";
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(358, 28);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 445);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 414);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1292, 879);
            button1.Name = "button1";
            button1.Size = new Size(148, 59);
            button1.TabIndex = 12;
            button1.Text = "ادخال";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1138, 879);
            button2.Name = "button2";
            button2.Size = new Size(148, 59);
            button2.TabIndex = 13;
            button2.Text = "تعديل";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(830, 879);
            button3.Name = "button3";
            button3.Size = new Size(148, 59);
            button3.TabIndex = 15;
            button3.Text = "تحديث";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(984, 879);
            button4.Name = "button4";
            button4.Size = new Size(148, 59);
            button4.TabIndex = 14;
            button4.Text = "حذف";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(368, 879);
            button5.Name = "button5";
            button5.Size = new Size(148, 59);
            button5.TabIndex = 19;
            button5.Text = "سيارات";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(522, 879);
            button7.Name = "button7";
            button7.Size = new Size(148, 59);
            button7.TabIndex = 17;
            button7.Text = "اشخاص";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(676, 879);
            button8.Name = "button8";
            button8.Size = new Size(148, 59);
            button8.TabIndex = 16;
            button8.Text = "الغاء";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // investBindingSource1
            // 
            investBindingSource1.DataSource = typeof(Repositories.Models.Invest);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 348);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "جرائم اخرى";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(358, 27);
            textBox2.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(825, 141);
            label4.Name = "label4";
            label4.Size = new Size(176, 38);
            label4.TabIndex = 22;
            label4.Text = "  : المتسلسل ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(685, 140);
            label5.Name = "label5";
            label5.Size = new Size(176, 38);
            label5.TabIndex = 23;
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ad5al
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1452, 950);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ad5al";
            Text = "ad5al";
            Load += ad5al_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)investBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private BindingSource investBindingSource;
        private BindingSource investBindingSource1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
    }
}