using Deventure.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Itec.Models.Models
{
    public class RegisterModel : IModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public int Radius { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        public string Password { get; set; }

        public string ProfilePicture { get; set; }
    }
}
