using System.Data.Entity;
using Cookery.WebUI.Models.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cookery.WebUI.Infrastructure.Identity
{
    public class AppIdentityEntitiesContext : IdentityDbContext<AppUser>
    {
        public AppIdentityEntitiesContext() : base("name=IdentityEntities") { }

        static AppIdentityEntitiesContext()
        {
            Database.SetInitializer<AppIdentityEntitiesContext>(new IdentityEntitiesInit());
        }

        public static AppIdentityEntitiesContext Create()
        {
            return new AppIdentityEntitiesContext();
        }
    }

    public class IdentityEntitiesInit : NullDatabaseInitializer<AppIdentityEntitiesContext>
    { }
}