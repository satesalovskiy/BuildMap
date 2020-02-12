using System;

namespace BuildMap
{
    class Program
    {



        public const string FILE_PATH = @"/Users/tessergey/Downloads/dotnet.course/Task1/TestData/Map9.txt";


        static void Main(string[] args)
        {

            MapClass map = new MapClass(FILE_PATH); 
        }
    }
}
