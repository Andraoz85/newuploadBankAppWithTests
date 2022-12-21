using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for Inloggad.xaml
    /// </summary>
    public partial class Inloggad : Window
    {
        Customer _customer { get; set; }

        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public Inloggad(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            var Deposit = new Deposit(_customer);
            Deposit.Show();
            this.Hide();
        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoggingOut_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
        }        
        private void TransactionHistory_Click(object sender, RoutedEventArgs e)
        {
            var TransactionHistory = new TransactionHistory(_customer);
            this.Close();
            TransactionHistory.Show();
        }
    }
}
