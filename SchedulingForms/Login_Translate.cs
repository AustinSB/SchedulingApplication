using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingForms
{
    public static class Login_Translate
    {
        //Message Box Text - private fields
        private static string invalidUsername;
        private static string credentialsDontMatch;
        private static string loginFailed;
        private static string confirmExitMessage;
        private static string confirmExitCaption;
        private static string okButton;
        private static string yesButton;
        private static string noButton;

        //Label Text - private fields
        private static string userName;
        private static string passWord;
        private static string login;
        private static string exit;


        //Message Box Text - public properties
        public static string InvalidUsername
        {
            get 
            {
                if (IsSpanishCountry()) 
                { invalidUsername = "El usuario no existe."; }
                else 
                { invalidUsername = "Username does not exist."; }
                return invalidUsername; 
            }
            set
            {
                invalidUsername = InvalidUsername;
            }
        }
        public static string CredentialsDontMatch
        {
            get 
            {
                if (IsSpanishCountry()) 
                { credentialsDontMatch = "Usuario y contraseña no coinciden."; }
                else 
                { credentialsDontMatch = "Username and password do not match"; }
                return credentialsDontMatch; 
            }
            set 
            { 
                credentialsDontMatch = CredentialsDontMatch; 
            }
        }
        public static string LoginFailed 
        {
            get 
            {
                if (IsSpanishCountry()) 
                { loginFailed = "Error de inicio de sesion."; }
                else 
                { loginFailed = "Failed Login"; }
                return loginFailed;
            }
            set 
            {
                loginFailed = LoginFailed;
            }
        }
        public static string ConfirmExitMessage 
        {
            get 
            {
                if (IsSpanishCountry()) { confirmExitMessage = "¿Seguro que quieres salir de este programa?"; }
                else { confirmExitMessage = "Are you sure you want to exit this program?"; }
                return confirmExitMessage; 
            }
            set 
            {
                confirmExitMessage = ConfirmExitMessage;
            }
        }
        public static string ConfirmExitCaption 
        {
            get 
            {
                if (IsSpanishCountry()) { confirmExitCaption = "Confirmar Salida"; }
                else { confirmExitCaption = "Confirm Exit"; }
                return confirmExitCaption; 
            }
            set 
            {
                confirmExitCaption = ConfirmExitCaption;
            }
        }
        public static string OkButton 
        {
            get 
            {
                if (IsSpanishCountry()) { okButton = "Okay"; }
                else { okButton = "OK"; }
                return okButton; 
            }
            set 
            {
                okButton = OkButton;
            }
        }
        public static string YesButton
        {
            get 
            {
                if (IsSpanishCountry()) { yesButton = "Si"; }
                else { yesButton = "Yes"; }
                return yesButton; 
            }
            set 
            {
                yesButton = YesButton;
            }
        }
        public static string NoButton 
        {
            get 
            {
                if (IsSpanishCountry()) { noButton = "No"; }
                else { noButton = "No"; }
                return noButton; 
            }
            set 
            {
                noButton = NoButton;
            }
        }

        //Label Text - public properties
        public static string UserName
        {
            get
            {
                if (IsSpanishCountry()) { userName = "Usuario"; }
                else { userName = "Username"; }
                return userName;
            }
            set
            {
                userName = UserName;
            }
        }
        public static string PassWord
        {
            get
            {
                if (IsSpanishCountry()) { passWord = "Contraseña"; }
                else { passWord = "Password"; }
                return passWord;
            }
            set
            {
                passWord = PassWord;
            }
        }
        public static string Login
        {
            get
            {
                if (IsSpanishCountry()) { login = "Acceder"; }
                else { login = "Login"; }
                return login;
            }
            set
            {
                login = Login;
            }
        }
        public static string Exit
        {
            get
            {
                if (IsSpanishCountry()) { exit = "Salida"; }
                else { exit = "Exit"; }
                return exit;
            }
            set
            {
                exit = Exit;
            }
        }

        //Determine if country is Spain.
        public static bool IsSpanishCountry()
        {
            if (CultureInfo.CurrentUICulture.Name == "es-ES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
