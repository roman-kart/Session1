using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GovernmentionAutoInspection.Forms;

namespace GovernmentionAutoInspection
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Возвращает true, если учетная запись с логином и паролем, которые ввел пользователь, существует в базе данных.
        /// Иначе возвращает false.
        /// Так как программа находится на стадии разработки,
        /// то для удобства существует только одни пользователь: логин: inspector, пароль: inspector.
        /// Данные о пользователе хранятся в данном методе.
        /// </summary>
        /// <returns></returns>
        private bool IsAuthorisationDataValid()
        {
            string validLogin = "inspector";
            string validPassword = "inspector";

            string writtenLogin = loginTextBox.Text != null? loginTextBox.Text : "";
            string writtenPassword = passwordTextBox.Text != null ? passwordTextBox.Text : "";

            if (validLogin == writtenLogin && validPassword == writtenPassword)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Перемещает пользователя на главную форму, если пользователь ввел верные данные для авторизации.
        /// В противном случае показывает сообщение об ошибке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (IsAuthorisationDataValid())
            {
                // переход на форму, где отображается список водителей
                var childForm = new DriverListForm();
                childForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введен неправильный логин или пароль.\nПовторите попытку ещё раз.", "Ошибка");
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
