using System;
using System.Diagnostics.CodeAnalysis;

namespace StudentEquatable
{/// <summary>
/// Example of IEquatable
/// </summary>
    class StudentEquatableClass:IEquatable<StudentEquatableClass>
    {
        static void Main(string[] args)
        {
            StudentEquatableClass obj1 = new StudentEquatableClass();
            obj1.marks = 50;
            obj1.name = "a";
            StudentEquatableClass obj2 = new StudentEquatableClass();
            obj2.marks = 50;
            obj2.name = "a";
            Console.WriteLine(obj1.Equals(obj2));
        }
        /// <summary>
        /// Checks whether the objects are equal or not
        /// </summary>
        /// <returns> Returns true if equal and false if unequal</returns>
        public bool Equals([AllowNull] StudentEquatableClass other)
        {
            if (other == null) return false;
            return (this.marks.Equals(other.marks));
            //throw new NotImplementedException();
        }

        public int marks { get; set; }
        public String name { get; set; }

    }
}
