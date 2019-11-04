using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollectorProject.Models;

namespace TrashCollectorProject.Controllers
{
    public class WebUserController : Controller
    {
        // GET: WebUser
        ApplicationDbContext context;

        public WebUserController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            /// check and see if user is null and then which user it is
            // string idUser = User.Identity.GetUserId();

            //if (idUser == null)
            //{
            //    //can use sign in manager logged in property
            //    return View();
            //}
            //else //add an if statement in role name = employee that 
            //{
            //    string id = User.Identity.GetUserId();
            //    var user = context.Users.Where(e => e.Id == id).SingleOrDefault(); //returns user
            //    var role = context.Roles.Where(e => e.Name == "Employee").Single();
            //    if (role.Name == "Employee")
            //    {
            //        //find way to check user first and last name and zipcode
            //        //checks to see if profile is complete


            //        return RedirectToAction("Index", "WebUser");
            //        //  CreateEmployee();
            //        //   return RedirectToAction("CreateEmployee", "Home");
            //        //if complete goes to employee homepage, or shows all information by passing a complete model, as opposed to a incomplete customer model
            //    }


            //    else
            //    {
            //        return RedirectToAction("CreateCustomer", "Home");

            //    }

            //}
            Create();
            return View();
        }

        // GET: WebUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebUser/Create
        public ActionResult Create()
        {

            if (net)
            return View();
        }

        // POST: WebUser/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WebUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        //public ActionResult CreateEmployee()
        //{


        //    ////passing employee that is equal to user, to essential edit employee

        //    //string id = applicationUser.Id;
        //    ////gets the id of the user]

        //    //var user = context.Users.Where(e => e.Id == id).FirstOrDefault(); //returns user
        //    Employee employee1 = new Employee();
        //    //employee1.ApplicationUserId = user.Id; //sets new employee with new application id and passes it, it will save in pose
        //    //return RedirectToAction("CreateEmployee", "Account");
        //    //  return View(); //model will get the employee with a application id
        //    return View(employee1);
        //}

        //// POST: /Account/Register
        //[HttpPost]
        //public ActionResult CreateEmployee(Employee employee)
        //{

        //    string id = User.Identity.GetUserId();
        //    var user = context.Users.Where(e => e.Id == employee.ApplicationUserId).SingleOrDefault(); //returns user


        //    try
        //    {
        //        Employee employee1 = context.employees.Where(e => e.Id == employee.Id).SingleOrDefault(); //returns employee out database
        //                                                                                                  // employee1.firstName = employee.firstName; 
        //                                                                                                  //employee1.lastName = employee.lastName;
        //                                                                                                  //employee1.zipcode = employee.zipcode;

        //        context.SaveChanges();
        //        //if this does not update the Usertable automatically then we have to set the applicationuser to whats being done
        //        return RedirectToAction("Index", "Home");
        //    }
        //    catch
        //    {
        //        return View();
        //    }


        //}

        //[AllowAnonymous]
        //public ActionResult CreateCustomer()
        //{
        //    return View();

        //}

        //// POST: /Account/Register
        //[HttpPost]
        //[AllowAnonymous]
        //public ActionResult CreateCustomer(Customer customer)
        //{

        //    return RedirectToAction("Index", "Home");

        //}















    }
}
