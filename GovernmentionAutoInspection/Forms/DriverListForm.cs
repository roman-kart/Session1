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
    public partial class DriverListForm : Form
    {
        /// <summary>
        /// Содержит инорфмацию о модели данных и сами данные из подключенной базы данных DriversKart
        /// </summary>
        private DriversModel _databse = new DriversModel();
        public DriverListForm()
        {
            InitializeComponent();
        }

        private void addDriverButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // если выбран объект
            if (this.driversBindingSource.Current != null)
            {
                var editDriverForm = new AddOrEditDriverForm();
                editDriverForm.Driver = (Drivers)this.driversBindingSource.Current;
                var result = editDriverForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите пользователя", "Ошибка");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Заполняет таблицу информацией о водителях.
        /// Применяется при загрузке формы, а также для обновления данных формы после удаления элемента.
        /// </summary>
        private void ShowDriversList()
        {
            this.driversBindingSource.DataSource = _databse.Drivers.ToList(); // заполняем таблицу водителей
        }
        private void DriverListForm_Load(object sender, EventArgs e)
        {
            ShowDriversList(); // заполняем таблицу водителей при загрузке формы
        }
    }
}
