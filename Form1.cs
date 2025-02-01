namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new ad5al());
            if (button2.BackColor != Color.Gray)
                button2.BackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new other());
            button2.BackColor = button3.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new other());
            button2.BackColor = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new other());
            button2.BackColor = button3.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new other());
            button2.BackColor = button3.BackColor;
        }
    }
}
