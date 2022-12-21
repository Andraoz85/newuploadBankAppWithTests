using System.Windows;

namespace ATMApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer _customer;
        public void SetCustomer(Customer customer)
        {
            _customer = customer;
        }
        public MainWindow()
        {
            InitializeComponent();
        }


        public void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            foreach (var c in customer.CustomerList())
            {
                if (userInputAccountNumber.Text == c.GetAccountNr().ToString() && userInputPincodeNumber.Password == c.GetPinCode().ToString())
                {
                    MessageBox.Show("You are logged in " + c.GetName());
                    var inloggad = new Inloggad(_customer);
                    inloggad.SetCustomer(c);
                    inloggad.Show();
                    Close();
                    return;
                }
            }
            MessageBox.Show("Wrong accountnumber or password. Please try again!");
            userInputPincodeNumber.Clear();
            userInputAccountNumber.Clear();
        }
        public void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        public void Registrera_Click(object sender, RoutedEventArgs e)
        {
            var Registrering = new Registrering();
            Registrering.Show();
            Close();
        }
    }
}
