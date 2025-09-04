using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoLIST
{
    public partial class ToDoListManager : Form
    {
        public ToDoListManager()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoListManager_Load(object sender, EventArgs e)
        {
            // create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // point our datagridview to our datasource

            ToDoListView.DataSource = todoList;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";   
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            // fill text fields with data from table

            TitleTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            DescriptionTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = DescriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(TitleTextBox.Text, DescriptionTextBox.Text);

                // clear fields

                TitleTextBox.Text = "";
                DescriptionTextBox.Text = "";
                isEditing = false;
            }
        }
    }
}
