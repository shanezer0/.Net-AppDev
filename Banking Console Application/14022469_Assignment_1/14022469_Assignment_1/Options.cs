using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14022469_Assignment_1
{
    
        public enum MenuOptions



        {
            LoginMenu,
            CreateAccount,
            SearchAccount,
            Deposit,
            Withdraw,
            ViewStatement,
            ViewStatement2,
            DeleteAccount,
            DeleteAccount2
        }

        public enum EmailOptions
        {
            AccountInfo,
            Statement
        }

        public enum AccountType
        {
            New,
            Existing
        }

        public enum TransactionType
        {
            Deposit,
            Withdrawal
        }
    }

