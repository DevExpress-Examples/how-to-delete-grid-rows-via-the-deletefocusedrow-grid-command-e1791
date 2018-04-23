﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Bars;

namespace GridCommands_DeleteFocusedRow {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = new AccountList().GetData();
        }

    }

    #region Account classes
    public class AccountList {
        public List<Account> GetData() {
            return CreateAccounts();
        }
        private List<Account> CreateAccounts() {
            List<Account> list = new List<Account>();
            list.Add(new Account() { UserName = "Nick White", 
                RegistrationDate = DateTime.Today });
            list.Add(new Account() { UserName = "Jack Rodman", 
                RegistrationDate = new DateTime(2009, 5, 10) });
            list.Add(new Account() { UserName = "Sandra Sherry", 
                RegistrationDate = new DateTime(2008, 12, 22) });
            list.Add(new Account() { UserName = "Sabrina Vilk", 
                RegistrationDate = DateTime.Today });
            list.Add(new Account() { UserName = "Mike Pearson", 
                RegistrationDate = new DateTime(2008, 10, 18) });
            return list;
        }
    }

    public class Account {
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    #endregion
}
