﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ThermalAdiposer.Models;

namespace ThermalAdiposer.ViewModels
{
    public class UserViewModel
    {
        private IList<UserModel> _usersList;
        public UserViewModel()
        {
            _usersList = new List<UserModel>
            {
                new UserModel{UserId = 1,FirstName="Raj",LastName="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                new UserModel{UserId=2,FirstName="Mark",LastName="henry",City="New York", State="NY", Country="USA"},
                new UserModel{UserId=3,FirstName="Mahesh",LastName="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new UserModel{UserId=4,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new UserModel{UserId=5,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new UserModel{UserId=6,FirstName="Reetesh",LastName="Tomar",City="Mumbai", State="MP", Country="INDIA"},
                new UserModel{UserId=7,FirstName="Deven",LastName="Verma",City="Palwal", State="HP", Country="INDIA"},
                new UserModel{UserId=8,FirstName="Ravi",LastName="Taneja",City="Delhi", State="DEL", Country="INDIA"}
            };
        }
        public IList<UserModel> Users
        {
            get { return _usersList; }
            set { _usersList = value; }
        }

        private ICommand _mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (_mUpdater == null)
                    return new Updater();
                return _mUpdater;
            }
            set
            {
                _mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter) => true;

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
