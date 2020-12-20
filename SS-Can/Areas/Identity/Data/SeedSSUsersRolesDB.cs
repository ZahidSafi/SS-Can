using Microsoft.AspNetCore.Identity;
using SS_Can.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SS_Can.Areas.Identity.Data
{
    public class SeedSSUsersRolesDB
    {
        public static void SSRolesSeeding(SSUsersRolesDB context, RoleManager<IdentityRole> roles)
        {
            // Creating the database if not created
            context.Database.EnsureCreated();

            // seeing if roles exist
            if (roles.Roles.ToArray().Count() > 0)
            {
                return;
            }
            // then creating if they don't
            var Result = roles.CreateAsync(new IdentityRole("Student")).Result;
            var Result2 = roles.CreateAsync(new IdentityRole("Teacher")).Result;
            var Result3 = roles.CreateAsync(new IdentityRole("Administrator")).Result;

            context.SaveChanges();
        }

        public static void SSUsersSeeding(SSUsersRolesDB context, UserManager<SSUser> users)
        {
            // Creating the database if not created
            context.Database.EnsureCreated();

            //Admin User

            SSUser userAdmin = new SSUser();
            userAdmin.UserName = "ZahidSafi";
            userAdmin.Email = "zahidsafi956@gmail.com";
            userAdmin.EmailConfirmed = true;

            var admin = users.CreateAsync(userAdmin, "123ABC!@#def");
            admin.Wait();
            var resultAdmin = admin.Result;

            if (resultAdmin.Succeeded)
            {
                users.AddToRoleAsync(userAdmin, "Administrator").Wait();
            }

            //Admin User 2
            SSUser userAdmin2 = new SSUser();
            userAdmin2.UserName = "JabrailAhmed";
            userAdmin2.Email = "jabraila.ames@gmail.com";
            userAdmin2.EmailConfirmed = true;

            var admin2 = users.CreateAsync(userAdmin2, "123ABC!@#def");
            admin2.Wait();
            var resultAdmin2 = admin2.Result;

            if (resultAdmin2.Succeeded)
            {
                users.AddToRoleAsync(userAdmin2, "Administrator").Wait();
            }

            // Teacher User


            // Student User


        }
    }


}

