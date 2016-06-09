using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Desktop : Computer
    {

        /// <summary>
        /// properties
        /// </summary>
        private bool _hasSpeakers;
        private int _harddriveCapacity;



        public bool hasSpeakers {

            get

            {
                return _hasSpeakers;

            }



            set {

                _hasSpeakers = value;

            }






        }

        public int harddriveCapacity
        {

            get

            {
                return harddriveCapacity;

            }



            set
            {

                harddriveCapacity = value;

            }


        }
        /// <summary>
        /// Objects
        /// </summary>
        public Desktop()
        {
            Console.WriteLine(" Your desktop has been created");

        }
        /// <summary>
        /// Overload 1
        /// </summary>
        /// <param name="value1"></param>
        public Desktop(bool value1)
        {

            _hasSpeakers = value1;

        }
        

        /// <summary>
        /// Overload 2
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public Desktop(bool value1, int value2)
        {
            _hasSpeakers = value1;
            _harddriveCapacity = value2;
        }

}





















}

       
        


        


        


























