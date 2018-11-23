using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.Models.Custom
{
    public class StatisticsModel
    {
        public float HealthIndex { get; set; }

        public List<MonthlyIssuesModel> MonthlyData { get; set; }

        public List<HumanStats> HumanStats { get; set; }

    }
}
