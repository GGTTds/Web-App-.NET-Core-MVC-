using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_ASP.NET_Core_MVC_
{
    public partial class Zakaz
    {
        public int NomerZakaza { get; set; }
        public DateTime? DateZak { get; set; }
        public int? WhoIszak { get; set; }
        public string AddresDost { get; set; }
        public int? Status { get; set; }
        public int? Transprt { get; set; }
        public int? Operator { get; set; }
        public int? CurrZak { get; set; }

        public virtual Dron CurrZakNavigation { get; set; }
        public virtual ToSatu StatusNavigation { get; set; }
        
    }
}
