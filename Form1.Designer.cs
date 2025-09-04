namespace ToDoLIST
{
    partial class ToDoListManager
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
            this.ToDoList = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ToDoListView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDoList
            // 
            this.ToDoList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToDoList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToDoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ToDoList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ToDoList.Location = new System.Drawing.Point(6, 9);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(1264, 111);
            this.ToDoList.TabIndex = 0;
            this.ToDoList.Text = "ToDoList";
            this.ToDoList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Description
            // 
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Description.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Description.Location = new System.Drawing.Point(12, 221);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(1258, 37);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Title.Location = new System.Drawing.Point(12, 133);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1258, 36);
            this.Title.TabIndex = 5;
            this.Title.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.AllowDrop = true;
            this.TitleTextBox.Location = new System.Drawing.Point(12, 192);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(1258, 26);
            this.TitleTextBox.TabIndex = 6;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 271);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(1258, 26);
            this.DescriptionTextBox.TabIndex = 7;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.newButton.Location = new System.Drawing.Point(12, 314);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(310, 41);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editButton.Location = new System.Drawing.Point(328, 314);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(310, 41);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.Location = new System.Drawing.Point(644, 314);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(310, 41);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(960, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(310, 41);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ToDoListView
            // 
            this.ToDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListView.BackgroundColor = System.Drawing.Color.White;
            this.ToDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListView.Location = new System.Drawing.Point(12, 370);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.RowHeadersWidth = 62;
            this.ToDoListView.RowTemplate.Height = 28;
            this.ToDoListView.Size = new System.Drawing.Size(1258, 260);
            this.ToDoListView.TabIndex = 15;
            // 
            // ToDoListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1299, 642);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ToDoList);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "ToDoListManager";
            this.Text = "ToDoListManager";
            this.Load += new System.EventHandler(this.ToDoListManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ToDoList;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView ToDoListView;
    }
}

