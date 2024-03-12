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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblYourRestulText = new System.Windows.Forms.Label();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.btnReturnToMainMenu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1444, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Math Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(127, 38);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(72, 32);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00:00";
            // 
            // btnFinish
            // 
            this.btnFinish.BorderRadius = 22;
            this.btnFinish.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinish.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinish.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(585, 910);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(248, 45);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finish Quiz";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // flpQuestions
            // 
            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.Location = new System.Drawing.Point(29, 81);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Size = new System.Drawing.Size(1406, 814);
            this.flpQuestions.TabIndex = 0;
            // 
            // lblYourRestulText
            // 
            this.lblYourRestulText.AutoSize = true;
            this.lblYourRestulText.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRestulText.Location = new System.Drawing.Point(1125, 31);
            this.lblYourRestulText.Name = "lblYourRestulText";
            this.lblYourRestulText.Size = new System.Drawing.Size(142, 32);
            this.lblYourRestulText.TabIndex = 11;
            this.lblYourRestulText.Text = "Your Result:";
            this.lblYourRestulText.Visible = false;
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestions.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(1322, 31);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(40, 32);
            this.lblNumberOfQuestions.TabIndex = 12;
            this.lblNumberOfQuestions.Text = "50";
            this.lblNumberOfQuestions.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblResult.Location = new System.Drawing.Point(1270, 31);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(27, 32);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "0";
            this.lblResult.Visible = false;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(1304, 31);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(24, 32);
            this.lblSlash.TabIndex = 14;
            this.lblSlash.Text = "/";
            this.lblSlash.Visible = false;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.BorderRadius = 22;
            this.btnReturnToMainMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnToMainMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnToMainMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnToMainMenu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnToMainMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReturnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1184, 910);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(256, 45);
            this.btnReturnToMainMenu.TabIndex = 15;
            this.btnReturnToMainMenu.Text = "Return to Main Menu";
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // frmMathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1447, 958);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.lblYourRestulText);
            this.Controls.Add(this.flpQuestions);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMathQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            this.Activated += new System.EventHandler(this.frmMathQuiz_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMathQuiz_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

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

