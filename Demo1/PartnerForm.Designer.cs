namespace Demo1
{
    partial class PartnerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyRatingTextBox = new System.Windows.Forms.TextBox();
            this.companyEmailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.companyINNTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.partnerNameComboBox = new System.Windows.Forms.ComboBox();
            this.partner_type = new System.Windows.Forms.Label();
            this.company_name = new System.Windows.Forms.Label();
            this.company_address = new System.Windows.Forms.Label();
            this.company_INN = new System.Windows.Forms.Label();
            this.director_name = new System.Windows.Forms.Label();
            this.phone_number = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.raiting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(431, 456);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 51);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(144, 98);
            this.companyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(407, 25);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // companyRatingTextBox
            // 
            this.companyRatingTextBox.Location = new System.Drawing.Point(145, 381);
            this.companyRatingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyRatingTextBox.Name = "companyRatingTextBox";
            this.companyRatingTextBox.Size = new System.Drawing.Size(407, 25);
            this.companyRatingTextBox.TabIndex = 3;
            // 
            // companyEmailTextBox
            // 
            this.companyEmailTextBox.Location = new System.Drawing.Point(145, 333);
            this.companyEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyEmailTextBox.Name = "companyEmailTextBox";
            this.companyEmailTextBox.Size = new System.Drawing.Size(407, 25);
            this.companyEmailTextBox.TabIndex = 4;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(144, 289);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(405, 25);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Location = new System.Drawing.Point(200, 239);
            this.directorNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(349, 25);
            this.directorNameTextBox.TabIndex = 6;
            // 
            // companyINNTextBox
            // 
            this.companyINNTextBox.Location = new System.Drawing.Point(144, 195);
            this.companyINNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyINNTextBox.Name = "companyINNTextBox";
            this.companyINNTextBox.Size = new System.Drawing.Size(405, 25);
            this.companyINNTextBox.TabIndex = 7;
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.Location = new System.Drawing.Point(144, 145);
            this.companyAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(405, 25);
            this.companyAddressTextBox.TabIndex = 8;
            // 
            // partnerNameComboBox
            // 
            this.partnerNameComboBox.FormattingEnabled = true;
            this.partnerNameComboBox.Location = new System.Drawing.Point(145, 50);
            this.partnerNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.partnerNameComboBox.Name = "partnerNameComboBox";
            this.partnerNameComboBox.Size = new System.Drawing.Size(160, 25);
            this.partnerNameComboBox.TabIndex = 10;
            // 
            // partner_type
            // 
            this.partner_type.AutoSize = true;
            this.partner_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partner_type.Location = new System.Drawing.Point(37, 50);
            this.partner_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partner_type.Name = "partner_type";
            this.partner_type.Size = new System.Drawing.Size(35, 17);
            this.partner_type.TabIndex = 11;
            this.partner_type.Text = "Тип:";
            // 
            // company_name
            // 
            this.company_name.AutoSize = true;
            this.company_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_name.Location = new System.Drawing.Point(37, 98);
            this.company_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(76, 17);
            this.company_name.TabIndex = 12;
            this.company_name.Text = "Компания:";
            // 
            // company_address
            // 
            this.company_address.AutoSize = true;
            this.company_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_address.Location = new System.Drawing.Point(37, 149);
            this.company_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.company_address.Name = "company_address";
            this.company_address.Size = new System.Drawing.Size(50, 17);
            this.company_address.TabIndex = 13;
            this.company_address.Text = "Адрес:";
            // 
            // company_INN
            // 
            this.company_INN.AutoSize = true;
            this.company_INN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.company_INN.Location = new System.Drawing.Point(37, 195);
            this.company_INN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.company_INN.Name = "company_INN";
            this.company_INN.Size = new System.Drawing.Size(42, 17);
            this.company_INN.TabIndex = 14;
            this.company_INN.Text = "ИНН:";
            // 
            // director_name
            // 
            this.director_name.AutoSize = true;
            this.director_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.director_name.Location = new System.Drawing.Point(37, 243);
            this.director_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.director_name.Name = "director_name";
            this.director_name.Size = new System.Drawing.Size(114, 17);
            this.director_name.TabIndex = 15;
            this.director_name.Text = "ФИО директора:";
            // 
            // phone_number
            // 
            this.phone_number.AutoSize = true;
            this.phone_number.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_number.Location = new System.Drawing.Point(37, 289);
            this.phone_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(55, 17);
            this.phone_number.TabIndex = 16;
            this.phone_number.Text = "Номер:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(37, 337);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(46, 17);
            this.email.TabIndex = 17;
            this.email.Text = "Email:";
            // 
            // raiting
            // 
            this.raiting.AutoSize = true;
            this.raiting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.raiting.Location = new System.Drawing.Point(37, 384);
            this.raiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raiting.Name = "raiting";
            this.raiting.Size = new System.Drawing.Size(62, 17);
            this.raiting.TabIndex = 18;
            this.raiting.Text = "Рейтинг:";
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(604, 548);
            this.Controls.Add(this.raiting);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.director_name);
            this.Controls.Add(this.company_INN);
            this.Controls.Add(this.company_address);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.partner_type);
            this.Controls.Add(this.partnerNameComboBox);
            this.Controls.Add(this.companyAddressTextBox);
            this.Controls.Add(this.companyINNTextBox);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.companyEmailTextBox);
            this.Controls.Add(this.companyRatingTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartnerForm";
            this.Text = "Добавление партнера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companyRatingTextBox;
        private System.Windows.Forms.TextBox companyEmailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox companyINNTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.ComboBox partnerNameComboBox;
        private System.Windows.Forms.Label partner_type;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.Label company_address;
        private System.Windows.Forms.Label company_INN;
        private System.Windows.Forms.Label director_name;
        private System.Windows.Forms.Label phone_number;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label raiting;
    }
}