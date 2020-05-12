using Parser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Metanit
{
    class MetanitSettings : IParserSettings
    {
        public MetanitSettings(string categoryName, 
                               string guideName, 
                               int startPart, 
                               int endPart, 
                               int startArticle, 
                               int endArticle)
        {
            CategoryName = categoryName;
            GuideName = guideName;
            StartPart = startPart;
            EndPart = endPart;
            StartArticle = startArticle;
            EndArticle = endArticle;
        }
        public string BaseUrl { get; set; } = "https://metanit.com";
        public string CategoryName { get; set; }
        public string GuideName { get; set; }
        public string PartNumber { get; set; } = "{CurrentPartNumber}";
        public string ArticleNumber { get; set; } = "{CurrentArticleNumber}";
        public int StartPart { get; set; }
        public int EndPart { get; set; }
        public int StartArticle { get; set; }
        public int EndArticle { get; set; }
    }
}
