using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleTexDotNet.Classes
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int EmployeeId { get; set; } // Project Manager
        public int CustomerId { get; set; }
    }
}
