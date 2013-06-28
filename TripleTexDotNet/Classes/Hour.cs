using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Classes
{
    public class Hour
    {
        public int Id { get; set; }
        public int Revision { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public int ActivityId { get; set; }
        public string Date { get; set; }
        public double Hours { get; set; }
        public string Comment { get; set; }
    }
}
