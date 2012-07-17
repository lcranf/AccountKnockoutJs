using System.Collections.Generic;

namespace Accounting.Web.Models
{
    public class Account : EntityBase
    {
        public IEnumerable<int> CampaignIds
        {
            get { return Campaigns.ConvertAll(c => c.Id); }
        }

        public List<Campaign> Campaigns { get; set; }
    }
}