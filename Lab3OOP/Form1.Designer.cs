namespace Lab3OOP
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numberTypeComboBox = new ComboBox();
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            resultLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 1;
            // 
            // numberTypeComboBox
            // 
            numberTypeComboBox.FormattingEnabled = true;
            numberTypeComboBox.Items.AddRange(new object[] { "Integer", "Real" });
            numberTypeComboBox.Location = new Point(79, 90);
            numberTypeComboBox.Name = "numberTypeComboBox";
            numberTypeComboBox.Size = new Size(151, 28);
            numberTypeComboBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(10, 194);
            addButton.Name = "addButton";
            addButton.Size = new Size(122, 49);
            addButton.TabIndex = 3;
            addButton.Text = "Додавання";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(158, 194);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(122, 49);
            subtractButton.TabIndex = 4;
            subtractButton.Text = "Віднімання";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(10, 249);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(122, 49);
            multiplyButton.TabIndex = 5;
            multiplyButton.Text = "Множення";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(158, 249);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(122, 49);
            divideButton.TabIndex = 6;
            divideButton.Text = "Ділення";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(129, 152);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(50, 20);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 93);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 10;
            label3.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 312);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(numberTypeComboBox);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Форма";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox numberTypeComboBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private Label resultLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
