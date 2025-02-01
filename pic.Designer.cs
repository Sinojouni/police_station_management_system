namespace WinFormsApp1
{
    partial class pic
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
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button8 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new Point(2, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 43);
            label3.TabIndex = 30;
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(119, 9);
            label4.Name = "label4";
            label4.Size = new Size(130, 43);
            label4.TabIndex = 29;
            label4.Text = ":  اسم للشخص";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(264, 9);
            label2.Name = "label2";
            label2.Size = new Size(136, 43);
            label2.TabIndex = 28;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 43);
            label1.TabIndex = 27;
            label1.Text = ": رقم المتسلسل";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.2F);
            button8.Location = new Point(439, 684);
            button8.Name = "button8";
            button8.Size = new Size(189, 59);
            button8.TabIndex = 42;
            button8.Text = "الغاء";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F);
            button6.Location = new Point(666, 684);
            button6.Name = "button6";
            button6.Size = new Size(189, 59);
            button6.TabIndex = 41;
            button6.Text = "حذف";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.2F);
            button7.Location = new Point(893, 684);
            button7.Name = "button7";
            button7.Size = new Size(189, 59);
            button7.TabIndex = 40;
            button7.Text = "تعديل";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.2F);
            button9.Location = new Point(1120, 684);
            button9.Name = "button9";
            button9.Size = new Size(189, 59);
            button9.TabIndex = 39;
            button9.Text = "ادخال";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(967, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 405);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(552, 195);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 405);
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(129, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 405);
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F);
            button1.Location = new Point(1052, 130);
            button1.Name = "button1";
            button1.Size = new Size(189, 59);
            button1.TabIndex = 46;
            button1.Text = "وجه ايمن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F);
            button2.Location = new Point(637, 130);
            button2.Name = "button2";
            button2.Size = new Size(189, 59);
            button2.TabIndex = 47;
            button2.Text = "وجه امامي";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F);
            button3.Location = new Point(211, 130);
            button3.Name = "button3";
            button3.Size = new Size(189, 59);
            button3.TabIndex = 48;
            button3.Text = "وجه ايسر";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 783);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
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
            Name = "pic";
            Text = "pic";
            Load += pic_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button button8;
        private Button button6;
        private Button button7;
        private Button button9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}