namespace bartolome
{
    partial class Receipt
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
            lblChange = new Label();
            lblReceiptVAT = new Label();
            label4 = new Label();
            label3 = new Label();
            button3 = new Button();
            btnPurchase = new Button();
            lblReceiptTotal = new Label();
            l = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            lblReceiptCash = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(170, 222);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(23, 17);
            lblChange.TabIndex = 21;
            lblChange.Text = "---";
            // 
            // lblReceiptVAT
            // 
            lblReceiptVAT.AutoSize = true;
            lblReceiptVAT.Location = new Point(170, 123);
            lblReceiptVAT.Name = "lblReceiptVAT";
            lblReceiptVAT.Size = new Size(23, 17);
            lblReceiptVAT.TabIndex = 20;
            lblReceiptVAT.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 216);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 19;
            label4.Text = "Change:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 119);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 18;
            label3.Text = "VAT:";
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sitka Small", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(170, 267);
            button3.Name = "button3";
            button3.Size = new Size(114, 43);
            button3.TabIndex = 17;
            button3.Text = "Void Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Green;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Sitka Small", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(34, 267);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(114, 42);
            btnPurchase.TabIndex = 16;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += button1_Click;
            // 
            // lblReceiptTotal
            // 
            lblReceiptTotal.AutoSize = true;
            lblReceiptTotal.Location = new Point(170, 74);
            lblReceiptTotal.Name = "lblReceiptTotal";
            lblReceiptTotal.Size = new Size(23, 17);
            lblReceiptTotal.TabIndex = 14;
            lblReceiptTotal.Text = "---";
            lblReceiptTotal.Click += lblReceiptTotal_Click;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Sitka Small", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l.Location = new Point(75, 171);
            l.Name = "l";
            l.Size = new Size(53, 23);
            l.TabIndex = 13;
            l.Text = "Cash:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 12;
            label1.Text = "Total:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-40, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 27);
            panel1.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(326, 2);
            button2.Name = "button2";
            button2.Size = new Size(39, 26);
            button2.TabIndex = 8;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblReceiptCash
            // 
            lblReceiptCash.AutoSize = true;
            lblReceiptCash.Location = new Point(170, 175);
            lblReceiptCash.Name = "lblReceiptCash";
            lblReceiptCash.Size = new Size(23, 17);
            lblReceiptCash.TabIndex = 23;
            lblReceiptCash.Text = "---";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Small", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(100, 316);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 24;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 372);
            Controls.Add(button1);
            Controls.Add(lblReceiptCash);
            Controls.Add(panel1);
            Controls.Add(lblChange);
            Controls.Add(lblReceiptVAT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(btnPurchase);
            Controls.Add(lblReceiptTotal);
            Controls.Add(l);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChange;
        private Label lblReceiptVAT;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button btnPurchase;
        private Label lblReceiptTotal;
        private Label l;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private Label lblReceiptCash;
        private Button button1;
    }
}