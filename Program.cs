using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///Inspired by various questions on StackExchange
///http://codereview.stackexchange.com/q/65040/18427
///@rolfl's question about these rockets
///

namespace RetroRocketASCII
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class VerticalRocket
    {
        private int _FuselageSections = 2;
        public int FuselageSections
        {
            get
            {
                return _FuselageSections;
            }
            set
            {
                if (value < 100 && value > 0)
                {
                    _FuselageSections = value;
                }
            }
        }

        public string rocketString
        {
            get;
            set;
        }

        private string Divider = "+=*=*=*=*=*=*+";
        private string[] upDesigns = 
        {
            @"|../\..../\..|"
            , @"|./\/\../\/\.|"
            , @"|/\/\/\/\/\/\|"
        };
        private string[] downDesigns = 
        {
            @"|\/\/\/\/\/\/|"
            , @"|.\/\/..\/\/.|"
            , @"|..\/....\/..|"
        };

        private string[] NoseOrBooster = 
        {
            @"     /**\"
            , @"    //**\\"
            , @"   ///**\\\"
            , @"  ////**\\\\"
            , @" /////**\\\\\"
        };

        void Rocket()
        {
             
        }
        

        //Create the Nose and Engine Method
        
        public string fuselage(bool diamondShape)
        {
            //Divider should be called during construction of Rocket
            string fuselage = null;
            if (diamondShape)
            {
                foreach (string line in upDesigns)
                {
                    fuselage += line + Environment.NewLine;
                }
                foreach (string line in downDesigns)
                {
                    fuselage += line + Environment.NewLine;
                }
            }
            else
            {
                foreach (string line in downDesigns)
                {
                    fuselage += line + Environment.NewLine;
                }
                foreach (string line in upDesigns)
                {
                    fuselage += line + Environment.NewLine;
                }
            }
            return fuselage;
        }
        public string noseBooster()
        {
            string noseBooster = null;
            foreach (string line in NoseOrBooster)
            {
                noseBooster += line + Environment.NewLine;
            }
            return noseBooster;
        }


        /* thoughts for munching
         * should I make all of these return string arrays?
         * or maybe string lists that can then be stacked?
         * would I be able to output them from the object in a to string Method? 
         * YES, YES and YES!
         */

        public string rocket(int sections)
        {
            bool wantDiamond = sections % 2 == 0 ? false : true;
           
        }
        

    }
}
