using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_ASP.NET_Core_MVC_
{
    public partial class ColorDron
    {
        public ColorDron()
        {
            HarkDrons = new HashSet<HarkDron>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HarkDron> HarkDrons { get; set; }
    }
}
