using System;
namespace HELLOWORLD
{
    public class Person
    {
        //  fields
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Great()
        {
                Console.WriteLine($"Hello my friend : {Name}");    
        }   
    }
    
}