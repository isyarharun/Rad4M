using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Model.Classes
{
    public class ToDo : MainClass
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PercentOfComplete { get; set; }
        public DateTime Expired { get; set; }
    }
}
