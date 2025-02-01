using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories;
using WinFormsApp1.Repositories.Models;

namespace WinFormsApp1
{
    public partial class ach5as : Form
    {
        private int serial;
        private Invperson selectedper;
        private InvEntities invEntities;

        public ach5as()
        {
            InitializeComponent();
            ResetcomboBox();
        }

        public ach5as(int serial,InvEntities invEntities)
        {
            this.serial = serial;
            this.invEntities = invEntities;
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += dataGridView1_SelectionChanged;
        }
        private async void ach5as_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await Loadcombo();
            comboBox2.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var investData = await Task.Run(() => invEntities.Invpersons.Where(v => v.Serial == serial).ToList());
                Invoke(new Action(() => dataGridView1.DataSource = investData));
                Invoke(new Action(() => label2.Text = serial.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private async Task Loadcombo()
        {
            try
            {
                await Task.Run(() => invEntities.Villages.ToList());
                comboBox3.DataSource = await Task.Run(() => invEntities.Villages.ToList());
                comboBox3.ValueMember = "LABEL";
                comboBox3.DisplayMember = "LABEL";
                comboBox4.DataSource = await Task.Run(() => invEntities.Villages.ToList());
                comboBox4.ValueMember = "LABEL";
                comboBox4.DisplayMember = "LABEL";
                comboBox1.DataSource = await Task.Run(() => invEntities.Nations.ToList());
                comboBox1.ValueMember = "ALABEL";
                comboBox1.DisplayMember = "ALABEL";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void ResetcomboBox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            ResetcomboBox();
            dateTimePicker1.Value = DateTime.Now;
            checkBox4.Checked = false;
            checkBox2.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox6.Clear();
            label3.Text = "";
            selectedper = null;
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            int ch1 = checkBox2.Checked ? 0 : 1;
            int ch2 = checkBox4.Checked ? 0 : 1;

            if (isvalid())
            {
                Invperson newpers = new Invperson
                {
                    Serial = serial,
                    Fname = textBox2.Text,
                    Lname = textBox9.Text,
                    Father = textBox4.Text,
                    Mother = textBox6.Text,
                    Reg = textBox5.Text,
                    Nation = comboBox1.Text,
                    Pbirth = comboBox3.Text,
                    Dbirth = dateTimePicker1.Value.ToString(),
                    Resid = comboBox4.Text,
                    Gender = comboBox5.Text,
                    Status = comboBox6.Text,
                    Mobileno = textBox3.Text,
                    Idnum = textBox7.Text,
                    Occupation = textBox1.Text,
                    Nickname = textBox8.Text,
                    Adrs = comboBox2.Text,
                    Attr = ch1,
                    Exst = ch2,
                };

                invEntities.Invpersons.Add(newpers);
                await invEntities.SaveChangesAsync();
                ClearForm();
                await LoadDataAsync();

                MessageBox.Show("Record added successfully!");
            }

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                if(isvalid())
                {
                    selectedper = await invEntities.Invpersons.FindAsync(Convert.ToInt32(label3.Text));
                    if (selectedper != null)
                    {
                        int ch1 = checkBox2.Checked ? 0 : 1;
                        int ch2 = checkBox4.Checked ? 0 : 1;

                        selectedper.Serial = serial;
                        selectedper.Fname = textBox2.Text;
                        selectedper.Lname = textBox9.Text;
                        selectedper.Father = textBox4.Text;
                        selectedper.Mother = textBox6.Text;
                        selectedper.Reg = textBox5.Text;
                        selectedper.Nation = comboBox1.Text;
                        selectedper.Pbirth = comboBox3.Text;
                        selectedper.Dbirth = dateTimePicker1.Value.ToString();
                        selectedper.Resid = comboBox4.Text;
                        selectedper.Gender = comboBox5.Text;
                        selectedper.Status = comboBox6.Text;
                        selectedper.Mobileno = textBox3.Text;
                        selectedper.Idnum = textBox7.Text;
                        selectedper.Occupation = textBox1.Text;
                        selectedper.Nickname = textBox8.Text;
                        selectedper.Adrs = comboBox2.Text;
                        selectedper.Attr = ch1;
                        selectedper.Exst = ch2;

                        await invEntities.SaveChangesAsync();
                        ClearForm();
                        await LoadDataAsync();

                        MessageBox.Show("Record updated successfully!");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private async Task DeleteRecordAsync(int serialNumber)
        {
            try
            {
                var record = await invEntities.Invpersons.FindAsync(serialNumber);
                if (record != null)
                {
                    invEntities.Invpersons.Remove(record);
                    await invEntities.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int vid = Convert.ToInt32(row.Cells["Serpers"].Value);
                await DeleteRecordAsync(vid);
            }
            await LoadDataAsync();
            ClearForm();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            ClearForm();
            await LoadDataAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                pic pic = new pic(Convert.ToInt32(label3.Text), selectedper.Fname, this.serial , this.invEntities);
                pic.Show();
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                finger fin = new finger(Convert.ToInt32(label3.Text), selectedper.Fname, this.serial, this.invEntities);
                fin.Show();
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int pernb = Convert.ToInt32(selectedRow.Cells["Serpers"].Value);
                selectedper = invEntities.Invpersons.Find(pernb);
                if (selectedper != null)
                {
                    textBox2.Text = selectedper.Fname;
                    textBox9.Text = selectedper.Lname;
                    textBox4.Text = selectedper.Father;
                    textBox6.Text = selectedper.Mother;
                    textBox5.Text = selectedper.Reg;
                    comboBox1.Text = selectedper.Nation;
                    comboBox3.Text = selectedper.Pbirth;
                    comboBox4.Text = selectedper.Resid;
                    comboBox5.Text = selectedper.Gender;
                    comboBox6.Text = selectedper.Status;
                    textBox3.Text = selectedper.Mobileno;
                    textBox7.Text = selectedper.Idnum;
                    textBox1.Text = selectedper.Occupation;
                    textBox8.Text = selectedper.Nickname;
                    comboBox2.Text = selectedper.Adrs;
                    checkBox2.Checked = selectedper.Attr == 0;
                    checkBox4.Checked = selectedper.Exst == 0;
                    label3.Text = pernb.ToString();
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private bool isvalid()
        {
            bool check=true;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                check = false;
                MessageBox.Show("enter the name");
            }
            if (!int.TryParse(textBox5.Text,out int result))
            {
                check = false;
                MessageBox.Show("enter the correct id");
            }
            if (!int.TryParse(textBox7.Text, out int result2))
            {
                check = false;
                MessageBox.Show("enter the correct id number");
            }
            if (!int.TryParse(textBox3.Text, out int result3))
            {
                check = false;
                MessageBox.Show("enter the correct  phon number");
            }


            return check;

        }

    }
}
