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

    class Rocket
    {
        void Rocket()
        {

        }
        public string Divider()
        {
            return "+=*=*=*=*=*=*+";
        }
        string[] upDesigns = 
        {
            @"|../\..../\..|"
            , @"|./\/\../\/\.|"
            , @"|/\/\/\/\/\/\|"
        };
        string[] downDesigns = 
        {
            @"|\/\/\/\/\/\/|"
            , @"|.\/\/..\/\/.|"
            , @"|..\/....\/..|"
        };

        //Create the Nose and Engine Method

        public void fuselage(bool diamondShape)
        {
            //Divider should be called during construction of Rocket
            if (diamondShape)
            {
                foreach (string line in upDesigns)
                {
                    Console.WriteLine(line);
                }
                foreach (string line in downDesigns)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                foreach (string line in downDesigns)
                {
                    Console.WriteLine(line);
                }
                foreach (string line in upDesigns)
                {
                    Console.WriteLine(line);
                }
            }
        }

        

    }
}
