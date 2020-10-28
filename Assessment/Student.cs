using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    class Student
    {
        private static List<Student> _list = new List<Student>();
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
            _list.Add(this);
        }

        internal static List<Student> GetStudents()
        {
            return _list;
        }
    }
}
