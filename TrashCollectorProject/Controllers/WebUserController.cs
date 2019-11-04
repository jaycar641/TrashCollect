using Microsoft.AspNet.Identity;
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
        List<Customer> displayCustomers = new List<Customer>();

        public WebUserController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {

            foreach (Customer customer in context.customers)
            {
                displayCustomers.Add(customer);
            }
            /// check and see if user is null and then which user it is
            string idUser = User.Identity.GetUserId();

            if (idUser == null)//IF NOT LOGGED IN
            {
                //can use sign in manager
                return RedirectToAction("Index", "Home");
            
            }
            //else //add an if statement in role name = employee that 
            else
            {
                string id = User.Identity.GetUserId();
                var user = context.Users.Where(e => e.Id == id).SingleOrDefault(); //returns user
                var role = context.Roles.Where(e => e.Name == "Employee").Single();
                if (role.Name == "Employee")
                {

                    try
                    {
                        return RedirectToAction("Edit", "WebUser");


                    }

                    catch
                    {
                        return RedirectToAction("Home", "Account");

                    }
                    //CHECK IF PROFILE CREATED: if there are no employees with the current user id as their forieng key, then create employee, else select that employee and go to dashboard




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

                }
                //Create();
                return View();
            }
        }

        // GET: WebUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebUser/Create
        public ActionResult CreateEmployee()
        {


            return View();
        }

        // POST: WebUser/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee(Employee employee)
        {
            string id = User.Identity.GetUserId();
            var getUser = context.Users.Where(e => e.Id == id).FirstOrDefault(); //returns user
            Employee employee1 = new Employee();
            employee1.ApplicationUserId = getUser.Id; //se
            //checks role of user and posts to that database
            try
            {
                employee1.firstName = employee.firstName;
                employee1.lastName = employee.lastName;
                employee1.zipcode = employee.zipcode;
                context.SaveChanges();

                return Edit(employee1);
               // return RedirectToAction("Edit", "WebUser");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateCustomer()
        {


            return View();
        }

        // POST: WebUser/Create
        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {

            //checks role of user and posts to that database
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
        public ActionResult Edit(Employee employee)
        {
            Employee employee1 = new Employee();

            employee1 = context.employees.Where(e => e.Id == employee.Id).SingleOrDefault();
            //var zipcodeList = displayCustomers.Where(e => e.zipcode == employee1.zipcode);

            return View(displayCustomers);
        }

        // POST: WebUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id)
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
