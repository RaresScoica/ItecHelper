using Deventure.Common.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Itec.Models.Models
{
    public class CommentModel : IModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid IssueId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

    }
}
