﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson9A
{
    public partial class CalculatorForm : Form
    {
        // Class Property
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }


        //  <summary>
        // This is the contructor for the CalculatorForm 
        // </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }
        // <summary>
        // this is the shared event handler for the CalculatorButon click event
        // </summary>
        // <param name="sender"></param>
        // <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }
                }
                ResultLabel.Text = outputString;
            }
            else
            {
                    switch(tag)
                {
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "clear":
                        ClearNumericKeyboard();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
           
        }

        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        private void finalizeOutput()
        {
            
            outputValue = float.Parse(outputString);
            outputValue = (float)(Math.Round(outputValue, 1));
            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            HeightLabel.Text = outputValue.ToString();
            ClearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
        }

        private void removeLastCharacterFromResultLabel()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);
            if (outputString.Length == 0)
            {
                outputString = "0";
            }
            ResultLabel.Text = outputString;
        }

        private void ClearNumericKeyboard()
        {
            ResultLabel.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
        }

        private void HeightLabel_Click(object sender, EventArgs e)
        {
            NumberButtonTableLayoutPanel.Visible = true;
        }
    }
}
