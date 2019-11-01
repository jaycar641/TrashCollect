﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashCollectorProject.Models;

[assembly: OwinStartupAttribute(typeof(TrashCollectorProject.Startup))]
namespace TrashCollectorProject
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();

        }


        private void createRolesandUsers()
        {

            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if(!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Customer"))
            {
                var role1 = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role1.Name = "Customer";
                roleManager.Create(role1);
           }

         
        }



    }
}