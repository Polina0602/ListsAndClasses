using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListsAndClasses;
using ListsAndClasses.Classes;

namespace ListsAndClasses.Classes
{
    class GreenLife
    {

       public int Paws = 4;

        /*        public GreenLife(int Paws)

                {

                    //AnimalName = PrivateName(AnimalName);

                }*/
        private string PrivateName(string AnimalName)
        {
            return AnimalName.ToUpper();
        }

    }
}
