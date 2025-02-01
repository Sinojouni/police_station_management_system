namespace WinFormsApp1
{
    partial class finger
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
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.Location = new Point(240, 145);
            button2.Name = "button2";
            button2.Size = new Size(189, 59);
            button2.TabIndex = 61;
            button2.Text = "ابهام ايسر";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F);
            button1.Location = new Point(1088, 145);
            button1.Name = "button1";
            button1.Size = new Size(189, 59);
            button1.TabIndex = 60;
            button1.Text = "ابهام ايمن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(155, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 405);
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1003, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 405);
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.2F);
            button8.Location = new Point(475, 699);
            button8.Name = "button8";
            button8.Size = new Size(189, 59);
            button8.TabIndex = 56;
            button8.Text = "الغاء";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F);
            button6.Location = new Point(702, 699);
            button6.Name = "button6";
            button6.Size = new Size(189, 59);
            button6.TabIndex = 55;
            button6.Text = "حذف";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.2F);
            button7.Location = new Point(929, 699);
            button7.Name = "button7";
            button7.Size = new Size(189, 59);
            button7.TabIndex = 54;
            button7.Text = "تعديل";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.2F);
            button9.Location = new Point(1156, 699);
            button9.Name = "button9";
            button9.Size = new Size(189, 59);
            button9.TabIndex = 53;
            button9.Text = "ادخال";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label3
            // 
            label3.Location = new Point(38, 24);
            label3.Name = "label3";
            label3.Size = new Size(142, 43);
            label3.TabIndex = 52;
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(155, 24);
            label4.Name = "label4";
            label4.Size = new Size(130, 43);
            label4.TabIndex = 51;
            label4.Text = ":  اسم للشخص";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(300, 24);
            label2.Name = "label2";
            label2.Size = new Size(136, 43);
            label2.TabIndex = 50;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(411, 24);
            label1.Name = "label1";
            label1.Size = new Size(130, 43);
            label1.TabIndex = 49;
            label1.Text = ": رقم المتسلسل";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // finger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 783);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "finger";
            Text = "finger";
            Load += finger_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button8;
        private Button button6;
        private Button button7;
        private Button button9;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}