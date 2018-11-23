using System;
using System.ComponentModel.DataAnnotations;

namespace Itec.Models.Models
{
    public class IssueVoteModel
    {
        [Required]
        public Guid IssueId { get; set; }

        [Required]
        public int VoteType { get; set; }
    }
}
