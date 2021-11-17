using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListsAndClasses.Classes;
using ListsAndClasses.Interfaces;


namespace ListsAndClasses.Classes
{
    class Animals : GreenLife, IAnimals
    {
    public string AnimalName { get; set; }
     public  string AnimalType { get; set; }

        public bool AnimalTail;

        public Animals()
        {

            AnimalName = AnimalName;
            AnimalType = AnimalType;

        }

        public void RunByPaws()
        {
            Console.WriteLine("Top,top,top");
        }

        //private string PrivateName(string AnimalName)
        //{
        //    return AnimalName.ToUpper();
        //}


    }


}
