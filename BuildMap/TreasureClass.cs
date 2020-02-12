using System;
namespace BuildMap
{
    public class TreasureClass
    {
        private readonly char name = '+';
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
        private void DrawMySelf()
        {
            map[(int)mStruct.coordX[0], (int)mStruct.coordY[0]] = this.name.ToString();
        }
    }
}
