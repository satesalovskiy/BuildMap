using System;
using System.Collections;
using System.Text.RegularExpressions;

using System.Text;

namespace BuildMap
{
    public class BaseClass 
    {
        private readonly char name = '@';
        private CoordsStruct mStruct;
        private string[,] map;

        public string[,] AddToMap(string[,] map, string coordinates)
        {
            this.map = map;

            ParseStringCoordinates(coordinates);
            DrawMySelf();

            return this.map;
        }

        //Get coordinates from innitial String 
        private void ParseStringCoordinates(string coordinates)
        {
            mStruct = InnerClass.ParseStringCoordinates(coordinates);
        }

        //Add value (name) into array
        private void  DrawMySelf()
        {
            for (int i = (int)mStruct.coordX[0]; i <= (int)mStruct.coordX[mStruct.coordX.Count-1]; i++)
            {
                for(int j = (int)mStruct.coordY[0]; j <= (int)mStruct.coordY[mStruct.coordY.Count-1]; j++)
                {
                    if(map[i,j] == ".")
                    {
                        map[i, j] = this.name.ToString();
                    }
                    

                }
            }

        }
    }
}
