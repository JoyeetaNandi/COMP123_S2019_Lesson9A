using System;
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

        public Label ActiveLabel { get; set; }

        //  <summary>
        // This is the contructor for the CalculatorForm 
        // </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            ActiveLabel = null;
            NumberButtonTableLayoutPanel.Visible = false;
            Size = new Size(320, 480);
        }

        private void CalculatorForm_Click(object sender, EventArgs e)
        {
            NumberButtonTableLayoutPanel.Visible = false;

            ActiveLabel = null;
            ClearNumericKeyboard();
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
            }
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
            if (outputString == string.Empty)
            {
                outputString = "0";
            }
            outputValue = float.Parse(outputString);
            //outputValue = (float)(Math.Round(outputValue, 1));
            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            ActiveLabel.Text = outputValue.ToString();
            ClearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
            ActiveLabel.BackColor = Color.White;
            ActiveLabel = null;
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

        
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
                ActiveLabel = null;
            }

            ActiveLabel = sender as Label;
            ActiveLabel.BackColor = Color.LightBlue;

            NumberButtonTableLayoutPanel.Visible = true;

            if (ActiveLabel.Text != "0")
            {
                ResultLabel.Text = ActiveLabel.Text;
                outputString = ActiveLabel.Text;
            }
            NumberButtonTableLayoutPanel.Location = new Point(12, ActiveLabel.Location.Y + 55);
            NumberButtonTableLayoutPanel.BringToFront();
        }

        
    }
}
