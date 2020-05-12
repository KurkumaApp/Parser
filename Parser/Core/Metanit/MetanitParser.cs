using AngleSharp;
using AngleSharp.Browser;
using AngleSharp.Html.Dom;
using Parser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Metanit
{
    class MetanitParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            //IHtmlDocument divElement;
            var list = new List<string>();
            //divElement = (IHtmlDocument)document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("articleText"));
            //var items = divElement.QuerySelectorAll("p");

            //foreach(var item in items)
            //{
            // list.Add(item.TextContent);
            //}
            var items = document.QuerySelectorAll("p");

            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}
