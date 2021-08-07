using System;
using System.Collections.Generic;

#nullable disable

namespace Web_App_ASP.NET_Core_MVC_
{
    public partial class Dron
    {
        public Dron()
        {
            HarkDrons = new HashSet<HarkDron>();
            Zakazs = new HashSet<Zakaz>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public int? Hark { get; set; }
        public int? Price { get; set; }
        public string Igm { get; set; }

        public virtual ICollection<HarkDron> HarkDrons { get; set; }
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
