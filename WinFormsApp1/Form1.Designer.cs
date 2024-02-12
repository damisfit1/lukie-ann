namespace WinFormsApp1
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
            addloan = new Button();
            dloan = new Button();
            edloan = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // addloan
            // 
            addloan.BackColor = SystemColors.ActiveCaption;
            addloan.Location = new Point(83, 385);
            addloan.Name = "addloan";
            addloan.Size = new Size(89, 31);
            addloan.TabIndex = 0;
            addloan.Text = "Add Loan";
            addloan.UseVisualStyleBackColor = false;
            addloan.Click += button1_Click;
            // 
            // dloan
            // 
            dloan.BackColor = SystemColors.ActiveCaption;
            dloan.Location = new Point(306, 385);
            dloan.Name = "dloan";
            dloan.Size = new Size(86, 31);
            dloan.TabIndex = 1;
            dloan.Text = "Delete Loan";
            dloan.UseVisualStyleBackColor = false;
            dloan.Click += button2_Click;
            // 
            // edloan
            // 
            edloan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            edloan.BackColor = SystemColors.ActiveCaption;
            edloan.Location = new Point(555, 385);
            edloan.Name = "edloan";
            edloan.Size = new Size(79, 31);
            edloan.TabIndex = 2;
            edloan.Text = "Edit Loan";
            edloan.UseVisualStyleBackColor = false;
            edloan.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(118, 59);
            label1.Name = "label1";
            label1.Size = new Size(460, 36);
            label1.TabIndex = 3;
            label1.Text = "Lukie-Ann's Loan Management System\r\n";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(726, 470);
            Controls.Add(label1);
            Controls.Add(edloan);
            Controls.Add(dloan);
            Controls.Add(addloan);
            Name = "Form1";
            Text = "Manage Loans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addloan;
        private Button dloan;
        private Button edloan;
        private Label label1;
    }
}
