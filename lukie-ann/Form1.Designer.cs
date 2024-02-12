namespace lukie_ann
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
            label1 = new Label();
            addBtn = new Button();
            del_btn = new Button();
            button3 = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            dataGridView1 = new DataGridView();
            Customer = new DataGridViewTextBoxColumn();
            Loan = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cusID = new TextBox();
            loanID = new TextBox();
            loanAmt = new TextBox();
            loanDur = new TextBox();
            intRate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(181, 22);
            label1.Name = "label1";
            label1.Size = new Size(460, 36);
            label1.TabIndex = 0;
            label1.Text = "Lukie-Ann's Loan Management System";
            label1.Click += label1_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(43, 252);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add \r\n";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += button1_Click;
            // 
            // del_btn
            // 
            del_btn.Location = new Point(43, 295);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(75, 24);
            del_btn.TabIndex = 2;
            del_btn.Text = "Delete ";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(599, 450);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(43, 335);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(75, 23);
            editBtn.TabIndex = 4;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += button4_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(43, 379);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 5;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Customer, Loan, Amount, Duration, Rate });
            dataGridView1.Location = new Point(138, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(582, 242);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer I.D";
            Customer.Name = "Customer";
            Customer.Width = 110;
            // 
            // Loan
            // 
            Loan.HeaderText = "Loan I.D";
            Loan.Name = "Loan";
            Loan.Width = 110;
            // 
            // Amount
            // 
            Amount.HeaderText = "Loan Amount";
            Amount.Name = "Amount";
            Amount.Width = 110;
            // 
            // Duration
            // 
            Duration.HeaderText = "Loan Duration";
            Duration.Name = "Duration";
            Duration.Width = 110;
            // 
            // Rate
            // 
            Rate.HeaderText = "Interest Rate";
            Rate.Name = "Rate";
            Rate.Width = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(179, 89);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Customer I.D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(296, 89);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Loan I.D";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(406, 89);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "Loan Amount";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(512, 89);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 10;
            label5.Text = "Loan Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(619, 89);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "Interest Rate";
            // 
            // cusID
            // 
            cusID.Location = new Point(179, 107);
            cusID.Name = "cusID";
            cusID.Size = new Size(95, 23);
            cusID.TabIndex = 12;
            // 
            // loanID
            // 
            loanID.Location = new Point(296, 107);
            loanID.Name = "loanID";
            loanID.Size = new Size(78, 23);
            loanID.TabIndex = 13;
            // 
            // loanAmt
            // 
            loanAmt.Location = new Point(406, 107);
            loanAmt.Name = "loanAmt";
            loanAmt.Size = new Size(80, 23);
            loanAmt.TabIndex = 14;
            // 
            // loanDur
            // 
            loanDur.Location = new Point(512, 107);
            loanDur.Name = "loanDur";
            loanDur.Size = new Size(72, 23);
            loanDur.TabIndex = 15;
            // 
            // intRate
            // 
            intRate.Location = new Point(619, 107);
            intRate.Name = "intRate";
            intRate.Size = new Size(72, 23);
            intRate.TabIndex = 16;
            intRate.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(778, 499);
            Controls.Add(intRate);
            Controls.Add(loanDur);
            Controls.Add(loanAmt);
            Controls.Add(loanID);
            Controls.Add(cusID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(saveBtn);
            Controls.Add(editBtn);
            Controls.Add(button3);
            Controls.Add(del_btn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lukie-Ann";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addBtn;
        private Button del_btn;
        private Button button3;
        private Button editBtn;
        private Button saveBtn;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Loan;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Rate;
        private TextBox cusID;
        private TextBox loanID;
        private TextBox loanAmt;
        private TextBox loanDur;
        private TextBox intRate;
    }
}
