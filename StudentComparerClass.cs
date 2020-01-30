using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace StudentComparer
{/// <summary>
///  Example of  IComparer interface implementation
/// </summary>
    class StudentComparerClass:IComparer<StudentComparerClass>
    {
        public int marks { get; set; }
        public String name { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StudentComparerClass p = new StudentComparerClass();
            List<StudentComparerClass> list = new List<StudentComparerClass>();
            list.Add(new StudentComparerClass() { name = "Sree", marks = 10054 });
            list.Add(new StudentComparerClass() { name = "Janu", marks = 1088996 });
            list.Add(new StudentComparerClass() { name = "Ameer", marks = 1008896 });
            list.Add(new StudentComparerClass() { name = "Balu", marks = 500896 });
            list.Add(new StudentComparerClass() { name = "manu", marks = 8000986 });
            list.Sort(p);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


        }
        /// <summary>
        /// Method to compare two objects
        /// </summary>
        public int Compare([AllowNull] StudentComparerClass x, [AllowNull] StudentComparerClass y)
        {
           
                if (x.marks > y.marks) return 1;
                else if (x.marks < y.marks) return -1;
                else return 0;
            
            // throw new NotImplementedException();
        }
        /// <summary>
        /// Overriding To string method
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string ToString()
        {
            // String representation.
            return this.marks.ToString() + "," + this.name;
        }
    }
}
