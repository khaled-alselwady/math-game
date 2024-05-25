namespace Math_Quiz
{
    partial class frmMathQuiz
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnFinish = new Guna.UI2.WinForms.Guna2GradientButton();
            flpQuestions = new FlowLayoutPanel();
            lblYourRestulText = new Label();
            lblNumberOfQuestions = new Label();
            lblResult = new Label();
            lblSlash = new Label();
            btnReturnToMainMenu = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 5);
            label1.Name = "label1";
            label1.Size = new Size(1444, 65);
            label1.TabIndex = 1;
            label1.Text = "Math Quiz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(127, 38);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(72, 32);
            lblTimer.TabIndex = 3;
            lblTimer.Text = "00:00";
            // 
            // btnFinish
            // 
            btnFinish.BorderRadius = 22;
            btnFinish.CustomizableEdges = customizableEdges1;
            btnFinish.DisabledState.BorderColor = Color.DarkGray;
            btnFinish.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFinish.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFinish.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnFinish.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFinish.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnFinish.ForeColor = Color.White;
            btnFinish.Location = new Point(585, 910);
            btnFinish.Name = "btnFinish";
            btnFinish.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnFinish.Size = new Size(248, 45);
            btnFinish.TabIndex = 10;
            btnFinish.Text = "Finish Quiz";
            btnFinish.Click += btnFinish_Click;
            // 
            // flpQuestions
            // 
            flpQuestions.AutoScroll = true;
            flpQuestions.Location = new Point(29, 81);
            flpQuestions.Name = "flpQuestions";
            flpQuestions.Size = new Size(1406, 814);
            flpQuestions.TabIndex = 0;
            // 
            // lblYourRestulText
            // 
            lblYourRestulText.AutoSize = true;
            lblYourRestulText.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYourRestulText.Location = new Point(1125, 31);
            lblYourRestulText.Name = "lblYourRestulText";
            lblYourRestulText.Size = new Size(142, 32);
            lblYourRestulText.TabIndex = 11;
            lblYourRestulText.Text = "Your Result:";
            lblYourRestulText.Visible = false;
            // 
            // lblNumberOfQuestions
            // 
            lblNumberOfQuestions.AutoSize = true;
            lblNumberOfQuestions.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfQuestions.ForeColor = Color.Black;
            lblNumberOfQuestions.Location = new Point(1322, 31);
            lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            lblNumberOfQuestions.Size = new Size(40, 32);
            lblNumberOfQuestions.TabIndex = 12;
            lblNumberOfQuestions.Text = "50";
            lblNumberOfQuestions.Visible = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.LimeGreen;
            lblResult.Location = new Point(1270, 31);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(27, 32);
            lblResult.TabIndex = 13;
            lblResult.Text = "0";
            lblResult.Visible = false;
            // 
            // lblSlash
            // 
            lblSlash.AutoSize = true;
            lblSlash.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSlash.Location = new Point(1304, 31);
            lblSlash.Name = "lblSlash";
            lblSlash.Size = new Size(24, 32);
            lblSlash.TabIndex = 14;
            lblSlash.Text = "/";
            lblSlash.Visible = false;
            // 
            // btnReturnToMainMenu
            // 
            btnReturnToMainMenu.BorderRadius = 22;
            btnReturnToMainMenu.CustomizableEdges = customizableEdges3;
            btnReturnToMainMenu.DisabledState.BorderColor = Color.DarkGray;
            btnReturnToMainMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReturnToMainMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReturnToMainMenu.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnReturnToMainMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReturnToMainMenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnReturnToMainMenu.ForeColor = Color.White;
            btnReturnToMainMenu.Location = new Point(1184, 910);
            btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            btnReturnToMainMenu.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnReturnToMainMenu.Size = new Size(256, 45);
            btnReturnToMainMenu.TabIndex = 15;
            btnReturnToMainMenu.Text = "Return to Main Menu";
            btnReturnToMainMenu.Click += btnReturnToMainMenu_Click;
            // 
            // frmMathQuiz
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1447, 958);
            Controls.Add(btnReturnToMainMenu);
            Controls.Add(lblSlash);
            Controls.Add(lblResult);
            Controls.Add(lblNumberOfQuestions);
            Controls.Add(lblYourRestulText);
            Controls.Add(flpQuestions);
            Controls.Add(btnFinish);
            Controls.Add(lblTimer);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMathQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Quiz";
            Activated += frmMathQuiz_Activated;
            FormClosing += frmMathQuiz_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinish;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
        private System.Windows.Forms.Label lblYourRestulText;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSlash;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturnToMainMenu;
    }
}

