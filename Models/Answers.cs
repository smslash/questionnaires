using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAM.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime begin_date { get; set; }
        public int q1 { get; set; }
        public int q2 { get; set; }

        public string q3 { get; set; }

        public int q4 { get; set; }
        public string q5 { get; set; }
        public DateTime end_date { get; set; }
  }
}