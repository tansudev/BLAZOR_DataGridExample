using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLAZOR_DataGridExample.Data
{
    public class Pager
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get;  set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get;  set; }
        public int EndPage { get;  set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public IEnumerable<int> Pages { get; set; }

    }
}
