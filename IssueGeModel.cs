using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.Models.Custom
{
    public class IssueGeModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public int UpVotes { get; set; }

        public int DownVotes { get; set; }

        public long CreatedAt { get; set; }

        public Guid CreatedBy { get; set; }

        public virtual string Creator { get; set; }

        public virtual ICollection<CommentGetModel> Comments { get; set; }

        public virtual ICollection<string> Images { get; set; }
    }
}
