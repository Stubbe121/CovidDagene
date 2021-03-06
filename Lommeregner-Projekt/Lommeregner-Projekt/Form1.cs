﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner_Projekt
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Buttone_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")||(operation_pressed)
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")||
                Result.Clear();
            Button b = (Button)sender;
            Result.Text = Result.Text + b.Text;
        }

        private void ButtonCancelE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true; 
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        private void ButtonMultiplyer_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(Result.Text);
            operation_pressed = true;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Result.Text = (value + double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (value - double.Parse(Result.Text)).ToString();
                    break;
                case "x":
                    Result.Text = (value * double.Parse(Result.Text)).ToString();
                    break; 
                case "/":
                    Result.Text = (value / double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false; 

        }
    }
}
