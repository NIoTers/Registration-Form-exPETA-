using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration
{
    public partial class Form2 : Form
    {
        int count = 0;
        string imagePath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Images\\");
        string[] images = { "pic1.jpg", "pic2.jpg", "pic3.jpg" };
        public Form2()
        {
            
            InitializeComponent();
            comboMenu.Items.Add("My Cute Pics");
            comboMenu.Items.Add("My Cute Pets");
            comboMenu.Items.Add("My Cute Crush");
            comboMenu.SelectedIndex = 0;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboMenu.SelectedItem.ToString();

            if (selectedValue == "My Cute Pics")
            {
                count = 0;
                UpdateImage();
            }
            else if(selectedValue == "My Cute Pets")
            {
                count = 0;
                UpdateImage();
            } else if(selectedValue == "My Cute Crush")
            {
                count = 0;
                UpdateImage();  
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                UpdateImage();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (count < images.Length - 1)
            {
                count++;
                UpdateImage();
            }
        }

        private void UpdateImage()
        {
            string selectedValue = comboMenu.SelectedItem?.ToString();
            if (selectedValue == "My Cute Pics")
            {
                titleName.Text = "My Cute Pics";
                string fullPath = Path.Combine(imagePath + "mypic", images[count]);

                if (File.Exists(fullPath))
                {
                    imageShow.Image = new Bitmap(fullPath);
                }
                else
                {
                    MessageBox.Show("Image not found at: " + fullPath);
                }
            }
            else if(selectedValue == "My Cute Pets")
            {
                titleName.Text = "My Cute Pets";
                string fullPath = Path.Combine(imagePath + "mypet", images[count]);

                if (File.Exists(fullPath))
                {
                    imageShow.Image = new Bitmap(fullPath);
                }
                else
                {
                    MessageBox.Show("Image not found at: " + fullPath);
                }

            }
            else if (selectedValue == "My Cute Crush")
            {
                titleName.Text = "My Cute Crush";
                string fullPath = Path.Combine(imagePath + "mycrush", images[count]);

                if (File.Exists(fullPath))
                {
                    imageShow.Image = new Bitmap(fullPath);
                }
                else
                {
                    MessageBox.Show("Image not found at: " + fullPath);
                }

            }
        }
    }
}
