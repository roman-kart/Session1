namespace GovernmentionAutoInspection.Forms
{
    partial class AddOrEditDriverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label addressLifeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label jobNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label passportNumberLabel;
            System.Windows.Forms.Label passportSerialLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label passportLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLifeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.jobNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportSerialTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.exitAndUnsaveButton2 = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            addressLifeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            jobNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            passportNumberLabel = new System.Windows.Forms.Label();
            passportSerialLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            passportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(22, 176);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(168, 18);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес регистрации*:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(266, 173);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(266, 24);
            this.addressTextBox.TabIndex = 2;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // addressLifeLabel
            // 
            addressLifeLabel.AutoSize = true;
            addressLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLifeLabel.Location = new System.Drawing.Point(22, 206);
            addressLifeLabel.Name = "addressLifeLabel";
            addressLifeLabel.Size = new System.Drawing.Size(166, 18);
            addressLifeLabel.TabIndex = 3;
            addressLifeLabel.Text = "Адрес проживания*:";
            // 
            // addressLifeTextBox
            // 
            this.addressLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "AddressLife", true));
            this.addressLifeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLifeTextBox.Location = new System.Drawing.Point(266, 203);
            this.addressLifeTextBox.Name = "addressLifeTextBox";
            this.addressLifeTextBox.Size = new System.Drawing.Size(266, 24);
            this.addressLifeTextBox.TabIndex = 4;
            this.addressLifeTextBox.TextChanged += new System.EventHandler(this.addressLifeTextBox_TextChanged);
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            companyLabel.Location = new System.Drawing.Point(22, 236);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(126, 18);
            companyLabel.TabIndex = 5;
            companyLabel.Text = "Место работы:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Company", true));
            this.companyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTextBox.Location = new System.Drawing.Point(266, 233);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(266, 24);
            this.companyTextBox.TabIndex = 6;
            this.companyTextBox.TextChanged += new System.EventHandler(this.companyTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(22, 386);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(99, 18);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Замечания:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(266, 383);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(266, 24);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(22, 326);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(62, 18);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email*:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(266, 323);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(266, 24);
            this.emailTextBox.TabIndex = 10;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(22, 86);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(53, 18);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "Имя*:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(266, 83);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.firstNameTextBox.TabIndex = 12;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(22, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(203, 18);
            iDLabel.TabIndex = 13;
            iDLabel.Text = "Идентификатор (GUID)*:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(266, 23);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(266, 24);
            this.iDTextBox.TabIndex = 14;
            // 
            // jobNameLabel
            // 
            jobNameLabel.AutoSize = true;
            jobNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            jobNameLabel.Location = new System.Drawing.Point(22, 266);
            jobNameLabel.Name = "jobNameLabel";
            jobNameLabel.Size = new System.Drawing.Size(103, 18);
            jobNameLabel.TabIndex = 15;
            jobNameLabel.Text = "Должность:";
            jobNameLabel.Click += new System.EventHandler(this.jobNameLabel_Click);
            // 
            // jobNameTextBox
            // 
            this.jobNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "JobName", true));
            this.jobNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobNameTextBox.Location = new System.Drawing.Point(266, 263);
            this.jobNameTextBox.Name = "jobNameTextBox";
            this.jobNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.jobNameTextBox.TabIndex = 16;
            this.jobNameTextBox.TextChanged += new System.EventHandler(this.jobNameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(22, 56);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(92, 18);
            lastNameLabel.TabIndex = 17;
            lastNameLabel.Text = "Фамилия*:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(266, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleNameLabel.Location = new System.Drawing.Point(22, 116);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(95, 18);
            middleNameLabel.TabIndex = 19;
            middleNameLabel.Text = "Отчество*:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "MiddleName", true));
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTextBox.Location = new System.Drawing.Point(266, 113);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(266, 24);
            this.middleNameTextBox.TabIndex = 20;
            // 
            // passportNumberLabel
            // 
            passportNumberLabel.AutoSize = true;
            passportNumberLabel.Enabled = false;
            passportNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportNumberLabel.Location = new System.Drawing.Point(40, 522);
            passportNumberLabel.Name = "passportNumberLabel";
            passportNumberLabel.Size = new System.Drawing.Size(145, 18);
            passportNumberLabel.TabIndex = 21;
            passportNumberLabel.Text = "Passport Number:";
            passportNumberLabel.Visible = false;
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "PassportNumber", true));
            this.passportNumberTextBox.Enabled = false;
            this.passportNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportNumberTextBox.Location = new System.Drawing.Point(284, 519);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(266, 24);
            this.passportNumberTextBox.TabIndex = 22;
            this.passportNumberTextBox.Visible = false;
            // 
            // passportSerialLabel
            // 
            passportSerialLabel.AutoSize = true;
            passportSerialLabel.Enabled = false;
            passportSerialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportSerialLabel.Location = new System.Drawing.Point(40, 552);
            passportSerialLabel.Name = "passportSerialLabel";
            passportSerialLabel.Size = new System.Drawing.Size(129, 18);
            passportSerialLabel.TabIndex = 23;
            passportSerialLabel.Text = "Passport Serial:";
            passportSerialLabel.Visible = false;
            // 
            // passportSerialTextBox
            // 
            this.passportSerialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "PassportSerial", true));
            this.passportSerialTextBox.Enabled = false;
            this.passportSerialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportSerialTextBox.Location = new System.Drawing.Point(284, 549);
            this.passportSerialTextBox.Name = "passportSerialTextBox";
            this.passportSerialTextBox.Size = new System.Drawing.Size(266, 24);
            this.passportSerialTextBox.TabIndex = 24;
            this.passportSerialTextBox.Visible = false;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(22, 296);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(186, 18);
            phoneLabel.TabIndex = 25;
            phoneLabel.Text = "Мобильный телефон*:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(266, 293);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(266, 24);
            this.phoneTextBox.TabIndex = 26;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            photoLabel.Location = new System.Drawing.Point(22, 356);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(119, 18);
            photoLabel.TabIndex = 27;
            photoLabel.Text = "Фотография*:";
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "Photo", true));
            this.photoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoTextBox.Location = new System.Drawing.Point(266, 353);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(266, 24);
            this.photoTextBox.TabIndex = 28;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataSource = typeof(GovernmentionAutoInspection.Model.Drivers);
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passportLabel.Location = new System.Drawing.Point(22, 146);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new System.Drawing.Size(216, 18);
            passportLabel.TabIndex = 29;
            passportLabel.Text = "Паспорт (серия и номер)*:";
            // 
            // passportTextBox
            // 
            this.passportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driversBindingSource, "PassportNumber", true));
            this.passportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportTextBox.Location = new System.Drawing.Point(266, 143);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(266, 24);
            this.passportTextBox.TabIndex = 30;
            // 
            // saveDataButton
            // 
            this.saveDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.saveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDataButton.Location = new System.Drawing.Point(75, 425);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(163, 88);
            this.saveDataButton.TabIndex = 31;
            this.saveDataButton.Text = "Сохранить";
            this.saveDataButton.UseVisualStyleBackColor = false;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // exitAndUnsaveButton2
            // 
            this.exitAndUnsaveButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.exitAndUnsaveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitAndUnsaveButton2.Location = new System.Drawing.Point(338, 425);
            this.exitAndUnsaveButton2.Name = "exitAndUnsaveButton2";
            this.exitAndUnsaveButton2.Size = new System.Drawing.Size(163, 88);
            this.exitAndUnsaveButton2.TabIndex = 32;
            this.exitAndUnsaveButton2.Text = "Выйти без сохранения изменений";
            this.exitAndUnsaveButton2.UseVisualStyleBackColor = false;
            this.exitAndUnsaveButton2.Click += new System.EventHandler(this.exitAndUnsaveButton2_Click);
            // 
            // AddOrEditDriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(562, 536);
            this.Controls.Add(this.exitAndUnsaveButton2);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(passportLabel);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(addressLifeLabel);
            this.Controls.Add(this.addressLifeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(jobNameLabel);
            this.Controls.Add(this.jobNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(middleNameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(passportNumberLabel);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(passportSerialLabel);
            this.Controls.Add(this.passportSerialTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoTextBox);
            this.MaximumSize = new System.Drawing.Size(578, 575);
            this.MinimumSize = new System.Drawing.Size(578, 575);
            this.Name = "AddOrEditDriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEditDriverForm";
            this.Load += new System.EventHandler(this.AddOrEditDriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource driversBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox addressLifeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox jobNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.TextBox passportSerialTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button exitAndUnsaveButton2;
    }
}