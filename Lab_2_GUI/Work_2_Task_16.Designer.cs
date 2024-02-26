namespace Lab_2_GUI
{
    partial class Work_2_Task_16
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
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 356);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(171, 82);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Предыдущее";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(617, 356);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(171, 82);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Следующее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размеры прямоугольника";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(41, 58);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 26);
            this.widthBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "на";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(231, 61);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 26);
            this.heightBox.TabIndex = 5;
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(446, 17);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(135, 94);
            this.resultButton.TabIndex = 6;
            this.resultButton.Text = "Получить квадраты";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.ForeColor = System.Drawing.Color.Blue;
            this.resultLabel.Location = new System.Drawing.Point(173, 199);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 20);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат";
            // 
            // Work_2_Task_16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Name = "Work_2_Task_16";
            this.Text = "Квадраты из Прямоугольника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Work_2_Task_16_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
    }
}