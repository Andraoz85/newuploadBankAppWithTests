using System;
using System.Windows;


namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Window
    {
        Customer _customer;
        TransactionHistory _transactionHistory;



        //public TransactionHistory transactionHistory { get; private set; }
        /*
        public void SetTransactionHistory(TransactionHistory transactionHistory)
        {
            _transactionHistory = transactionHistory;
        }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }*/

        public Deposit(Customer customer)
        {
            InitializeComponent();
            AccountBalance.Text = GetAccountBalance(customer);

            _transactionHistory = new TransactionHistory(customer);
        }

        private string GetAccountBalance(Customer customer)
        {
            _customer = customer;
            var result = customer.GetBalance().ToString();
            return result;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            var Inloggad = new Inloggad(_customer);
            Inloggad.Show();
            Close();
        }

        private void ConfirmDepositBtn_Click(object sender, RoutedEventArgs e)
        {
            DepositConfirmed(_transactionHistory);
            MessageBox.Show("Successful transfer");

        }
        private void DepositConfirmed(TransactionHistory transactionHistory)
        {
            //_transactionHistory = transactionHistory;
            string depositAmountString = DepositAmount.Text;
            string depositAccountRecieverString = AccountReciever.Text;
            int depositAmount = Convert.ToInt32(depositAmountString);
            int depositAccountReciever = Convert.ToInt32(depositAccountRecieverString);
            Transaction transaction = new Transaction(1, depositAmount, true, DateTime.Now, depositAccountReciever, _customer.GetAccountNr());
            this._transactionHistory.TransactionList.Add(transaction);

        }

        private void DepositAmount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
