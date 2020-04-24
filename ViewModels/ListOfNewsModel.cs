using System;
using System.Collections.Generic;


namespace COVID19_hackthon_project.Models
{
    public class ListOfNewsModel
    {
        public List<NewsModel> List {get; set;}
        public string titleString {get; set;}
        public string authorsString {get; set;}
        public string abstractString {get; set;}
        public string journalString {get; set;}
        public string filterCount {get; set;}
        public int resultCount {get; set;}

    }
}
