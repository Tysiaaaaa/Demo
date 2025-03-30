namespace Demo1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.partnersGridView = new System.Windows.Forms.DataGridView();
            this.AddPartnerButton = new System.Windows.Forms.Button();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partnersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partnersGridView
            // 
            this.partnersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partnersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partnersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.partnersGridView.Location = new System.Drawing.Point(13, 12);
            this.partnersGridView.Name = "partnersGridView";
            this.partnersGridView.Size = new System.Drawing.Size(565, 150);
            this.partnersGridView.TabIndex = 0;
            // 
            // AddPartnerButton
            // 
            this.AddPartnerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.AddPartnerButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPartnerButton.Location = new System.Drawing.Point(12, 182);
            this.AddPartnerButton.Name = "AddPartnerButton";
            this.AddPartnerButton.Size = new System.Drawing.Size(88, 63);
            this.AddPartnerButton.TabIndex = 1;
            this.AddPartnerButton.Text = "Добавить";
            this.AddPartnerButton.UseVisualStyleBackColor = false;
            this.AddPartnerButton.Click += new System.EventHandler(this.AddPartnerButton_Click);
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.ViewHistoryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewHistoryButton.ForeColor = System.Drawing.Color.Black;
            this.ViewHistoryButton.Location = new System.Drawing.Point(227, 182);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(209, 63);
            this.ViewHistoryButton.TabIndex = 2;
            this.ViewHistoryButton.Text = "История реализации продукции";
            this.ViewHistoryButton.UseVisualStyleBackColor = false;
            this.ViewHistoryButton.Click += new System.EventHandler(this.ViewHistoryButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(107, 182);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(114, 63);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Редактировать ";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(591, 339);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ViewHistoryButton);
            this.Controls.Add(this.AddPartnerButton);
            this.Controls.Add(this.partnersGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Просмотр партнеров";
            ((System.ComponentModel.ISupportInitialize)(this.partnersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView partnersGridView;
        private System.Windows.Forms.Button AddPartnerButton;
        private System.Windows.Forms.Button ViewHistoryButton;
        private System.Windows.Forms.Button EditButton;
    }
}

