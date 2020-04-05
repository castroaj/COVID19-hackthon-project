using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using COVID19_hackthon_project.Models;
using Microsoft.Data.Sqlite;

namespace COVID19_hackthon_project.Controllers
{
    public class ResearchController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ListOfNewsModel defaultNewsData;

        public ResearchController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            defaultNewsData = new ListOfNewsModel(){
                defaultList = getDefaultNewsData()
            };
            return View(defaultNewsData);
        }

        public List<NewsModel> getDefaultNewsData()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            List<NewsModel> listOfNewsData = new List<NewsModel>();
            connectionStringBuilder.DataSource = "./COVID19.sqlite";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var selectData = connection.CreateCommand();

                selectData.CommandText = "SELECT Title, Authors, Abstract, Year, Journal, DOI FROM news ORDER BY NewsID LIMIT 10;";

                using (var reader = selectData.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        NewsModel curModel = new NewsModel();
                        for (int i = 0; i < 6; i++)
                        {
                            if (!reader.IsDBNull(i))
                            {
                                switch (i)
                                {
                                    case 0:
                                        curModel.Title = reader.GetString(i);
                                        break;
                                    case 1:
                                        curModel.Authors = reader.GetString(i);
                                        break;
                                    case 2:
                                        curModel.Abstract = reader.GetString(i);
                                        break;
                                    case 3:
                                        curModel.Year = reader.GetString(i);
                                        break;
                                    case 4:
                                        curModel.Journal = reader.GetString(i);
                                        break;
                                    case 5:
                                        curModel.DOI = reader.GetString(i);
                                        break;
                                } 
                            }
                        }
                        listOfNewsData.Add(curModel);
                    }
                }

                connection.Close();
            }

            Console.WriteLine("Sucessfully loaded default news data");
            return listOfNewsData;
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
