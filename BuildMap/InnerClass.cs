using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace BuildMap
{
    public static class InnerClass
    {
        //Get coordinates from innitial String 
        public static CoordsStruct ParseStringCoordinates(string coordinates)
        {
            ArrayList coordX = new ArrayList();
            ArrayList coordY = new ArrayList();


            string[] numbers = Regex.Split(coordinates, @"\D+");

            int count = 1;

            foreach (string s in numbers)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    int i = int.Parse(s);

                    if (count % 2 != 0)
                    {
                        coordX.Add(i);
                        count++;

                    }
                    else if (count % 2 == 0)
                    {
                        coordY.Add(i);
                        count++;
                    }
                }
            }

            CoordsStruct coordsStruct = new CoordsStruct();
            coordsStruct.coordX = coordY;
            coordsStruct.coordY = coordX;
            return coordsStruct;

        }

    }
}
