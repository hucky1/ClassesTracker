using ClassesTrackerUI.Interfaces;
using System;
using System.Windows.Forms;
using TrackerModel;
using TrackerModel.Controllers;

namespace ClassesTrackerUI
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //MainMenu.ItemClicked += OPe
        }

        private void OpenResults(object sender, EventArgs e)
        {
            Results results = new();
            results.Show();
        }
        private void OpenTest(object sender, EventArgs e)
        {
            ITesting testing; 
            string test = sender.ToString();
            
            if (test == "Задания")
            {
                testing = new Tasks();
            }
            else
            {
                testing = new Testing(test);
            }
            
            TestingController testingController = new(testing);
            testing.Show();
        }

        private void TheoryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                theoryRTB.LoadFile(Environment.CurrentDirectory + string.Format($"\\theory\\{TheoryModel.TheoryFiles[theoryTreeView.SelectedNode.Text]}"));
            }
            catch (Exception)
            {
                theoryRTB.LoadFile(Environment.CurrentDirectory + string.Format($"\\theory\\{TheoryModel.TheoryFiles["Стартовая"]}"));
            }
        }
    }
}
