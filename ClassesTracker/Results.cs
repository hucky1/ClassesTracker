using System;
using System.Linq;
using System.Windows.Forms;
using TrackerModel.TestModels;

namespace ClassesTrackerUI
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            using TestingContext db = new();
            dataGridView1.DataSource = db.PassedTests.ToList();

            testsLB.SelectedItem = "Все";
        }

        private void findBut_Click(object sender, EventArgs e)
        {
            string test = testsLB.SelectedItem.ToString();
            
                using TestingContext db = new();
            if (surNameTB.Text == "")
            {
                if (test == "Все")
                    dataGridView1.DataSource = db.PassedTests.ToList();
                else
                    dataGridView1.DataSource = db.PassedTests.Where(j => j.Test == test).ToList();
            }
            else
            {
                if (test == "Все")
                    dataGridView1.DataSource = db.PassedTests.Where(x => x.Name.ToLower().Contains(surNameTB.Text.ToLower())).ToList();
                else
                    dataGridView1.DataSource = db.PassedTests.Where(x => x.Name.ToLower().Contains(surNameTB.Text.ToLower())).Where(j => j.Test == test).ToList();
            }

        }
    }
}
