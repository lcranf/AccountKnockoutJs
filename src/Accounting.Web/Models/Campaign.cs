using System.Collections.Generic;

namespace Accounting.Web.Models
{
    public class Campaign : EntityBase
    {
        public List<Spot> Spots { get; set; }
    }
}