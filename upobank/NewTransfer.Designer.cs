namespace upobank
{
    partial class NewTransfer
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
            sourceTextBox = new TextBox();
            targetTextBox = new TextBox();
            amountTextBox = new TextBox();
            MakeTransferButton = new Button();
            SuspendLayout();
            // 
            // sourceTextBox
            // 
            sourceTextBox.Location = new Point(213, 91);
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.Size = new Size(100, 23);
            sourceTextBox.TabIndex = 0;
            // 
            // targetTextBox
            // 
            targetTextBox.Location = new Point(213, 120);
            targetTextBox.Name = "targetTextBox";
            targetTextBox.Size = new Size(100, 23);
            targetTextBox.TabIndex = 1;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(213, 149);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 3;
            // 
            // MakeTransferButton
            // 
            MakeTransferButton.Location = new Point(223, 191);
            MakeTransferButton.Name = "MakeTransferButton";
            MakeTransferButton.Size = new Size(102, 23);
            MakeTransferButton.TabIndex = 4;
            MakeTransferButton.Text = "Zrób przelew";
            MakeTransferButton.UseVisualStyleBackColor = true;
            MakeTransferButton.Click += MakeTransferButton_Click;
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MakeTransferButton);
            Controls.Add(amountTextBox);
            Controls.Add(targetTextBox);
            Controls.Add(sourceTextBox);
            Name = "NewTransfer";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sourceTextBox;
        private TextBox targetTextBox;
        private TextBox amountTextBox;
        private Button MakeTransferButton;
    }
}