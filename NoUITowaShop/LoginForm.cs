using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters;
using TOWALibrary.Views;

namespace SimpleUITowaShop
{
    public partial class LoginForm : Form, ILoginView
    {
        #region Contructor
        private LoginPresenter loginPresenter;
        public LoginForm()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
            SubscribeEventHanders();
        }

        #endregion

        #region WireUpEventHanders
        private void SubscribeEventHanders()
        {
            btnLogin.Click += delegate
            {
                LoginAction?.Invoke(this, EventArgs.Empty);
               
            };
            btnClear.Click += delegate
             {
                 CancelAction?.Invoke(this, EventArgs.Empty);
             };
        }
        #endregion

        #region Property
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPasswordHash.Text; set => txtPasswordHash.Text= value; }
        public bool IsSuccessful { get ; set ; }
        public string ErrorMessage { get => txtMessage.Text; set => txtMessage.Text= value; }

        public event EventHandler CancelAction;
        public event EventHandler LoginAction;
        #endregion

        #region Singleton
        private static LoginForm intance;
        public static LoginForm Instance
        {
            get
            {
                if (intance == null || intance.IsDisposed)
                {
                    intance=   new LoginForm();
                }
                return intance;
            }
        }
        #endregion 
    }
}
