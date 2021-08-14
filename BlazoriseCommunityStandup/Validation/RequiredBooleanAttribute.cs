using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.ModelBinding;

using Microsoft.AspNetCore.Mvc;

namespace BlazoriseCommunityStandup.Validation
{

    public class RequiredBooleanAttribute : ValidationAttribute
    {
        public RequiredBooleanAttribute() : base()
        {

        }

        public RequiredBooleanAttribute(string errorMessage) : base(errorMessage)
        {

        }
        public override bool IsValid( object value )
            => value != null && bool.TryParse( value.ToString(), out bool result ) && result;

    }
}
