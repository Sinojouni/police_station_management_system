namespace WinFormsApp1
{
    partial class ach5as
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            villageBindingSource1 = new BindingSource(components);
            villageBindingSource = new BindingSource(components);
            comboBox4 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)villageBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)villageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(526, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(904, 661);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 43);
            label1.TabIndex = 5;
            label1.Text = ": رقم المتسلسل";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(136, 43);
            label2.TabIndex = 6;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.2F);
            button8.Location = new Point(552, 697);
            button8.Name = "button8";
            button8.Size = new Size(189, 59);
            button8.TabIndex = 21;
            button8.Text = "الغاء";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F);
            button6.Location = new Point(779, 697);
            button6.Name = "button6";
            button6.Size = new Size(189, 59);
            button6.TabIndex = 19;
            button6.Text = "حذف";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.2F);
            button7.Location = new Point(1006, 697);
            button7.Name = "button7";
            button7.Size = new Size(189, 59);
            button7.TabIndex = 18;
            button7.Text = "تعديل";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.2F);
            button9.Location = new Point(1233, 697);
            button9.Name = "button9";
            button9.Size = new Size(189, 59);
            button9.TabIndex = 17;
            button9.Text = "ادخال";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "[الاسم]";
            textBox2.Size = new Size(249, 34);
            textBox2.TabIndex = 23;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 520);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "[المهنة]";
            textBox1.Size = new Size(240, 34);
            textBox1.TabIndex = 24;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(5, 9);
            label3.Name = "label3";
            label3.Size = new Size(111, 43);
            label3.TabIndex = 26;
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(84, 9);
            label4.Name = "label4";
            label4.Size = new Size(195, 43);
            label4.TabIndex = 25;
            label4.Text = ":  رقم المتسلسل للشخص";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 575);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "[رقم الهاتف]";
            textBox3.Size = new Size(240, 34);
            textBox3.TabIndex = 28;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(271, 138);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "[اسم الاب]";
            textBox4.Size = new Size(249, 34);
            textBox4.TabIndex = 27;
            textBox4.TextAlign = HorizontalAlignment.Right;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 193);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "[رقم و مكان السجل]";
            textBox5.Size = new Size(512, 34);
            textBox5.TabIndex = 30;
            textBox5.TextAlign = HorizontalAlignment.Right;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "لبنان" });
            comboBox1.Location = new Point(271, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(249, 28);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "مدعي", "مدعى عليه", "شاهد", "جاني", "مجني عليه", "مستمع", "مستجوب", "موقوف", "غير موجود", "وكيل مدعي" });
            comboBox2.Location = new Point(12, 247);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.Yes;
            comboBox2.Size = new Size(249, 28);
            comboBox2.TabIndex = 32;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(145, 294);
            comboBox3.Name = "comboBox3";
            comboBox3.RightToLeft = RightToLeft.Yes;
            comboBox3.Size = new Size(267, 28);
            comboBox3.TabIndex = 33;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // villageBindingSource1
            // 
            villageBindingSource1.DataSource = typeof(Repositories.Models.Village);
            // 
            // villageBindingSource
            // 
            villageBindingSource.DataSource = typeof(Repositories.Models.Village);
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "رومين" });
            comboBox4.Location = new Point(145, 341);
            comboBox4.Name = "comboBox4";
            comboBox4.RightToLeft = RightToLeft.Yes;
            comboBox4.Size = new Size(267, 28);
            comboBox4.TabIndex = 35;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Location = new Point(435, 294);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 36;
            label5.Text = "محل الولادة";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(435, 341);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 37;
            label6.Text = "محل الاقامة";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 390);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 27);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.Location = new Point(435, 390);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 39;
            label7.Text = "تاريخ الولادة";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            checkBox2.BackColor = Color.Transparent;
            checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            checkBox2.Location = new Point(153, 441);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(367, 24);
            checkBox2.TabIndex = 43;
            checkBox2.Text = "هل يوجد عنواون سكن";
            checkBox2.TextAlign = ContentAlignment.MiddleRight;
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.BackColor = Color.Transparent;
            checkBox4.CheckAlign = ContentAlignment.MiddleRight;
            checkBox4.Location = new Point(153, 471);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(367, 24);
            checkBox4.TabIndex = 44;
            checkBox4.Text = "هل يوجد رقم داخلي";
            checkBox4.TextAlign = ContentAlignment.MiddleRight;
            checkBox4.UseVisualStyleBackColor = false;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(267, 575);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "[رقم الهوية]";
            textBox7.Size = new Size(253, 34);
            textBox7.TabIndex = 46;
            textBox7.TextAlign = HorizontalAlignment.Right;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(267, 520);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "[اللقب]";
            textBox8.Size = new Size(253, 34);
            textBox8.TabIndex = 45;
            textBox8.TextAlign = HorizontalAlignment.Right;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "ذكر", "انثى" });
            comboBox5.Location = new Point(267, 636);
            comboBox5.Name = "comboBox5";
            comboBox5.RightToLeft = RightToLeft.Yes;
            comboBox5.Size = new Size(253, 28);
            comboBox5.TabIndex = 47;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "اعزب", "متزوج", "مطلق", "ارمل" });
            comboBox6.Location = new Point(12, 636);
            comboBox6.Name = "comboBox6";
            comboBox6.RightToLeft = RightToLeft.Yes;
            comboBox6.Size = new Size(240, 28);
            comboBox6.TabIndex = 48;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 138);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "[اسم الام]";
            textBox6.Size = new Size(253, 34);
            textBox6.TabIndex = 50;
            textBox6.TextAlign = HorizontalAlignment.Right;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(8, 83);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "[الشهرة]";
            textBox9.Size = new Size(253, 34);
            textBox9.TabIndex = 49;
            textBox9.TextAlign = HorizontalAlignment.Right;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F);
            button1.Location = new Point(104, 697);
            button1.Name = "button1";
            button1.Size = new Size(189, 59);
            button1.TabIndex = 53;
            button1.Text = "البصمات";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.Location = new Point(331, 697);
            button2.Name = "button2";
            button2.Size = new Size(189, 59);
            button2.TabIndex = 52;
            button2.Text = "الصورة";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ach5as
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 783);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(textBox9);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ach5as";
            Text = "ach5as";
            Load += ach5as_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)villageBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)villageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button8;
        private Button button6;
        private Button button7;
        private Button button9;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox6;
        private TextBox textBox9;
        private Button button1;
        private Button button2;
        private BindingSource villageBindingSource;
        private BindingSource villageBindingSource1;
    }
}