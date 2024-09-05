using System;
using System.Linq;
using System.Security.Cryptography;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        private string booleansAllowed;


        static string uppercaseArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowercaseArray = "abcdefghijklmnopqrstuvwxyz";
        static string numberArray = "0123456789";
        static string symbolArray = "!@&%$/+?*`-¤";

        Random rnd = new Random();

        char[] uppercaseList = uppercaseArray.ToCharArray();
        char[] lowercaseList = lowercaseArray.ToCharArray();
        char[] numberList = numberArray.ToCharArray();
        char[] symbolList = symbolArray.ToCharArray();

        public Form1()
        {
            booleansAllowed = "0123";

            InitializeComponent();
            amountSlider.Maximum = 50;
            amountSlider.Minimum = 1;
            amountSlider.Value = 16;
            amountTextBox.Text = amountSlider.Value.ToString();

            uppercaseCheckBox.Checked = true;
            lowercaseCheckBox.Checked = true;
            numbersCheckBox.Checked = true;
            symbolsCheckBox.Checked = true;
        }

        private void amountSlider_Scroll(object sender, EventArgs e)
        {
            amountTextBox.Text = amountSlider.Value.ToString();
        }

        private void generateNewButton_Click(object sender, EventArgs e)
        {
            UpdateBooleansAllowed();
            passwordTextBox.Text = generatePassword();
        }

        private void UpdateBooleansAllowed()
        {
            booleansAllowed = "";
            if (uppercaseCheckBox.Checked) booleansAllowed += "0";
            if (lowercaseCheckBox.Checked) booleansAllowed += "1";
            if (numbersCheckBox.Checked) booleansAllowed += "2";
            if (symbolsCheckBox.Checked) booleansAllowed += "3";
        }

        string generatePassword()
        {
            if (string.IsNullOrEmpty(booleansAllowed))
            {
                return "";
            }

            string generatedPassword = "";
            int lastRandomChoice;

            var availableTypes = booleansAllowed.Select(c => (int)char.GetNumericValue(c)).ToArray();

            for (int i = 0; i < amountSlider.Value; i++)
            {
                lastRandomChoice = availableTypes[rnd.Next(availableTypes.Length)];

                switch (lastRandomChoice)
                {
                    case 0:
                        generatedPassword += uppercaseList[rnd.Next(uppercaseList.Length)].ToString();
                        break;
                    case 1:
                        generatedPassword += lowercaseList[rnd.Next(lowercaseList.Length)].ToString();
                        break;
                    case 2:
                        generatedPassword += numberList[rnd.Next(numberList.Length)].ToString();
                        break;
                    case 3:
                        generatedPassword += symbolList[rnd.Next(symbolList.Length)].ToString();
                        break;
                }
            }

            return generatedPassword;
        }


        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooleansAllowed();
        }

        private void lowercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooleansAllowed();
        }

        private void numbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooleansAllowed();
        }

        private void symbolsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBooleansAllowed();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(passwordTextBox.Text);
        }
    }
}