using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }
        string CategoryName { get; set; }
        string GuideName { get; set; }
        string PartNumber { get; set; }
        string ArticleNumber { get; set; }
        int StartPart { get; set; }
        int EndPart { get; set; }
        int StartArticle { get; set; }
        int EndArticle { get; set; }
    }
}
