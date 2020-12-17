using Microsoft.AspNetCore.Identity;
using SS_Can.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Areas.Identity.Data
{
    public class SSUserInitalizer
    {

        public static void Initialize(SSUsersRolesDB context, UserManager<SSUser> users, RoleManager<IdentityRole> roles)
        {
            SeedSSUsersRolesDB.SSRolesSeeding(context, roles);
            SeedSSUsersRolesDB.SSUsersSeeding(context, users);
        }

    }
}
