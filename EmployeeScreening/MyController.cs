using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace EmployeeScreening
{
    [Route("api/[controller]")]
    public class localWeather : ControllerBase
    {
        public string con = "Data Source=demo.db";

        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(string guid) {

            string queryString = $"Select *  from  Users where id = '{guid}'";
            SqliteConnection connection = new SqliteConnection(this.con);
            //SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
            SqliteCommand command = new SqliteCommand(queryString, connection);
            connection.Open();
            IDataReader reader = command.ExecuteReader();
            reader.Read();
            var long_VALUE = reader["latitude"];
            var lat_VALUE = reader["longitude"];
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Stackoverflow/1.0");
            string uri = $"https://api.weather.gov/points/{long_VALUE},{lat_VALUE}";
            var response = await client.GetAsync($"https://api.weather.gov/points/{long_VALUE},{lat_VALUE}");
            string responseBody = await response.Content.ReadAsStringAsync();

            if (responseBody != null && responseBody != "") {
                /*RETURN person json from external api */
                return Ok(responseBody);
            }



            /*fail */
            return NotFound();


        } 
    
    
  }
}
