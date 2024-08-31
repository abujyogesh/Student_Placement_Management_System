using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using CampusCraft.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using MySqlX.XDevAPI.Common;
using System;
using Mysqlx.Resultset;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace CampusCraft.Pages
{
    public class placelogModel : PageModel
    {

        [BindProperty]
        public required placelog log { get; set; }


        public RedirectToPageResult OnPost()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            using (MySqlConnection con = new MySqlConnection("server=localhost;username=root;database=campuscraft;port=3306;password=rohan@3136"))
            {
                //opening connection
                con.Open();
                var command = new MySqlCommand("SELECT COUNT(*) FROM placement WHERE username = @username AND password = @password", con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                var result = (long)command.ExecuteScalar();
                if (result == 1)
                {
                    // Successful sign-in logic
                    return RedirectToPage("/showdetails"); // Redirect to dashboard page
                }
                else
                {
                    // Failed sign-in logic
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                    return RedirectToPage("/index");  // Reload sign-in page with error message


                    con.Close();

                }

            }

        }
    }
}