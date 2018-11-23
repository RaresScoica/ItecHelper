using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.Models.Custom
{
    public class UserData
    {
        public Guid Id { get; set; }

        public string AspNetUserId { get; set; }

        public string FullName { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int Radius { get; set; }

        public int Age { get; set; }

        public int Gender { get; set; }

        public string ProfilePicture { get; set; }

        public virtual ICollection<IssueGeModel> Issues { get; set; }
    }
}
