using System;
namespace BuildMap
{
    public class WaterClass
    {
        private readonly char name = '~';
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

        private void DrawMySelf()
        {
            for (int j = 0; j < mStruct.coordX.Count - 1; j++)
            {
                MakeRoad(j);
            }
        }

        private void MakeRoad(int i)
        {
           int a1 = (int)mStruct.coordX[i];
           int a2 = (int)mStruct.coordX[i + 1];
           int a3 = (int)mStruct.coordY[i];
           int a4 = (int)mStruct.coordY[i + 1];
           int res = 1;

            while(res != 0)
            {
                res = CheckWherePlaceWater(a1, a3, a2, a4);
                switch (res)
                {
                    case 1:
                        if(map[a1,a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                   
                        a3--;
                        break;
                    case 2:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1++;
                        a3--;
                        break;
                    case 3:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1++;
                        break;
                    case 4:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1++;
                        a3++;
                        break;
                    case 5:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a3++;
                        break;
                    case 6:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1--;
                        a3++;
                        break;
                    case 7:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1--;
                        break;
                    case 8:
                        if (map[a1, a3] == ".")
                        {
                            map[a1, a3] = name.ToString();
                        }
                        a1--;
                        a3--;
                        break;
                }
            }
          
        }
 
        private int CheckWherePlaceWater(int x1, int y1, int x2, int y2)
        {
            if((x1 == x2)&(y1 > y2))
            {
                return 1;
            }
            if ((x1 < x2) & (y1 > y2))
            {
                return 2;
            }
            if ((x1 < x2) & (y1 == y2))
            { 
                return 3;
            }
            if ((x1 < x2) & (y1 < y2))
            {
                return 4;
            }
            if ((x1 == x2) & (y1 < y2))
            {
                return 5; 
            }
            if ((x1 > x2) & (y1 < y2))
            {
                return 6;
            }
            if ((x1 > x2) & (y1 == y2))
            {
                return 7;
            }
            if ((x1 > x2) & (y1 > y2))
            {
                return 8;
            }

            return 0;
        }
    }
}
