using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemExtendWithBeeClass
{
    public class Queen: Bee
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers, double weightMg):
            base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(job, shifts)) return true;
            }
            return false;
        }

        internal string WorkTheNextShift()
        {
            shiftNumber++;
            int workerNumber = 1;
            string report = $"Report for shift #{shiftNumber}" + Environment.NewLine;
            double honeyConsumption = HoneyConsumpionRate();
            foreach (Worker worker in workers)
            {
                // check if worker is finished
                if (worker.DidYouFinish())
                {
                    report += $"Worker #{workerNumber} finished the job" + Environment.NewLine;
                }
                // check if worker is iddle
                if (string.IsNullOrEmpty(worker.CurrentJob))
                {
                    report += $"Worker #{workerNumber} not working" + Environment.NewLine;
                }
                else
                {
                    if (worker.ShiftsLeft > 0)
                    {
                        report += $"Worker #{workerNumber} is doing '{worker.CurrentJob}' for {worker.ShiftsLeft} more shifts" + Environment.NewLine;
                    }
                    else
                    {
                        report += $"Worker #{workerNumber} will be done with '{worker.CurrentJob}' after this shift" + Environment.NewLine;
                    }
                }
                workerNumber++;
                honeyConsumption += worker.HoneyConsumpionRate();
            }
            report += $"Total honey consumed for the shift: {honeyConsumption} units" + Environment.NewLine;
            return report;
        }
    }
}
