using AntdUI;
using ReaLTaiizor.Controls;
using ToDo.Business;
using ToDo.DataAccess;
using ToDo.Entities;

namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        ToDoManager ToDoManager = new ToDoManager(new EFToDoDal());
        private void foreverClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
            DataGridDoldur();
        }

        private void clearForm()
        {
            crownTextBox1.Clear();
            PriorityComboBox1.SelectedIndex = -1;
            CategoryComboBox2.SelectedIndex = -1;
            crownTextBox2.Clear();
        }

        #region Component value
        private void DataGridDoldur()
        {
            poisonDataGridView1.DataSource = ToDoManager.getAll();
            poisonDataGridView1.Columns["id"].Visible = false; // Hide the ID column
        }
        private void ComboboxDoldur()
        {
            List<string> Priority = new List<string>
            {
                "Low",
                "Normal",
                "High"
            };

            //List<string> Status = new List<string> 
            //{
            //    "Not Started",
            //    "In Progress",
            //    "Completed" 
            //};

            List<string> Category = new List<string>
            {
                "Personal",
                "Work",
            };

            foreach (var item in Priority)
            {
                PriorityComboBox1.Items.Add(item);
            }
            foreach (var item in Category)
            {
                CategoryComboBox2.Items.Add(item);
            }
        }
        #endregion

        #region Button category list
        private void button1_Click(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = ToDoManager.GetAllByCategory("Personal");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = ToDoManager.GetAllByCategory("Work");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridDoldur();
        }
        #endregion

        #region Add Button
        private void button3_Click(object sender, EventArgs e)
        {

            ToDoEntity todo = new ToDoEntity
            {
                Taskinfo = crownTextBox1.Text,
                Priority = PriorityComboBox1.Text,
                Category = CategoryComboBox2.Text,
                Not = crownTextBox2.Text,
                StartDate = hopeDatePicker1.Date,
                Status = "Not Started",
            };
            try
            {
                ToDoManager.Add(todo);
                MessageBox.Show("Task Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridDoldur();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            ToDoManager.UpdateStatus(new ToDoEntity
            {
                id = Convert.ToInt32(poisonDataGridView1.SelectedRows[0].Cells["id"].Value),
                Status = "Completed",
            });
            DataGridDoldur();
        }
    }
}
