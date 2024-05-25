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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numaricNumberOfQuestions = new Guna.UI2.WinForms.Guna2NumericUpDown();
            cbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            cbOperation = new Guna.UI2.WinForms.Guna2ComboBox();
            cbTimer = new Guna.UI2.WinForms.Guna2ComboBox();
            btnStartQuiz = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)numaricNumberOfQuestions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(799, 64);
            label1.TabIndex = 0;
            label1.Text = "Math Quiz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(253, 32);
            label2.TabIndex = 1;
            label2.Text = "Number of Questions:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(100, 182);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 2;
            label3.Text = "Level:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(73, 247);
            label4.Name = "label4";
            label4.Size = new Size(130, 32);
            label4.TabIndex = 3;
            label4.Text = "Operation:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(97, 311);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 4;
            label5.Text = "Timer:";
            // 
            // numaricNumberOfQuestions
            // 
            numaricNumberOfQuestions.BackColor = Color.Transparent;
            numaricNumberOfQuestions.BorderColor = Color.Gray;
            numaricNumberOfQuestions.BorderRadius = 17;
            numaricNumberOfQuestions.Cursor = Cursors.IBeam;
            numaricNumberOfQuestions.CustomizableEdges = customizableEdges1;
            numaricNumberOfQuestions.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numaricNumberOfQuestions.Location = new Point(271, 122);
            numaricNumberOfQuestions.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numaricNumberOfQuestions.Name = "numaricNumberOfQuestions";
            numaricNumberOfQuestions.ShadowDecoration.CustomizableEdges = customizableEdges2;
            numaricNumberOfQuestions.Size = new Size(197, 36);
            numaricNumberOfQuestions.TabIndex = 5;
            numaricNumberOfQuestions.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbLevel
            // 
            cbLevel.BackColor = Color.Transparent;
            cbLevel.BorderColor = Color.Gray;
            cbLevel.BorderRadius = 17;
            cbLevel.CustomizableEdges = customizableEdges3;
            cbLevel.DrawMode = DrawMode.OwnerDrawFixed;
            cbLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLevel.FocusedColor = Color.FromArgb(94, 148, 255);
            cbLevel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbLevel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cbLevel.ForeColor = Color.Black;
            cbLevel.ItemHeight = 30;
            cbLevel.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Mixed" });
            cbLevel.Location = new Point(271, 182);
            cbLevel.Name = "cbLevel";
            cbLevel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbLevel.Size = new Size(197, 36);
            cbLevel.StartIndex = 0;
            cbLevel.TabIndex = 6;
            // 
            // cbOperation
            // 
            cbOperation.BackColor = Color.Transparent;
            cbOperation.BorderColor = Color.Gray;
            cbOperation.BorderRadius = 17;
            cbOperation.CustomizableEdges = customizableEdges5;
            cbOperation.DrawMode = DrawMode.OwnerDrawFixed;
            cbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperation.FocusedColor = Color.FromArgb(94, 148, 255);
            cbOperation.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbOperation.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cbOperation.ForeColor = Color.Black;
            cbOperation.ItemHeight = 30;
            cbOperation.Items.AddRange(new object[] { "Addition", "Subtraction", "Multiplication", "Division", "Mixed" });
            cbOperation.Location = new Point(271, 247);
            cbOperation.Name = "cbOperation";
            cbOperation.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbOperation.Size = new Size(197, 36);
            cbOperation.StartIndex = 0;
            cbOperation.TabIndex = 7;
            // 
            // cbTimer
            // 
            cbTimer.BackColor = Color.Transparent;
            cbTimer.BorderColor = Color.Gray;
            cbTimer.BorderRadius = 17;
            cbTimer.CustomizableEdges = customizableEdges7;
            cbTimer.DrawMode = DrawMode.OwnerDrawFixed;
            cbTimer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTimer.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTimer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTimer.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cbTimer.ForeColor = Color.Black;
            cbTimer.ItemHeight = 30;
            cbTimer.Items.AddRange(new object[] { "1:00", "2:00", "5:00", "10:00", "15:00", "30:00" });
            cbTimer.Location = new Point(271, 311);
            cbTimer.Name = "cbTimer";
            cbTimer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbTimer.Size = new Size(197, 36);
            cbTimer.StartIndex = 0;
            cbTimer.TabIndex = 8;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BorderRadius = 22;
            btnStartQuiz.CustomizableEdges = customizableEdges9;
            btnStartQuiz.DisabledState.BorderColor = Color.DarkGray;
            btnStartQuiz.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStartQuiz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStartQuiz.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnStartQuiz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStartQuiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.ForeColor = Color.White;
            btnStartQuiz.Location = new Point(295, 393);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnStartQuiz.Size = new Size(224, 45);
            btnStartQuiz.TabIndex = 9;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStartQuiz);
            Controls.Add(cbTimer);
            Controls.Add(cbOperation);
            Controls.Add(cbLevel);
            Controls.Add(numaricNumberOfQuestions);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkSlateGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)numaricNumberOfQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
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