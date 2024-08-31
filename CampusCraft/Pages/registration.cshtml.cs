using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using CampusCraft.Models;
namespace CampusCraft.Pages
{
    public class registrationModel : PageModel
    {

        [BindProperty]
        public required Register Reg { get; set; }
        public void OnPost()
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string phoneno = Request.Form["phno"];
            string gender = Request.Form["gender"];
            string password = Request.Form["password"];
            

            using (MySqlConnection con = new MySqlConnection("server=localhost;username=root;database=campuscraft;port=3306;password=rohan@3136"))
            {
                //opening connection
                con.Open();

                //Inserting values
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO student(name,email,mobile_number,password,gender) VALUES(?name, ?email, ?phoneno, ?password, ?gender)";

                comm.Parameters.AddWithValue("?name", name);
                comm.Parameters.AddWithValue("?gender", gender);
               
                comm.Parameters.AddWithValue("?phoneno", phoneno);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?password", password);
               

                //passing the query and connection var to command
                //MySqlCommand cmd = new MySqlCommand(query, con);

                //Execute command
                comm.ExecuteNonQuery();

                con.Close();
            }

        }
    }
}






