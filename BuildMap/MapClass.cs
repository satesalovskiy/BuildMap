using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BuildMap
{

    public class MapClass
    {
        public const int MAP_SIZE = 50;

        private string[,] map;
        private BaseClass myBase;
        private BridgeClass myBridge;
        private TreasureClass myTreasure;
        private WaterClass myWater;
        private string path;

        public MapClass(string path)
        {
            this.path = path;
            this.map = new string[MAP_SIZE, MAP_SIZE];
            InitializeMapWithNull();

            this.myBase = new BaseClass();
            this.myBridge = new BridgeClass();
            this.myTreasure = new TreasureClass();
            this.myWater = new WaterClass();

            YeildToMapObjects();
            ShowFinalMap();
        }

        //Define string with coordinates for each map object
        private void YeildToMapObjects()
        {
            string[] strings = File.ReadAllLines(path);
            for(int i =0; i<strings.Length;i++)
            {
                if (string.IsNullOrEmpty(strings[i]))
                {
                    continue;
                }
                StringBuilder res = new StringBuilder();

                char[] word = strings[i].ToCharArray();

                for(int j = 0; j < word.Length; j++)
                {
                    if (char.IsLetter(word[j]))
                    {
                        res.Append(word[j].ToString());
                    }


                    
                }

                switch (res.ToString().ToUpper())
                {
                    case "BASE":
                        map = myBase.AddToMap(map, strings[i]);
                        break;
                    case "TREASURE":
                        map = myTreasure.AddToMap(map, strings[i]);

                        break;
                    case "BRIDGE":
                        map = myBridge.AddToMap(map, strings[i]);

                        break;
                    case "WATER":
                        map = myWater.AddToMap(map, strings[i]);

                        break;
                }

               

                

            }

           



            //map = myWater.AddToMap(map, strings[3]);
            //map = myBase.AddToMap(map, strings[0]);
            //map = myBridge.AddToMap(map, strings[1]);
            //map = myTreasure.AddToMap(map, strings[2]);

        }

        //Just console drawing
        public void ShowFinalMap()
        {
            for(int i = 0; i< 50; i++)
            {
                for (int j = 0; j<50; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

        }

        private void InitializeMapWithNull()
        {
            for(int i = 0; i < MAP_SIZE; i++)
            {
                for (int j =0; j < MAP_SIZE; j++)
                {
                    map[i, j] = ".";
                }
            }
        }
    }
}
