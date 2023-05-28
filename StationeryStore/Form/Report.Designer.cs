namespace StationeryStore
{
    partial class Report
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAllLeft = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.BtAllRight = new System.Windows.Forms.Button();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAlphabetZ = new System.Windows.Forms.RadioButton();
            this.radioButtonAlphabetA = new System.Windows.Forms.RadioButton();
            this.radioButtondescending = new System.Windows.Forms.RadioButton();
            this.radioButtonAscending = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры запроса";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxChoice);
            this.groupBox5.Location = new System.Drawing.Point(7, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 79);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поле для сортировки";
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Location = new System.Drawing.Point(8, 28);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(406, 29);
            this.comboBoxChoice.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonAllLeft);
            this.groupBox4.Controls.Add(this.buttonLeft);
            this.groupBox4.Controls.Add(this.buttonRight);
            this.groupBox4.Controls.Add(this.BtAllRight);
            this.groupBox4.Controls.Add(this.listBoxRight);
            this.groupBox4.Controls.Add(this.listBoxLeft);
            this.groupBox4.Location = new System.Drawing.Point(452, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(711, 285);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поля таблицы (Для выбора необходимо воспользоваться кнопками переноса)";
            // 
            // buttonAllLeft
            // 
            this.buttonAllLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAllLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllLeft.Location = new System.Drawing.Point(310, 221);
            this.buttonAllLeft.Name = "buttonAllLeft";
            this.buttonAllLeft.Size = new System.Drawing.Size(91, 41);
            this.buttonAllLeft.TabIndex = 26;
            this.buttonAllLeft.Text = "<<";
            this.buttonAllLeft.UseVisualStyleBackColor = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Location = new System.Drawing.Point(310, 157);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(91, 41);
            this.buttonLeft.TabIndex = 25;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(310, 93);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(91, 41);
            this.buttonRight.TabIndex = 24;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            // 
            // BtAllRight
            // 
            this.BtAllRight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtAllRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAllRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAllRight.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtAllRight.Location = new System.Drawing.Point(310, 29);
            this.BtAllRight.Name = "BtAllRight";
            this.BtAllRight.Size = new System.Drawing.Size(91, 41);
            this.BtAllRight.TabIndex = 23;
            this.BtAllRight.Text = ">>";
            this.BtAllRight.UseVisualStyleBackColor = false;
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.ItemHeight = 21;
            this.listBoxRight.Location = new System.Drawing.Point(431, 28);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(272, 235);
            this.listBoxRight.TabIndex = 1;
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.ItemHeight = 21;
            this.listBoxLeft.Location = new System.Drawing.Point(8, 29);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(272, 235);
            this.listBoxLeft.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAlphabetZ);
            this.groupBox3.Controls.Add(this.radioButtonAlphabetA);
            this.groupBox3.Controls.Add(this.radioButtondescending);
            this.groupBox3.Controls.Add(this.radioButtonAscending);
            this.groupBox3.Location = new System.Drawing.Point(7, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сотрировка полей таблицы";
            // 
            // radioButtonAlphabetZ
            // 
            this.radioButtonAlphabetZ.AutoSize = true;
            this.radioButtonAlphabetZ.Location = new System.Drawing.Point(212, 73);
            this.radioButtonAlphabetZ.Name = "radioButtonAlphabetZ";
            this.radioButtonAlphabetZ.Size = new System.Drawing.Size(190, 25);
            this.radioButtonAlphabetZ.TabIndex = 6;
            this.radioButtonAlphabetZ.TabStop = true;
            this.radioButtonAlphabetZ.Text = "По алфавиту (Я-А)";
            this.radioButtonAlphabetZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlphabetA
            // 
            this.radioButtonAlphabetA.AutoSize = true;
            this.radioButtonAlphabetA.Location = new System.Drawing.Point(9, 73);
            this.radioButtonAlphabetA.Name = "radioButtonAlphabetA";
            this.radioButtonAlphabetA.Size = new System.Drawing.Size(190, 25);
            this.radioButtonAlphabetA.TabIndex = 5;
            this.radioButtonAlphabetA.TabStop = true;
            this.radioButtonAlphabetA.Text = "По алфавиту (А-Я)";
            this.radioButtonAlphabetA.UseVisualStyleBackColor = true;
            // 
            // radioButtondescending
            // 
            this.radioButtondescending.AutoSize = true;
            this.radioButtondescending.Location = new System.Drawing.Point(212, 28);
            this.radioButtondescending.Name = "radioButtondescending";
            this.radioButtondescending.Size = new System.Drawing.Size(148, 25);
            this.radioButtondescending.TabIndex = 4;
            this.radioButtondescending.TabStop = true;
            this.radioButtondescending.Text = "По убыванию";
            this.radioButtondescending.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscending
            // 
            this.radioButtonAscending.AutoSize = true;
            this.radioButtonAscending.Location = new System.Drawing.Point(9, 28);
            this.radioButtonAscending.Name = "radioButtonAscending";
            this.radioButtonAscending.Size = new System.Drawing.Size(171, 25);
            this.radioButtonAscending.TabIndex = 3;
            this.radioButtonAscending.TabStop = true;
            this.radioButtonAscending.Text = "По возрастанию";
            this.radioButtonAscending.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTable);
            this.groupBox2.Location = new System.Drawing.Point(7, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 78);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор таблицы из БД";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(8, 28);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(399, 29);
            this.comboBoxTable.TabIndex = 0;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Location = new System.Drawing.Point(14, 365);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1169, 305);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Таблица";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.Location = new System.Drawing.Point(27, 676);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(260, 41);
            this.buttonExecute.TabIndex = 27;
            this.buttonExecute.Text = "Выполнить";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(321, 676);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(260, 41);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonWord
            // 
            this.buttonWord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWord.Location = new System.Drawing.Point(615, 676);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(260, 41);
            this.buttonWord.TabIndex = 29;
            this.buttonWord.Text = "Экспорт в Microsoft Word";
            this.buttonWord.UseVisualStyleBackColor = false;
            // 
            // buttonExcel
            // 
            this.buttonExcel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel.Location = new System.Drawing.Point(909, 676);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(260, 41);
            this.buttonExcel.TabIndex = 30;
            this.buttonExcel.Text = "Экспорт в Microsoft Excel";
            this.buttonExcel.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 726);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Report";
            this.Text = "Конструктор запросов";
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtondescending;
        private System.Windows.Forms.RadioButton radioButtonAscending;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonAlphabetZ;
        private System.Windows.Forms.RadioButton radioButtonAlphabetA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAllLeft;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button BtAllRight;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonExcel;
    }
}