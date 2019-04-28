using System;
using System.Windows.Forms;

namespace BeehiveManagementSystemExtendWithBeeClass
{
    public partial class Form1 : Form
    {
        Queen queen;
        Worker[] workers;
        public Form1()
        {
            InitializeComponent();
            cmbWorkerBeeJob.SelectedIndex = 0;
            CreateWorkerArray();
            queen = new Queen(workers, 275);
        }

        private void CreateWorkerArray()
        {
            workers = new Worker[4]
            {
                new Worker(new string[] {"Nectar collector", "Honey manufacturing"}, 175),
                new Worker(new string[] {"Egg care", "Baby bee tutoring"}, 114),
                new Worker(new string[] {"Hive maintenance", "Sting patrol"}, 149),
                new Worker(new string[] {"Nectar collector","Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"}, 155)
            };
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            string message;
            string job = cmbWorkerBeeJob.Text;
            int numberOfShifts = (int)shifts.Value;
            if (queen.AssignWork(job, numberOfShifts))
            {
                message = $"Job: '{job}' assigned to a worker for {numberOfShifts} shifts";
            }
            else
            {
                message = $"No worker available for '{job}'";
            }
            MessageBox.Show(message, "The queen bee says...");
        }

        private void btnWorkNextShift_Click(object sender, EventArgs e)
        {
            string report = queen.WorkTheNextShift();
            txtReport.Text = report;
        }
    }
}
