using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
    }
}
