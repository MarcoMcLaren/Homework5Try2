using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework5Try2.Models
{
    public class BookDetailsVM
    {
        public IEnumerable<borrows> borrows { get; set; }
        public IEnumerable<students> students { get; set; }
        public IEnumerable<books> books { get; set; }
    }
}