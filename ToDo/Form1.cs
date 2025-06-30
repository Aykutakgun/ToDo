namespace ToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foreverClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
