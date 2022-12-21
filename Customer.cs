using System.Collections.Generic;

namespace ATMApp
{
    public class Customer
    {

        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        private int _pinCode;
        public int pinCode
        {
            get
            {
                return _pinCode;
            }
            set
            {
                _pinCode = value;
            }
        }
        private int _accountNr;
        public int accountNr
        {
            get
            {
                return _accountNr;
            }
            set
            {
                _accountNr = value;
            }
        }
        private double _balance;
        public double balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }


        public Customer()
        {
        }
        //FOR TESTING--->
        private int pinCodeTest;
        private int accountNrTest;
        public Customer(int pinCodeTest, int accountNrTest)
        {
            this.pinCodeTest = pinCodeTest;
            this.accountNrTest = accountNrTest;
        }
        //<----FOR TESTING
        public List<Customer> customer = new List<Customer>();


        public List<Customer> CustomerList()
        {
            customer.Add(new Customer() { name = "Poor Peggy", accountNr = 999, pinCode = 999, balance = 1000 });
            customer.Add(new Customer() { name = "Sleepy Joe", accountNr = 888, pinCode = 888, balance = 43000 });
            customer.Add(new Customer() { name = "Lucky Luke", accountNr = 777, pinCode = 777, balance = 155210.70 });
            return customer;
        }
        public int GetAccountNr() { return accountNr; }
        public string? GetName() => name;
        public int GetPinCode() { return pinCode; }
        public double GetBalance() { return balance; }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    }
}