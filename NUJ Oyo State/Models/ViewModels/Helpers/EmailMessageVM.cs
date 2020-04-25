using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NUJ_Oyo_State.Models.ViewModels.Helpers
{
    public class EmailMessageVM
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}