﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("<<--SBI-->>");
            Accounts sbi = new Accounts(1000, "Nagesh Nagansur ", 8180933388);
            sbi.UserInfo();
            sbi.AddCash(2000);
            sbi.Withdraw(500);
            sbi.Withdraw(400);
            sbi.Balance();
           
            //sbi.Name = "Nagesh "; won't work cannot access readonly
            //sbi.accountNo=818093388;  won't work cannot access readonly


        }
    }
}
