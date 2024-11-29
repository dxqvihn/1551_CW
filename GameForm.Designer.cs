namespace WindowsFormsApp_CW
{
    partial class GameForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rbtnOption4 = new System.Windows.Forms.RadioButton();
            this.rbtnOption3 = new System.Windows.Forms.RadioButton();
            this.rbtnOption2 = new System.Windows.Forms.RadioButton();
            this.rbtnOption1 = new System.Windows.Forms.RadioButton();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.lbPlName = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Geography Quiz Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Green;
            this.lblScore.Location = new System.Drawing.Point(653, 70);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(123, 41);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(61, 93);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(500, 100);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "What is the capital of Vietnam?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rbtnOption4);
            this.grpOptions.Controls.Add(this.rbtnOption3);
            this.grpOptions.Controls.Add(this.rbtnOption2);
            this.grpOptions.Controls.Add(this.rbtnOption1);
            this.grpOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(100, 208);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(400, 150);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Select your answer";
            this.grpOptions.Enter += new System.EventHandler(this.grpOptions_Enter);
            // 
            // rbtnOption4
            // 
            this.rbtnOption4.AutoSize = true;
            this.rbtnOption4.Location = new System.Drawing.Point(20, 120);
            this.rbtnOption4.Name = "rbtnOption4";
            this.rbtnOption4.Size = new System.Drawing.Size(103, 20);
            this.rbtnOption4.TabIndex = 3;
            this.rbtnOption4.TabStop = true;
            this.rbtnOption4.Text = "radioButton4";
            this.rbtnOption4.UseVisualStyleBackColor = true;
            this.rbtnOption4.CheckedChanged += new System.EventHandler(this.rbtnOption4_CheckedChanged);
            // 
            // rbtnOption3
            // 
            this.rbtnOption3.AutoSize = true;
            this.rbtnOption3.Location = new System.Drawing.Point(20, 90);
            this.rbtnOption3.Name = "rbtnOption3";
            this.rbtnOption3.Size = new System.Drawing.Size(103, 20);
            this.rbtnOption3.TabIndex = 2;
            this.rbtnOption3.TabStop = true;
            this.rbtnOption3.Text = "radioButton3";
            this.rbtnOption3.UseVisualStyleBackColor = true;
            this.rbtnOption3.CheckedChanged += new System.EventHandler(this.rbtnOption3_CheckedChanged);
            // 
            // rbtnOption2
            // 
            this.rbtnOption2.AutoSize = true;
            this.rbtnOption2.Location = new System.Drawing.Point(20, 60);
            this.rbtnOption2.Name = "rbtnOption2";
            this.rbtnOption2.Size = new System.Drawing.Size(103, 20);
            this.rbtnOption2.TabIndex = 1;
            this.rbtnOption2.TabStop = true;
            this.rbtnOption2.Text = "radioButton2";
            this.rbtnOption2.UseVisualStyleBackColor = true;
            this.rbtnOption2.CheckedChanged += new System.EventHandler(this.rbtnOption2_CheckedChanged);
            // 
            // rbtnOption1
            // 
            this.rbtnOption1.AutoSize = true;
            this.rbtnOption1.Location = new System.Drawing.Point(20, 30);
            this.rbtnOption1.Name = "rbtnOption1";
            this.rbtnOption1.Size = new System.Drawing.Size(103, 20);
            this.rbtnOption1.TabIndex = 0;
            this.rbtnOption1.TabStop = true;
            this.rbtnOption1.Text = "radioButton1";
            this.rbtnOption1.UseVisualStyleBackColor = true;
            this.rbtnOption1.CheckedChanged += new System.EventHandler(this.rbtnOption1_CheckedChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(100, 364);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(400, 61);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(100, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.Crimson;
            this.btnStartOver.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.ForeColor = System.Drawing.Color.White;
            this.btnStartOver.Location = new System.Drawing.Point(100, 500);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(200, 50);
            this.btnStartOver.TabIndex = 6;
            this.btnStartOver.Text = "StartOver";
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // lbPlName
            // 
            this.lbPlName.AutoSize = true;
            this.lbPlName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbPlName.Location = new System.Drawing.Point(653, 13);
            this.lbPlName.Name = "lbPlName";
            this.lbPlName.Size = new System.Drawing.Size(111, 41);
            this.lbPlName.TabIndex = 7;
            this.lbPlName.Text = "Hello! ";
            this.lbPlName.TextChanged += new System.EventHandler(this.lblPlayerName_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 583);
            this.Controls.Add(this.lbPlName);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rbtnOption4;
        private System.Windows.Forms.RadioButton rbtnOption3;
        private System.Windows.Forms.RadioButton rbtnOption2;
        private System.Windows.Forms.RadioButton rbtnOption1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Label lbPlName;
    }
}