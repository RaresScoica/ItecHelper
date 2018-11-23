using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itec.Models.Custom
{
    public class CommentGetModel
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public string Creator { get; set; }

        public long CreatedAt { get; set; }

        public long EditedAt { get; set; }
    }
}
