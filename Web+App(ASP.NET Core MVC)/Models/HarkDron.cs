using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_ASP.NET_Core_MVC_
{
    public partial class HarkDron
    {
        public int Id { get; set; }
        public int? Battery { get; set; }
        public int? Color { get; set; }
        public DateTime? DateVp { get; set; }
        public int? WhoIsAvto { get; set; }
        public string ImgDron { get; set; }

        public virtual ColorDron ColorNavigation { get; set; }
        public virtual Dron WhoIsAvtoNavigation { get; set; }
    }
}
