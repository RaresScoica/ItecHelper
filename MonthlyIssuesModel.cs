using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.Models.Custom
{
    public class MonthlyIssuesModel
    {
        public int MonthNumber { get; set; }

        public string MonthName { get; set; }
        public int SolvedIssues { get; set; }

        public int CreatedIssues { get; set; }

    }
}
