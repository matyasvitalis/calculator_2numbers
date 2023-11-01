namespace calculator
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
            AddingButton = new Button();
            ResultButton = new Button();
            NumberTextBox = new TextBox();
            StatusText = new Label();
            SubtractionButton = new Button();
            DivisionButton = new Button();
            MultiplicationButton = new Button();
            SuspendLayout();
            // 
            // AddingButton
            // 
            AddingButton.Location = new Point(154, 25);
            AddingButton.Name = "AddingButton";
            AddingButton.Size = new Size(28, 26);
            AddingButton.TabIndex = 0;
            AddingButton.Text = "+";
            AddingButton.UseVisualStyleBackColor = true;
            AddingButton.Click += AddingButton_Click;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(154, 121);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(80, 26);
            ResultButton.TabIndex = 1;
            ResultButton.Text = "=";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(38, 25);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(100, 23);
            NumberTextBox.TabIndex = 2;
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.Location = new Point(27, 174);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(28, 15);
            StatusText.TabIndex = 3;
            StatusText.Text = "Text";
            // 
            // SubtractionButton
            // 
            SubtractionButton.Location = new Point(154, 57);
            SubtractionButton.Name = "SubtractionButton";
            SubtractionButton.Size = new Size(28, 26);
            SubtractionButton.TabIndex = 4;
            SubtractionButton.Text = "-";
            SubtractionButton.UseVisualStyleBackColor = true;
            SubtractionButton.Click += SubtractionButton_Click;
            // 
            // DivisionButton
            // 
            DivisionButton.Location = new Point(154, 89);
            DivisionButton.Name = "DivisionButton";
            DivisionButton.Size = new Size(28, 26);
            DivisionButton.TabIndex = 5;
            DivisionButton.Text = "/";
            DivisionButton.UseVisualStyleBackColor = true;
            DivisionButton.Click += DivisionButton_Click;
            // 
            // MultiplicationButton
            // 
            MultiplicationButton.Location = new Point(188, 89);
            MultiplicationButton.Name = "MultiplicationButton";
            MultiplicationButton.Size = new Size(28, 26);
            MultiplicationButton.TabIndex = 6;
            MultiplicationButton.Text = "*";
            MultiplicationButton.UseVisualStyleBackColor = true;
            MultiplicationButton.Click += MultiplicationButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 223);
            Controls.Add(MultiplicationButton);
            Controls.Add(DivisionButton);
            Controls.Add(SubtractionButton);
            Controls.Add(StatusText);
            Controls.Add(NumberTextBox);
            Controls.Add(ResultButton);
            Controls.Add(AddingButton);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddingButton;
        private Button ResultButton;
        private TextBox NumberTextBox;
        private Label StatusText;
        private Button SubtractionButton;
        private Button DivisionButton;
        private Button MultiplicationButton;
    }
}