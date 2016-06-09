using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Computer
    {
        /// <summary>
        /// Properties.
        /// </summary>
        private string _model;
        private string _size;

        /// <summary>
        /// Here I declare the Variables.
        /// </summary>
        public string model { 

            get
            
            {
                return _model;

            }


            set
            {
                _model = value;
            }



        }

        /// <summary>
        /// Aqui utilizo void porque no quiero que regrese nada.
        /// </summary>
        

        public void turnOn()
        {


        }


        public void turnOff()
        {


        }
    }
}
