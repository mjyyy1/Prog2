using System;
using System.Collections.Generic;
using System.Text;

namespace OopIntro
{
    class Person
    {

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        

         int _age;

         Pets _pet;


        public Person(string name,int age, Pets pet)
        {
            _name = name;
            _age = age;
            _pet = pet;

        }

        public void ActivatePet()
        {

            _pet.Poop();

        }
        public void Eat()
        {
            Console.WriteLine(_name + " is eating!");
        }


        public void Sleep()
        {
            Console.WriteLine(_name + " is not sleeping");
        }
    }
}
