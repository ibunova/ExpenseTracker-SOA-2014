namespace ExpenseTracker.Desktop
{
    partial class FormExpenses
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
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.groupBoxNewExpense = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxExpenseList = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelDromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxNewExpense.SuspendLayout();
            this.groupBoxExpenseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            this.labelDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(70, 26);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 58);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(70, 58);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(106, 20);
            this.textBoxAmount.TabIndex = 3;
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "BGN",
            "EUR",
            "USD"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(185, 58);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(59, 21);
            this.comboBoxCurrency.TabIndex = 4;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(6, 104);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(41, 13);
            this.labelNotes.TabIndex = 5;
            this.labelNotes.Text = "Notes: ";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(64, 101);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(191, 94);
            this.textBoxNotes.TabIndex = 6;
            // 
            // groupBoxNewExpense
            // 
            this.groupBoxNewExpense.Controls.Add(this.buttonSave);
            this.groupBoxNewExpense.Controls.Add(this.textBoxNotes);
            this.groupBoxNewExpense.Controls.Add(this.labelNotes);
            this.groupBoxNewExpense.Controls.Add(this.comboBoxCurrency);
            this.groupBoxNewExpense.Controls.Add(this.textBoxAmount);
            this.groupBoxNewExpense.Controls.Add(this.labelAmount);
            this.groupBoxNewExpense.Controls.Add(this.dateTimePickerDate);
            this.groupBoxNewExpense.Controls.Add(this.labelDate);
            this.groupBoxNewExpense.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNewExpense.Name = "groupBoxNewExpense";
            this.groupBoxNewExpense.Size = new System.Drawing.Size(268, 261);
            this.groupBoxNewExpense.TabIndex = 7;
            this.groupBoxNewExpense.TabStop = false;
            this.groupBoxNewExpense.Text = "New Expense";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(169, 221);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxExpenseList
            // 
            this.groupBoxExpenseList.Controls.Add(this.dataGridView1);
            this.groupBoxExpenseList.Controls.Add(this.buttonLoad);
            this.groupBoxExpenseList.Controls.Add(this.labelToDate);
            this.groupBoxExpenseList.Controls.Add(this.labelDromDate);
            this.groupBoxExpenseList.Controls.Add(this.dateTimePickerToDate);
            this.groupBoxExpenseList.Controls.Add(this.dateTimePickerFromDate);
            this.groupBoxExpenseList.Location = new System.Drawing.Point(286, 12);
            this.groupBoxExpenseList.Name = "groupBoxExpenseList";
            this.groupBoxExpenseList.Size = new System.Drawing.Size(373, 466);
            this.groupBoxExpenseList.TabIndex = 8;
            this.groupBoxExpenseList.TabStop = false;
            this.groupBoxExpenseList.Text = "Expenses";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(53, 26);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(103, 20);
            this.dateTimePickerFromDate.TabIndex = 0;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(188, 26);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerToDate.TabIndex = 1;
            // 
            // labelDromDate
            // 
            this.labelDromDate.AutoSize = true;
            this.labelDromDate.Location = new System.Drawing.Point(17, 26);
            this.labelDromDate.Name = "labelDromDate";
            this.labelDromDate.Size = new System.Drawing.Size(30, 13);
            this.labelDromDate.TabIndex = 2;
            this.labelDromDate.Text = "From";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(162, 26);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(20, 13);
            this.labelToDate.TabIndex = 3;
            this.labelToDate.Text = "To";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(300, 26);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(63, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 390);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(671, 490);
            this.Controls.Add(this.groupBoxExpenseList);
            this.Controls.Add(this.groupBoxNewExpense);
            this.Name = "FormExpenses";
            this.Text = "Expense Tracker";
            this.groupBoxNewExpense.ResumeLayout(false);
            this.groupBoxNewExpense.PerformLayout();
            this.groupBoxExpenseList.ResumeLayout(false);
            this.groupBoxExpenseList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.GroupBox groupBoxNewExpense;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxExpenseList;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelDromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

