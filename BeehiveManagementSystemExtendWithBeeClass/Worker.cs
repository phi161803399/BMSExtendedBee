using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystemExtendWithBeeClass
{
    public class Worker: Bee
    {
        private const double extraHoneyUnitsPerShift = 0.65;
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string _currentJob;

        public string CurrentJob
        {
            get
            {
                return _currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public Worker(string[] jobs, double weightMg):
            base(weightMg)
        {
            jobsICanDo = jobs;
        }

        public bool DoThisJob(string jobToDo, int shifts)
        {
            if (String.IsNullOrEmpty(CurrentJob))
            {
                foreach (var job in jobsICanDo)
                {
                    if (job == jobToDo)
                    {
                        _currentJob = jobToDo;
                        shiftsToWork = shifts;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(CurrentJob)) return false;
            // the worker works a shift
            shiftsWorked++;
            // keep track of ShiftsLeft

            // if job is done, CurrentJob = "" 
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                _currentJob = string.Empty;
                return true;
            }
            // return true when ShiftsLeft == 0 else return false
            return false;
        }

        public override double HoneyConsumpionRate()
        {
            return shiftsWorked * extraHoneyUnitsPerShift + base.HoneyConsumpionRate();
        }
    }
}
