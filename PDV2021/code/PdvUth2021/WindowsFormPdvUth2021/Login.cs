﻿using LibPdvUth2021.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPdvUth2021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User us = new User();
            if (us.Login(emailInput.Text, passwordInput.Text)) 
            {
                btnLogin.Text = "Bienvenido";
            }
            else 
            {
                MessageBox.Show($"El correo o contraseña no es valido");
            }


        }
    }
}
