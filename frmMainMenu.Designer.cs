namespace Math_Quiz
{
    partial class frmMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numaricNumberOfQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbOperation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTimer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStartQuiz = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.numaricNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Questions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(73, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(97, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Timer:";
            // 
            // numaricNumberOfQuestions
            // 
            this.numaricNumberOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.numaricNumberOfQuestions.BorderColor = System.Drawing.Color.Gray;
            this.numaricNumberOfQuestions.BorderRadius = 17;
            this.numaricNumberOfQuestions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numaricNumberOfQuestions.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numaricNumberOfQuestions.Location = new System.Drawing.Point(271, 122);
            this.numaricNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numaricNumberOfQuestions.Name = "numaricNumberOfQuestions";
            this.numaricNumberOfQuestions.Size = new System.Drawing.Size(197, 36);
            this.numaricNumberOfQuestions.TabIndex = 5;
            this.numaricNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbLevel
            // 
            this.cbLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbLevel.BorderColor = System.Drawing.Color.Gray;
            this.cbLevel.BorderRadius = 17;
            this.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbLevel.ForeColor = System.Drawing.Color.Black;
            this.cbLevel.ItemHeight = 30;
            this.cbLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mixed"});
            this.cbLevel.Location = new System.Drawing.Point(271, 182);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(197, 36);
            this.cbLevel.StartIndex = 0;
            this.cbLevel.TabIndex = 6;
            // 
            // cbOperation
            // 
            this.cbOperation.BackColor = System.Drawing.Color.Transparent;
            this.cbOperation.BorderColor = System.Drawing.Color.Gray;
            this.cbOperation.BorderRadius = 17;
            this.cbOperation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOperation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbOperation.ForeColor = System.Drawing.Color.Black;
            this.cbOperation.ItemHeight = 30;
            this.cbOperation.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mixed"});
            this.cbOperation.Location = new System.Drawing.Point(271, 247);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(197, 36);
            this.cbOperation.StartIndex = 0;
            this.cbOperation.TabIndex = 7;
            // 
            // cbTimer
            // 
            this.cbTimer.BackColor = System.Drawing.Color.Transparent;
            this.cbTimer.BorderColor = System.Drawing.Color.Gray;
            this.cbTimer.BorderRadius = 17;
            this.cbTimer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTimer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbTimer.ForeColor = System.Drawing.Color.Black;
            this.cbTimer.ItemHeight = 30;
            this.cbTimer.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "5:00",
            "10:00",
            "15:00",
            "30:00"});
            this.cbTimer.Location = new System.Drawing.Point(271, 311);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(197, 36);
            this.cbTimer.StartIndex = 0;
            this.cbTimer.TabIndex = 8;
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BorderRadius = 22;
            this.btnStartQuiz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartQuiz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartQuiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartQuiz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartQuiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(295, 393);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(224, 45);
            this.btnStartQuiz.TabIndex = 9;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.numaricNumberOfQuestions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.numaricNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown numaricNumberOfQuestions;
        private Guna.UI2.WinForms.Guna2ComboBox cbLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cbOperation;
        private Guna.UI2.WinForms.Guna2ComboBox cbTimer;
        private Guna.UI2.WinForms.Guna2GradientButton btnStartQuiz;
    }
}