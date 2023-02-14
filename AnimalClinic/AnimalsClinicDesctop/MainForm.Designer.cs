namespace AnimalsClinicDesctop
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
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.tabPagePets = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClient
            // 
            this.listViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.ColumnHeaderSurName,
            this.ColumnHeaderFirstName,
            this.ColumnHeaderPatronymic});
            this.listViewClient.HideSelection = false;
            this.listViewClient.Location = new System.Drawing.Point(6, 6);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(765, 271);
            this.listViewClient.TabIndex = 0;
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            // 
            // ColumnHeaderSurName
            // 
            this.ColumnHeaderSurName.Text = "Фамилия";
            this.ColumnHeaderSurName.Width = 200;
            // 
            // ColumnHeaderFirstName
            // 
            this.ColumnHeaderFirstName.Text = "Имя";
            this.ColumnHeaderFirstName.Width = 150;
            // 
            // ColumnHeaderPatronymic
            // 
            this.ColumnHeaderPatronymic.Text = "Отчество";
            this.ColumnHeaderPatronymic.Width = 200;
            // 
            // buttonLoadClient
            // 
            this.buttonLoadClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadClient.Location = new System.Drawing.Point(669, 330);
            this.buttonLoadClient.Name = "buttonLoadClient";
            this.buttonLoadClient.Size = new System.Drawing.Size(102, 52);
            this.buttonLoadClient.TabIndex = 1;
            this.buttonLoadClient.Text = "Загрузка";
            this.buttonLoadClient.UseVisualStyleBackColor = true;
            this.buttonLoadClient.Click += new System.EventHandler(this.buttonLoadClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageClients);
            this.tabControl1.Controls.Add(this.tabPagePets);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.listViewClient);
            this.tabPageClients.Controls.Add(this.buttonLoadClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(777, 400);
            this.tabPageClients.TabIndex = 0;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // tabPagePets
            // 
            this.tabPagePets.Location = new System.Drawing.Point(4, 22);
            this.tabPagePets.Name = "tabPagePets";
            this.tabPagePets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePets.Size = new System.Drawing.Size(777, 400);
            this.tabPagePets.TabIndex = 1;
            this.tabPagePets.Text = "Животные";
            this.tabPagePets.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ветеринарная клиника";
            this.tabControl1.ResumeLayout(false);
            this.tabPageClients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader ColumnHeaderSurName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderPatronymic;
        private System.Windows.Forms.Button buttonLoadClient;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.TabPage tabPagePets;
    }
}

