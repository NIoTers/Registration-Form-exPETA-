using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int startYear = 1960;
            int endYear = DateTime.Now.Year;
            for (int i = startYear; i <= endYear; i++)
            {
                year.Items.Add(i.ToString());
            }
            string[] months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            foreach (var item in months)
            {
                if (!string.IsNullOrEmpty(item)) 
                    month.Items.Add(item);
            }
            month.SelectedIndexChanged += (s, e) => UpdateDays();
            year.SelectedIndexChanged += (s, e) => UpdateDays();
        }
        private void UpdateDays()
        {
            if (month.SelectedItem == null || year.SelectedItem == null)
                return;

            int selectedMonth = DateTime.ParseExact(month.SelectedItem.ToString(), "MMMM", null).Month;
            int selectedYear = int.Parse(year.SelectedItem.ToString());

            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            date.Items.Clear();
            for (int i = 1; i <= daysInMonth; i++)
            {
                date.Items.Add(i.ToString("D2"));
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string fName = firstName.Text.Trim();
            string lName = lastName.Text.Trim();
            string mName = middleName.Text.Trim();
            string getMonth = month.Text;
            string getDate = date.Text;
            string getYear = year.Text;
            string gender = "";

            if (string.IsNullOrWhiteSpace(lName) ||
                string.IsNullOrWhiteSpace(fName) ||
                string.IsNullOrWhiteSpace(mName) ||
                string.IsNullOrWhiteSpace(getMonth) ||
                string.IsNullOrWhiteSpace(getDate) ||
                string.IsNullOrWhiteSpace(getYear) ||
                (!radioMale.Checked && !radioFemale.Checked))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioMale.Checked)
                gender = "Male";
            else if (radioFemale.Checked)
                gender = "Female";

            DialogResult result = MessageBox.Show(
                $"Student Name: {fName} {mName} {lName}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {getMonth} {getDate},{getYear}",
                "Student Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            if (result == DialogResult.OK)
            {
                Form2 newForm = new Form2();
                this.Hide();
                newForm.ShowDialog();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            month.SelectedIndex = 0;
            year.SelectedIndex = 0;
            date.SelectedIndex = 0;
        }
    }
}
