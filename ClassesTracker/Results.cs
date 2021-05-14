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
        }
    }
}
