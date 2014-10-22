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
            VerticalRocket rocket1 = new VerticalRocket(1);
            VerticalRocket rocket2 = new VerticalRocket();
            VerticalRocket rocket3 = new VerticalRocket(3);
            VerticalRocket rocket4 = new VerticalRocket(4);

            Console.Write(rocket1.ToString());
            Console.ReadLine();
            Console.Write(rocket2.ToString());
            Console.ReadLine();
            Console.Write(rocket3.ToString());
            Console.ReadLine();
            Console.Write(rocket4.ToString());
            Console.ReadLine();
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
                if (value <= 100 && value > 0)
                {
                    _FuselageSections = value;
                }
            }
        }

        public List<string> rocketPartsList = new List<string>();

        private string Divider = "+=*=*=*=*=*=*+";

        private List<string> upDesigns = new List<string>
        {
              @"|../\..../\..|"
            , @"|./\/\../\/\.|"
            , @"|/\/\/\/\/\/\|"
        };

        private List<string> downDesigns = new List<string>
        {
              @"|\/\/\/\/\/\/|"
            , @"|.\/\/..\/\/.|"
            , @"|..\/....\/..|"
        };
        private List<string> NoseParts = new List<string>
        {
              @"      /\"
            , @"     /**\"
            , @"    //**\\"
            , @"   ///**\\\"
            , @"  ////**\\\\"
            , @" /////**\\\\\"
        };

        private List<string> BoosterParts = new List<string>
        {
              @"    //**\\"
            , @"   ///**\\\"
            , @"  ////**\\\\"
            , @" /////**\\\\\"
        };
        /// <summary>
        /// Creates a Generic Rocket with 2 Fuselage Sections.
        /// </summary>
        public VerticalRocket()
        {
            rocket(FuselageSections);
        }
        /// <summary>
        /// creates a rocket with specified number of Fuselage sections
        /// </summary>
        /// <param name="sections">Number of Fuselage Sections Desired</param>
        public VerticalRocket(int sections)
        {
            FuselageSections = sections;
            rocket(FuselageSections);
        }

        public List<string> BuildFuselage(bool diamondShape)
        {
            List<string> fuselage = new List<string>();

            if (diamondShape)
            {
                fuselage.AddRange(upDesigns);
                fuselage.AddRange(downDesigns);
            }
            else
            {
                fuselage.AddRange(downDesigns);
                fuselage.AddRange(upDesigns);
            }
            return fuselage;
        }

        public List<string> BuildNose()
        {
            return new List<string>(NoseParts);
        }

        public List<string> BuildBooster()
        {
            return new List<string>(BoosterParts);
        }

        public void rocket(int sections)
        {
            bool wantDiamond = sections % 2 == 0; //this will keep the X at the bottom

            rocketPartsList.AddRange(BuildNose());
            rocketPartsList.Add(Divider);
            for (int i = 0; i < sections; i++)
            {
                rocketPartsList.AddRange(BuildFuselage(wantDiamond));
                wantDiamond = !wantDiamond;
                rocketPartsList.Add(Divider);
            }
            rocketPartsList.AddRange(BuildBooster());
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, rocketPartsList);
        }

    }
}
