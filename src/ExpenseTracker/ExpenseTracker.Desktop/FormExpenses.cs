using ExpenseTracker.Desktop.ExpenseServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker.Desktop
{
    public partial class FormExpenses : Form
    {
        public FormExpenses()
        {
            InitializeComponent();
            
            comboBoxCurrency.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Expense newExpense = new Expense();
            newExpense.Amount = decimal.Parse(textBoxAmount.Text);
            newExpense.Date = dateTimePickerDate.Value;
            newExpense.Notes = textBoxNotes.Text;
            newExpense.Currency = (Currency)Enum.Parse(typeof(Currency), comboBoxCurrency.Text, true);

            ExpenseServiceClient client = new ExpenseServiceClient();
            int id = client.SaveExpense(newExpense);

            if (id > 0)
            {
                MessageBox.Show("Saved new expense with ID:" + id.ToString());
            }

        }
    }
}
