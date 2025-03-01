
namespace MERC_P4NL
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btn_Login = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackgroundImageLayout = ImageLayout.None;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Lucida Console", 13F);
            btn_Login.ForeColor = Color.FromArgb(5, 217, 7);
            btn_Login.Location = new Point(49, 433);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(284, 32);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.FromArgb(5, 217, 7);
            txtUsername.Location = new Point(49, 290);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.FromArgb(5, 217, 7);
            txtPassword.Location = new Point(49, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '#';
            txtPassword.Size = new Size(284, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 13F);
            label1.ForeColor = Color.FromArgb(5, 217, 7);
            label1.Location = new Point(49, 264);
            label1.Name = "label1";
            label1.Size = new Size(173, 18);
            label1.TabIndex = 3;
            label1.Text = "Employee Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 13F);
            label2.ForeColor = Color.FromArgb(5, 217, 7);
            label2.Location = new Point(49, 322);
            label2.Name = "label2";
            label2.Size = new Size(96, 18);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 20F);
            label3.ForeColor = Color.FromArgb(5, 217, 7);
            label3.Location = new Point(49, 0);
            label3.Name = "label3";
            label3.Size = new Size(284, 20);
            label3.TabIndex = 5;
            label3.Text = "WELCOME MERCENARY";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.11041F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.77863F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1109514F));
            tableLayoutPanel1.Controls.Add(btn_Login, 1, 6);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 5);
            tableLayoutPanel1.Controls.Add(label2, 1, 4);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 7);
            tableLayoutPanel1.Location = new Point(12, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2930756F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.6931963F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.17345476F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.842862F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.99871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.99871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(383, 537);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 13F);
            label4.ForeColor = Color.FromArgb(5, 217, 7);
            label4.Location = new Point(49, 514);
            label4.Name = "label4";
            label4.Size = new Size(162, 18);
            label4.TabIndex = 7;
            label4.Text = "Please wait...";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(407, 596);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Text = "MERC-P4NL";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        

        #endregion

        private Button btn_Login;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
    }
}
