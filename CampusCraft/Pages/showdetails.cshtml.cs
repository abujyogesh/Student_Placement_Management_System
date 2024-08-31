using CampusCraft.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace CampusCraft.Pages
{
    public class showdetailsModel : PageModel
    {

        [BindProperty]
        public required DatabaseManager Reg { get; set; }



        public List<string[]> Data { get; set; }

        public void OnGet()
        {
            // Default behavior when the page is loaded
        }

        public void OnPost(string selectedField)
        {
            Data = FetchDataFromDatabase(selectedField);
        }

        private List<string[]> FetchDataFromDatabase(string selectedField)
        {
            var data = new List<string[]>();

            using (var connection = new MySqlConnection("server=localhost;username=root;database=campuscraft;port=3306;password=rohan@3136"))
            {
                connection.Open();
                var query = $"SELECT * FROM `{selectedField}`";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rowData = new string[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            rowData[i] = reader.GetValue(i).ToString();
                        }
                        data.Add(rowData);
                    }
                }
            }

            return data;
        }
    }
}




