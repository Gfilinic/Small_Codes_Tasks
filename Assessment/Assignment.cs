using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    class Assignment
    {
        
        public string Name { get; set; }
        public int MaximumScore { get; set; }

        public override string ToString()
        {
            return this.Name + "(" + MaximumScore + ")";
        }

        public Assignment(string name, int max)
        {
            this.Name = name;
            this.MaximumScore = max;
           
        }
    }
}
