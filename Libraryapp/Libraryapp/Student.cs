using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryapp
{
    class Student
    {
        private String name;

        public  String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student() { }

        public Student(String name,String id,String department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
           
        }
         public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Department:" + department);
            Console.WriteLine("Cgpa:" + cgpa);
        }
        



    }
}
