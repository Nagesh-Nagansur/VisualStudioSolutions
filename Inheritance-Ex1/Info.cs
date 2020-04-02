namespace InheritanceEx1
{
    public class Info
    {
        private readonly string _name;
        private readonly long _accountNo;
      

       public Info(string a,long b)
        {
           _name=a;
           _accountNo = b;
            

       }
  

        public void UserInfo()

        {
            System.Console.WriteLine("User Name-->{0}",_name);
            System.Console.WriteLine("Account No-->{0}",_accountNo);
        }



    }
}
