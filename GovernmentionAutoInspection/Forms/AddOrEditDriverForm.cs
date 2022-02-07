using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GovernmentionAutoInspection.Model;

namespace GovernmentionAutoInspection.Forms
{
    /// <summary>
    /// Форма для работы с данными о водителе.
    /// Предназначена как для добавления нового водителя,
    /// так и для редактирования существующего.
    /// Для внесения информации о текущем водителе необходимо присвоить свойству CurrentDriver 
    /// объект класса Driver. Присвоить необходимо до вызова метода Show().
    /// </summary>
    public partial class AddOrEditDriverForm : Form
    {
        /// <summary>
        /// Информация о водителе, которая будет отображена при её открытии
        /// </summary>
        public Drivers Driver { get; set; }
        public AddOrEditDriverForm()
        {
            InitializeComponent();
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLifeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// При загрузке формы необходимо проверить,
        /// присвоено ли свойству Driver значение.
        /// Если присвоено, то отображаем данные.
        /// В противном случае, оставляем поля незаполненными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrEditDriverForm_Load(object sender, EventArgs e)
        {
            if (this.Driver != null)
            {
                this.driversBindingSource.DataSource = Driver;
                // соединяем серию и номер, которые будут отображены в поле для ввода паспортных данных
                this.passportTextBox.Text = Driver.PassportSerial + " " + Driver.PassportNumber;
            }
        }

        private void jobNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void jobNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Если пользователь нажал на кнопку "Выйти без сохранения изменений", 
        /// то присваиваем свойству DialogResult значение DialogResult.Cancel и закрываем форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitAndUnsaveButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {

        }
    }
}
