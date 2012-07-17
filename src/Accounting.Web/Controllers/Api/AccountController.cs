using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Accounting.Web.Models;
using Ploeh.AutoFixture;

namespace Accounting.Web.Controllers.Api
{
    public class AccountController : ApiController
    {
        private static readonly List<Account> _accounts = AccountRepo.FindAll().ToList();

        // GET /api/account
        public IEnumerable<Account> Get()
        {
            return _accounts;
        }

        public IEnumerable<Spot>  ListSpots(int accountId, int campaignId)
        {
            var account = _accounts.SingleOrDefault(a => a.Id == accountId);

            if (account != null)
            {
                var campaign = account.Campaigns.SingleOrDefault(c => c.Id == campaignId);

                if (campaign != null)
                {
                    return campaign.Spots;
                }
            }

            //should probably return a 404 to conform with RESTful specs...
            return Enumerable.Empty<Spot>();
        }

        internal class AccountRepo
        {
            internal static IEnumerable<Account> FindAll()
            {
                var fixture = new Fixture();

                var accounts = fixture.CreateMany<Account>(25).ToList();

                foreach (var account in accounts)
                {
                    var campaigns = fixture.CreateMany<Campaign>().ToList();

                    campaigns.ForEach(c => c.Spots = fixture.CreateMany<Spot>().ToList());

                    account.Campaigns = campaigns;
                }


                return accounts;
            }
        }
    }
}
