namespace Lab_2_GUI
{
    partial class Work_3_Task_13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previousButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 363);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(199, 75);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Первое";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка арифметики";
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(55, 69);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(567, 26);
            this.lineBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат выражения равен";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.Color.Blue;
            this.resultLabel.Location = new System.Drawing.Point(51, 172);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 20);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Результат";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(628, 21);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(141, 122);
            this.resultButton.TabIndex = 5;
            this.resultButton.Text = "Вычислить";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Второе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Work_3_Task_13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previousButton);
            this.Name = "Work_3_Task_13";
            this.Text = "Вычисления из строки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Work_3_Task_13_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button button1;
    }
}