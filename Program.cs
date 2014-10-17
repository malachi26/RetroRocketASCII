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
        
        void Rocket()
        {

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

        

    }
}
