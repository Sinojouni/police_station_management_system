using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories;
using WinFormsApp1.Repositories.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class syarat : Form
    {
        private int serial;
        private Vehicle selectedcar;
        private InvEntities invEntities;

        public syarat()
        {
            InitializeComponent();
        }

        public syarat(int serial, InvEntities invEntities)
        {
            this.serial = serial;
            InitializeComponent();
            this.invEntities = invEntities;
            dataGridView1.RowHeaderMouseClick += dataGridView1_SelectionChanged;
        }

        private void ResetcomboBox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void ClearForm()
        {
            ResetcomboBox();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            checkBox2.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox16.Clear();
            textBox18.Clear();
            label3.Text = "";
            selectedcar = null;
            numericUpDown1.Value = 10;
        }
        private async Task Loadcombo()
        {
            try
            {
                await Task.Run(() => invEntities.Villages.ToList());
                comboBox1.DataSource = await Task.Run(() => invEntities.Villages.ToList());
                comboBox1.ValueMember = "LABEL";
                comboBox1.DisplayMember = "LABEL";
                comboBox2.DataSource = await Task.Run(() => invEntities.Villages.ToList());
                comboBox2.ValueMember = "LABEL";
                comboBox2.DisplayMember = "LABEL";
                comboBox4.DataSource = await Task.Run(() => invEntities.Villages.ToList());
                comboBox4.ValueMember = "LABEL";
                comboBox4.DisplayMember = "LABEL";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                Vehicle sayara = new Vehicle
                {
                    SerialNb = serial,
                    ActualNb = textBox2.Text,
                    CodeDesc = comboBox3.Text,
                    Proddate = dateTimePicker1.Value.ToString(),
                    Dateaquisition = dateTimePicker2.Value.ToString(),
                    Motor = textBox4.Text,
                    ColorDesc = textBox3.Text,
                    Brand = textBox10.Text,
                    Model = textBox8.Text,
                    Name = textBox12.Text,
                    Lastname = textBox14.Text,
                    TelProp = textBox9.Text,
                    BirthPlace = comboBox2.Text,
                    AgeProp = numericUpDown1.Value.ToString(),
                    MotherName = textBox13.Text,
                    Address = textBox18.Text,
                    Chassis = textBox1.Text,
                    Horsservice = Convert.ToInt32(textBox5.Text),
                    GovernateId = textBox16.Text,
                    UtilisDesc = textBox7.Text,
                    DistrictId = comboBox4.Text,
                    NoRegProp = checkBox2.Checked.ToString(),
                    PreMiseCirc = comboBox1.Text,
                };

                invEntities.Vehicles.Add(sayara);

                try
                {
                    await invEntities.SaveChangesAsync();
                    ClearForm();
                    await LoadDataAsync();
                    MessageBox.Show("Record added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding record: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("not correct");
            }
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var investData = await invEntities.Vehicles.Where(v => v.SerialNb == serial).ToListAsync();
                dataGridView1.DataSource = investData;
                label2.Text = serial.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int carnb = Convert.ToInt32(selectedRow.Cells["Vid"].Value);
                selectedcar = invEntities.Vehicles.Find(carnb);
                if (selectedcar != null)
                {
                    textBox2.Text = selectedcar.ActualNb;
                    comboBox3.Text = selectedcar.CodeDesc;
                    textBox4.Text = selectedcar.Motor;
                    textBox3.Text = selectedcar.ColorDesc;
                    textBox10.Text = selectedcar.Brand;
                    textBox8.Text = selectedcar.Model;
                    textBox12.Text = selectedcar.Name;
                    textBox14.Text = selectedcar.Lastname;
                    textBox9.Text = selectedcar.TelProp;
                    comboBox2.Text = selectedcar.BirthPlace;
                    numericUpDown1.Value = Convert.ToInt32(selectedcar.AgeProp);
                    textBox13.Text = selectedcar.MotherName;
                    textBox18.Text = selectedcar.Address;
                    textBox1.Text = selectedcar.Chassis;
                    textBox5.Text = selectedcar.Horsservice.ToString();
                    textBox16.Text = selectedcar.GovernateId;
                    textBox7.Text = selectedcar.UtilisDesc;
                    comboBox4.Text = selectedcar.DistrictId;
                    comboBox1.Text = selectedcar.PreMiseCirc;
                    checkBox2.Checked = selectedcar.NoRegProp == "True";
                    label3.Text = carnb.ToString();
                }
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label3.Text) && int.TryParse(label3.Text, out int carId))
            {
                if(isvalid())
                {
                    try
                    {
                        selectedcar = await invEntities.Vehicles.FindAsync(carId);
                        if (selectedcar != null)
                        {
                            selectedcar.SerialNb = serial;
                            selectedcar.ActualNb = textBox2.Text;
                            selectedcar.CodeDesc = comboBox3.Text;
                            selectedcar.Proddate = dateTimePicker1.Value.ToString();
                            selectedcar.Dateaquisition = dateTimePicker2.Value.ToString();
                            selectedcar.Motor = textBox4.Text;
                            selectedcar.ColorDesc = textBox3.Text;
                            selectedcar.Brand = textBox10.Text;
                            selectedcar.Model = textBox8.Text;
                            selectedcar.Name = textBox12.Text;
                            selectedcar.Lastname = textBox14.Text;
                            selectedcar.TelProp = textBox9.Text;
                            selectedcar.BirthPlace = comboBox2.Text;
                            selectedcar.AgeProp = numericUpDown1.Value.ToString();
                            selectedcar.MotherName = textBox13.Text;
                            selectedcar.Address = textBox18.Text;
                            selectedcar.Chassis = textBox1.Text;
                            selectedcar.Horsservice = Convert.ToInt32(textBox5.Text);
                            selectedcar.GovernateId = textBox16.Text;
                            selectedcar.UtilisDesc = textBox7.Text;
                            selectedcar.DistrictId = comboBox4.Text;
                            selectedcar.NoRegProp = checkBox2.Checked.ToString();
                            selectedcar.PreMiseCirc = comboBox1.Text;
                            await invEntities.SaveChangesAsync();
                            ClearForm();
                            await LoadDataAsync();
                            MessageBox.Show("Record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating record: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("not correct");
                }
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int vid = Convert.ToInt32(row.Cells["Vid"].Value);
                try
                {
                    var record = await invEntities.Vehicles.FindAsync(vid);
                    if (record != null)
                    {
                        invEntities.Vehicles.Remove(record);
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
            await LoadDataAsync();
            ClearForm();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            ClearForm();
            await LoadDataAsync();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void syarat_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await Loadcombo();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool isvalid()
        {
            bool check = true;
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox14.Text))
            {
                check = false;
            }
            if (string.IsNullOrEmpty(textBox18.Text))
            {
                check = false;
            }
            if (!int.TryParse(textBox16.Text, out int result))
            {
                check = false;
            }
            if (!int.TryParse(textBox5.Text, out int result2))
            {
                check = false;
            }
            if (!int.TryParse(textBox9.Text, out int result3))
            {
                check = false;
            }
            return check;

        }
    }
}
