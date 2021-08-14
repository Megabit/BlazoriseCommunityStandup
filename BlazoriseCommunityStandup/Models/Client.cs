using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using BlazoriseCommunityStandup.Validation;

namespace BlazoriseCommunityStandup.Models
{
    public class Client
    {
        public long Identification { get; set; }
        [Required( ErrorMessage = "Please insert your Name" )]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [RequiredBoolean( "Make sure that you've read the terms and conditions and that you agree to them." )]
        public bool AcceptedTermsAndConditions { get; set; }

        public string Branch { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
