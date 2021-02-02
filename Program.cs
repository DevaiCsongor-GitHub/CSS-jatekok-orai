using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Epic_gaming_program
{
    class Program
    {
        static void Main(string[] args)
        {
            MapHandler map1 = new MapHandler("ElsoPalya");
            Console.WriteLine(map1.getName());

            bool gameIsRunning = true;

            do
            {
                char command = Console.ReadKey().KeyChar;
                switch (command)
                {
                    case 'w': map1.up(); break;
                    case 's': map1.down(); break;
                    case 'a': map1.left(); break;
                    case 'd': map1.right(); break;
                    case 'f': Console.WriteLine($"{map1.location()[0]},{map1.location()[0]}"); break;
                    default: Console.WriteLine("nincs ilyen parancs"); break;
                }


                Console.ReadKey();
            } while (gameIsRunning);




        }
    }

    class MapHandler
    {
        private char[,] map;
        private string mapname;

        public MapHandler(string name)
        {
            this.mapname = name;
            this.map = new char[,]
            {
                {'#','#','#','#','#'},
                {'#','.','.','.','#'},
                {'#','.','#','.','#'},
                {'@','.','#','.','x'},
                {'#','#','#','#','#'}
            };
        }

        public string getName()
        {
            return mapname;
        }


        public char[,] getmap()
        {
            return map;
        }

        public void ShowMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write($" {this.map[i,j]}");
                }
                Console.WriteLine("");
            }
        }

        public int[] location()
        {
            int[] pos = {0,0};
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (this.map[i,j] == '@')
                    {
                        pos[0] = i;
                        pos[1] = j;
                    }
                }
            }
            return pos;
        }

        public void up()
        {

        }

        public void down()
        {

        }

        public void left()
        {

        }

        public void right()
        {

        }


    }
}
