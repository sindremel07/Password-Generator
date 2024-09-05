namespace Password_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            amountTextBox = new TextBox();
            amountSlider = new TrackBar();
            uppercaseCheckBox = new CheckBox();
            symbolsCheckBox = new CheckBox();
            numbersCheckBox = new CheckBox();
            lowercaseCheckBox = new CheckBox();
            passwordTextBox = new TextBox();
            copyButton = new Button();
            generateNewButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)amountSlider).BeginInit();
            SuspendLayout();
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(116, 259);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.PlaceholderText = "1";
            amountTextBox.ReadOnly = true;
            amountTextBox.Size = new Size(31, 23);
            amountTextBox.TabIndex = 0;
            // 
            // amountSlider
            // 
            amountSlider.Location = new Point(153, 259);
            amountSlider.Name = "amountSlider";
            amountSlider.Size = new Size(241, 45);
            amountSlider.TabIndex = 1;
            amountSlider.Scroll += amountSlider_Scroll;
            // 
            // uppercaseCheckBox
            // 
            uppercaseCheckBox.AutoSize = true;
            uppercaseCheckBox.Location = new Point(458, 231);
            uppercaseCheckBox.Name = "uppercaseCheckBox";
            uppercaseCheckBox.Size = new Size(81, 19);
            uppercaseCheckBox.TabIndex = 2;
            uppercaseCheckBox.Text = "Uppercase";
            uppercaseCheckBox.UseVisualStyleBackColor = true;
            uppercaseCheckBox.CheckedChanged += uppercaseCheckBox_CheckedChanged;
            // 
            // symbolsCheckBox
            // 
            symbolsCheckBox.AutoSize = true;
            symbolsCheckBox.Location = new Point(458, 296);
            symbolsCheckBox.Name = "symbolsCheckBox";
            symbolsCheckBox.Size = new Size(71, 19);
            symbolsCheckBox.TabIndex = 3;
            symbolsCheckBox.Text = "Symbols";
            symbolsCheckBox.UseVisualStyleBackColor = true;
            symbolsCheckBox.CheckedChanged += symbolsCheckBox_CheckedChanged;
            // 
            // numbersCheckBox
            // 
            numbersCheckBox.AutoSize = true;
            numbersCheckBox.Location = new Point(458, 274);
            numbersCheckBox.Name = "numbersCheckBox";
            numbersCheckBox.Size = new Size(75, 19);
            numbersCheckBox.TabIndex = 4;
            numbersCheckBox.Text = "Numbers";
            numbersCheckBox.UseVisualStyleBackColor = true;
            numbersCheckBox.CheckedChanged += numbersCheckBox_CheckedChanged;
            // 
            // lowercaseCheckBox
            // 
            lowercaseCheckBox.AutoSize = true;
            lowercaseCheckBox.Location = new Point(458, 253);
            lowercaseCheckBox.Name = "lowercaseCheckBox";
            lowercaseCheckBox.Size = new Size(81, 19);
            lowercaseCheckBox.TabIndex = 5;
            lowercaseCheckBox.Text = "Lowercase";
            lowercaseCheckBox.UseVisualStyleBackColor = true;
            lowercaseCheckBox.CheckedChanged += lowercaseCheckBox_CheckedChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(143, 178);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(454, 33);
            passwordTextBox.TabIndex = 6;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(603, 185);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 7;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // generateNewButton
            // 
            generateNewButton.Location = new Point(322, 340);
            generateNewButton.Name = "generateNewButton";
            generateNewButton.Size = new Size(135, 23);
            generateNewButton.TabIndex = 8;
            generateNewButton.Text = "Generate New";
            generateNewButton.UseVisualStyleBackColor = true;
            generateNewButton.Click += generateNewButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(244, 80);
            label1.Name = "label1";
            label1.Size = new Size(313, 45);
            label1.TabIndex = 9;
            label1.Text = "Password Generator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(generateNewButton);
            Controls.Add(copyButton);
            Controls.Add(passwordTextBox);
            Controls.Add(lowercaseCheckBox);
            Controls.Add(numbersCheckBox);
            Controls.Add(symbolsCheckBox);
            Controls.Add(uppercaseCheckBox);
            Controls.Add(amountSlider);
            Controls.Add(amountTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)amountSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox amountTextBox;
        private TrackBar amountSlider;
        private CheckBox uppercaseCheckBox;
        private CheckBox symbolsCheckBox;
        private CheckBox numbersCheckBox;
        private CheckBox lowercaseCheckBox;
        private TextBox passwordTextBox;
        private Button copyButton;
        private Button generateNewButton;
        private Label label1;
    }
}