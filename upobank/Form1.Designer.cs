namespace upobank
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
            AccountNameTextBox = new TextBox();
            AccountNumberTextBox = new TextBox();
            AccountAmountTextBox = new TextBox();
            tokenTextBox = new TextBox();
            newTransferButton = new Button();
            SuspendLayout();
            // 
            // AccountNameTextBox
            // 
            AccountNameTextBox.Location = new Point(212, 176);
            AccountNameTextBox.Name = "AccountNameTextBox";
            AccountNameTextBox.Size = new Size(100, 23);
            AccountNameTextBox.TabIndex = 0;
            // 
            // AccountNumberTextBox
            // 
            AccountNumberTextBox.Location = new Point(212, 205);
            AccountNumberTextBox.Name = "AccountNumberTextBox";
            AccountNumberTextBox.Size = new Size(100, 23);
            AccountNumberTextBox.TabIndex = 1;
            // 
            // AccountAmountTextBox
            // 
            AccountAmountTextBox.Location = new Point(212, 234);
            AccountAmountTextBox.Name = "AccountAmountTextBox";
            AccountAmountTextBox.Size = new Size(100, 23);
            AccountAmountTextBox.TabIndex = 2;
            // 
            // tokenTextBox
            // 
            tokenTextBox.Location = new Point(212, 263);
            tokenTextBox.Name = "tokenTextBox";
            tokenTextBox.Size = new Size(100, 23);
            tokenTextBox.TabIndex = 3;
            // 
            // newTransferButton
            // 
            newTransferButton.Location = new Point(237, 292);
            newTransferButton.Name = "newTransferButton";
            newTransferButton.Size = new Size(75, 23);
            newTransferButton.TabIndex = 4;
            newTransferButton.Text = "Nowy przelew";
            newTransferButton.UseVisualStyleBackColor = true;
            newTransferButton.Click += newTransferButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newTransferButton);
            Controls.Add(tokenTextBox);
            Controls.Add(AccountAmountTextBox);
            Controls.Add(AccountNumberTextBox);
            Controls.Add(AccountNameTextBox);
            Name = "Form1";
            Text = "Upobank - zalogowano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AccountNameTextBox;
        private TextBox AccountNumberTextBox;
        private TextBox AccountAmountTextBox;
        private TextBox tokenTextBox;
        private Button newTransferButton;
    }
}
