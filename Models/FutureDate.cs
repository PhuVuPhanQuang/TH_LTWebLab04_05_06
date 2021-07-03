using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TH_LTWebLab04_05_06.Models
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(Object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),"M/dd/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

                return (isValid && dateTime > DateTime.Now);
        }
    }
}