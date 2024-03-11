namespace WinFormsApp1
{
    partial class MainForm
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
            btnCheckOut = new Button();
            grpCheckOut = new GroupBox();
            txtPayment = new TextBox();
            lblPayment = new Label();
            lblPrize = new Label();
            txtPrize = new TextBox();
            grpChange = new GroupBox();
            listboxChange = new ListBox();
            btnExit = new Button();
            grpCheckOut.SuspendLayout();
            grpChange.SuspendLayout();
            SuspendLayout();
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(81, 103);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(75, 23);
            btnCheckOut.TabIndex = 0;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // grpCheckOut
            // 
            grpCheckOut.Controls.Add(txtPayment);
            grpCheckOut.Controls.Add(lblPayment);
            grpCheckOut.Controls.Add(lblPrize);
            grpCheckOut.Controls.Add(txtPrize);
            grpCheckOut.Controls.Add(btnCheckOut);
            grpCheckOut.Location = new Point(54, 25);
            grpCheckOut.Name = "grpCheckOut";
            grpCheckOut.Size = new Size(243, 154);
            grpCheckOut.TabIndex = 1;
            grpCheckOut.TabStop = false;
            grpCheckOut.Text = "Check Out";
            // 
            // txtPayment
            // 
            txtPayment.Location = new Point(99, 61);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(100, 23);
            txtPayment.TabIndex = 4;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(21, 64);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(54, 15);
            lblPayment.TabIndex = 2;
            lblPayment.Text = "Payment";
            // 
            // lblPrize
            // 
            lblPrize.AutoSize = true;
            lblPrize.Location = new Point(21, 28);
            lblPrize.Name = "lblPrize";
            lblPrize.Size = new Size(32, 15);
            lblPrize.TabIndex = 1;
            lblPrize.Text = "Prize";
            // 
            // txtPrize
            // 
            txtPrize.Location = new Point(99, 25);
            txtPrize.Name = "txtPrize";
            txtPrize.Size = new Size(100, 23);
            txtPrize.TabIndex = 3;
            // 
            // grpChange
            // 
            grpChange.Controls.Add(listboxChange);
            grpChange.Location = new Point(54, 185);
            grpChange.Name = "grpChange";
            grpChange.Size = new Size(243, 224);
            grpChange.TabIndex = 2;
            grpChange.TabStop = false;
            grpChange.Text = "Change";
            // 
            // listboxChange
            // 
            listboxChange.FormattingEnabled = true;
            listboxChange.ItemHeight = 15;
            listboxChange.Location = new Point(33, 31);
            listboxChange.Name = "listboxChange";
            listboxChange.Size = new Size(178, 154);
            listboxChange.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(176, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 464);
            Controls.Add(btnExit);
            Controls.Add(grpChange);
            Controls.Add(grpCheckOut);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check Out Calculator";
            grpCheckOut.ResumeLayout(false);
            grpCheckOut.PerformLayout();
            grpChange.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckOut;
        private GroupBox grpCheckOut;
        private Label lblPayment;
        private Label lblPrize;
        private TextBox txtPrize;
        private TextBox txtPayment;
        private GroupBox grpChange;
        private ListBox listboxChange;
        private Button btnExit;
    }
}
