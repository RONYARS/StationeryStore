namespace StationeryStore
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.CmEmployeeCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtEnter
            // 
            this.BtEnter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEnter.Location = new System.Drawing.Point(18, 167);
            this.BtEnter.Name = "BtEnter";
            this.BtEnter.Size = new System.Drawing.Size(223, 30);
            this.BtEnter.TabIndex = 0;
            this.BtEnter.Text = "Войти";
            this.BtEnter.UseVisualStyleBackColor = false;
            this.BtEnter.Click += new System.EventHandler(this.BtEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // TbPassword
            // 
            this.TbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPassword.Location = new System.Drawing.Point(18, 121);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(223, 29);
            this.TbPassword.TabIndex = 4;
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAuthorization.Location = new System.Drawing.Point(68, 9);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(121, 21);
            this.labelAuthorization.TabIndex = 5;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // CmEmployeeCode
            // 
            this.CmEmployeeCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmEmployeeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmEmployeeCode.FormattingEnabled = true;
            this.CmEmployeeCode.Location = new System.Drawing.Point(18, 65);
            this.CmEmployeeCode.Name = "CmEmployeeCode";
            this.CmEmployeeCode.Size = new System.Drawing.Size(223, 29);
            this.CmEmployeeCode.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AcceptButton = this.BtEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 211);
            this.Controls.Add(this.CmEmployeeCode);
            this.Controls.Add(this.labelAuthorization);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtEnter);
            this.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(270, 250);
            this.MinimumSize = new System.Drawing.Size(270, 250);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.ComboBox CmEmployeeCode;
    }
}

