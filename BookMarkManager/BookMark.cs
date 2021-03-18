using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarkManager
{
    class BookMark
    {
        public string naam { get; set; }
        public string url { get; set; }
        public BookMark(string n,string u)
        {
            naam = n;
            url = u;
        }
        public void OpenSite()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", url);
        }
        public string Toon()
        {
            return naam + " : " + url;
        }
    }
}
