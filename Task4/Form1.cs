﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RegistryKey rk = Registry.CurrentUser; // Создание регистрационного ключа
            RegistryKey reskey = rk.OpenSubKey("SaveFormKey", true);

            BackColor = Color.FromArgb(int.Parse(reskey.GetValue("Color", Color.White.ToArgb()).ToString()));
            textBox1.Text = reskey.GetValue("Text", "").ToString();
            Width = int.Parse(reskey.GetValue("WeightForm", 808).ToString());
            Height = int.Parse(reskey.GetValue("HeightForm", 477).ToString());

            reskey.Close();
        }
        
        private void saveValue_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser; // Создание регистрационного ключа
            RegistryKey reskey = rk.OpenSubKey("SaveFormKey", true);

            reskey.SetValue("Color", BackColor.ToArgb());
            reskey.SetValue("Text", textBox1.Text);
            reskey.SetValue("WeightForm", Size.Width);
            reskey.SetValue("HeightForm", Size.Height);

            reskey.Close();
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbColors.SelectedItem)
            {
                case "Черный":
                    {
                        BackColor = Color.Black;
                        break;
                    }
                case "Синий":
                    {
                        BackColor = Color.Blue;
                        break;
                    }
                case "Белый":
                    {
                        BackColor = Color.White;
                        break;
                    }
                case "Красный":
                    {
                        BackColor = Color.Red;
                        break;
                    }
            }
        }

        private void DeleteSave_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser; // Создание регистрационного ключа
            RegistryKey reskey = rk.OpenSubKey("SaveFormKey", true);

            reskey.DeleteValue("Color");
            reskey.DeleteValue("Text");
            reskey.DeleteValue("WeightForm");
            reskey.DeleteValue("HeightForm");
        }
    }
}
