using System;
using System.Collections.Generic;

namespace StudentComparableClassMain
{
    /// <summary>
    ///  Example of  IComparable interface implementation
    /// </summary>
    class StudentComparableClass :IComparable<StudentComparableClass>
    {
        public int marks { get; set; }
        public String name { get; set; }
        /// <summary>
        /// Method to compare objects
        /// </summary>
      
        public int CompareTo(StudentComparableClass other)
        {
            return this.marks.CompareTo(other.marks);
            //throw new NotImplementedException();
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
        static void Main(string[] args)
        {
            List<StudentComparableClass> list = new List<StudentComparableClass>();
            list.Add(new StudentComparableClass() { name = "Sree", marks = 10054 });
            list.Add(new StudentComparableClass() { name = "ram", marks = 1088966 });
            list.Add(new StudentComparableClass() { name = "Ameer", marks = 10088 });
            list.Add(new StudentComparableClass() { name = "Balu", marks = 500898 });
            list.Add(new StudentComparableClass() { name = "manu", marks = 8089 });
            list.Sort();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

        }
    }
}
