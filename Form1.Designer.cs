namespace Craps1
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
            lblDice1 = new Label();
            lblDice2 = new Label();
            lblBankBalance = new Label();
            txtBoxBet = new TextBox();
            btnRoll = new Button();
            lblWin = new Label();
            lblLose = new Label();
            lblPoint = new Label();
            SuspendLayout();
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDice1.Location = new Point(12, 9);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(74, 38);
            lblDice1.TabIndex = 0;
            lblDice1.Text = "Dice";
            lblDice1.Visible = false;
            lblDice1.Click += lblDice1_Click;
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDice2.Location = new Point(12, 56);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(74, 38);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "Dice";
            lblDice2.Visible = false;
            lblDice2.Click += lblDice2_Click;
            // 
            // lblBankBalance
            // 
            lblBankBalance.AutoSize = true;
            lblBankBalance.Location = new Point(12, 314);
            lblBankBalance.Name = "lblBankBalance";
            lblBankBalance.Size = new Size(147, 20);
            lblBankBalance.TabIndex = 2;
            lblBankBalance.Text = "Bank Balance = $100";
            lblBankBalance.Click += lbl3_Click;
            // 
            // txtBoxBet
            // 
            txtBoxBet.Location = new Point(12, 174);
            txtBoxBet.Name = "txtBoxBet";
            txtBoxBet.Size = new Size(125, 27);
            txtBoxBet.TabIndex = 3;
            txtBoxBet.Text = "Place Your Bets:";
            txtBoxBet.TextChanged += textBox1_TextChanged;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRoll.Location = new Point(12, 113);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(101, 55);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Location = new Point(12, 358);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(67, 20);
            lblWin.TabIndex = 5;
            lblWin.Text = "You Win!";
            lblWin.Visible = false;
            lblWin.Click += lblWin_Click;
            // 
            // lblLose
            // 
            lblLose.AutoSize = true;
            lblLose.Location = new Point(12, 378);
            lblLose.Name = "lblLose";
            lblLose.Size = new Size(71, 20);
            lblLose.TabIndex = 6;
            lblLose.Text = "You Lose!";
            lblLose.Visible = false;
            lblLose.Click += lblLose_Click;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(19, 398);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(60, 20);
            lblPoint.TabIndex = 7;
            lblPoint.Text = "Point is ";
            lblPoint.Visible = false;
            lblPoint.Click += lblPoint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPoint);
            Controls.Add(lblLose);
            Controls.Add(lblWin);
            Controls.Add(btnRoll);
            Controls.Add(txtBoxBet);
            Controls.Add(lblBankBalance);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBankBalance;
        private TextBox txtBoxBet;
        private Button btnRoll;
        private Label lblWin;
        private Label lblLose;
        private Label lblPoint;
    }
}
