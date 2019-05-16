using EntityFrameworkStartingPoint.Controllers.ResponseObjects;
using EntityFrameworkStartingPoint.Data;
using EntityFrameworkStartingPoint.RequestObjects;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkStartingPoint.Extensions
{
    public static class Extensions
    {
        public static UniverseListResponse ToListResponse(this IEnumerable<Universe> me)
        {
            var resp = new UniverseListResponse();
            
            resp.TotalResults = me.Count();
            resp.Items = me.Select(x => x.ToListItem()).ToList();

            return resp;
        }

        public static UniverseListItem ToListItem(this Universe me)
        {
            return new UniverseListItem()
            {
                ParentCompany = me.ParentCompany,
                UniverseId = me.UniverseId,
                UniverseName = me.Name
            };
        }

        public static Universe ToDbItem(this UniverseAddRequest me, Universe updating = null)
        {
            if(updating == null)
            {
                updating = new Universe();
            }
            updating.Name = me.UniverseName;
            updating.ParentCompany = me.ParentCompany;
            return updating;
        }
    }
}
