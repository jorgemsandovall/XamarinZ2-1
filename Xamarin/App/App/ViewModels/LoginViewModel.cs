using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App.ViewModels
{
   public class LoginViewModel:BaseViewModel
    {
        #region Attributes

        string email;

        string password;

        bool isrunning;

        bool isenabled;

        #endregion

        #region Properties
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                SetValue(ref this.email, value);
            }
        }
        public string Password
        {
             
                get
            {
                    return this.password;
                }
                set
            {
                    SetValue(ref this.password, value);
            }
            
        }
        public bool IsRunning
        {
            get
            {
                return this.isrunning;
            }
            set
            {
                SetValue(ref this.isrunning , value);
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isenabled;
            }
            set
            {
                SetValue(ref this.isenabled, value);
            }
        }


        #endregion


        #region Commands
        public ICommand LoginCommad
        {
            get
            {
                return new RelayCommand(cmdLogin);

            }
        }

        private async void cmdLogin()
        {
            if (String.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Email empty", "Please input email", "Accept");

                return;
            }
            if(String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Passwprd empty", "Please input Password", "Accept");
                return;

            }

            IsRunning = true;
        }
        #endregion

    }
}
