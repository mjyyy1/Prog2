using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    public abstract class Human
    {
        public string _purchase;
        public string _animal;

        public List<Human> pets = new List<Human>();

        public String Animal
        {
            get { return _animal; }
            set { _animal = value; }
        }


        public void BuyAnimal(string Purchase)
            {
                _purchase = Purchase;
            }
        
    }
}
