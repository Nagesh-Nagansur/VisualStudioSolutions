using System;

namespace InheritanceEx1
{
    public class Accounts : Info
    {
        private int   _cash;
        public Accounts(int cash, string name, long accountno )
            :base(name,accountno)
        {
            _cash = cash;
       

        }
    
  
        public void AddCash(int money)
        {
            _cash = _cash + money;
            Console.WriteLine("Available Balance-->{0}", _cash);
        }
        public void Withdraw(int money)
        {
            _cash = _cash - money;
            Console.WriteLine("Available Balance-->{0}", _cash);
        }
    

        public void Balance()
        {
            Console.WriteLine("Balance-->{0}",_cash);
        }

    }
}
