using CampusCraft.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace CampusCraft.Pages
{
    public class crowdstrikeModel : PageModel



         
    {



        [BindProperty]
        public required crowdstrike Reg { get; set; }

        public void OnPost()
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string idnumber = Request.Form["idnumber"];
            string gender = Request.Form["gender"];
            string per12 = Request.Form["per12"];
            string pergra = Request.Form["pergra"];
            string resume = Request.Form["resume"];
            string cover = Request.Form["coverletter"];





            using (MySqlConnection con = new MySqlConnection("server=localhost;username=root;database=campuscraft;port=3306;password=rohan@3136"))
            {
                //opening connection
                con.Open();

                //Inserting values
                MySqlCommand comm = con.CreateCommand();
                comm.CommandText = "INSERT INTO crowdstrike(name,email,collegeid,12per,graper,gender,cover) VALUES(?name, ?email, ?idnumber, ?per12, ?pergra, ?gender, ?cover)";

                comm.Parameters.AddWithValue("?name", name);
                comm.Parameters.AddWithValue("?email", email);
                comm.Parameters.AddWithValue("?idnumber", idnumber);
                comm.Parameters.AddWithValue("?per12", per12);
                comm.Parameters.AddWithValue("?pergra", pergra);
                comm.Parameters.AddWithValue("?gender", gender);

                comm.Parameters.AddWithValue("?cover", cover);









                //passing the query and connection var to command
                //MySqlCommand cmd = new MySqlCommand(query, con);

                //Execute command
                comm.ExecuteNonQuery();

                con.Close();
            }

        }
        public void OnGet()
        {
        }
    }
}
