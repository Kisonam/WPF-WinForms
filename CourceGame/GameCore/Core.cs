using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Core
    {
        public static int[,] LoadWorld()
        {
            int[,] map = new int[50, 50];
            string[] lines = File.ReadAllLines("first.world");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] tagAndDAta = line.Split(':');
                if (tagAndDAta[0] == "Block")
                {
                    int x = 0, y = 0, type = 0;
                    string[] data = tagAndDAta[1].Split(';');
                    for (int j = 0; j < data.Length; j++)
                    {
                        string[] nameAndValue = data[j].Split('=');
                        if (nameAndValue[0] == "X")
                        {
                            x = int.Parse(nameAndValue[1]);

                        }
                        else if (nameAndValue[0] == "Y")
                        {
                            y = int.Parse(nameAndValue[1]);

                        }
                        else if (nameAndValue[0] == "Type")
                        {
                            type = int.Parse(nameAndValue[1]);
                        }
                    }
                    map[x, y] = type;
                }
                else if (tagAndDAta[0] == "Camera")
                {
                    //string[] data = tagAndDAta[1].Split(';');
                    //for (int j = 0; j < data.Length; j++)
                    //{
                    //    string[] nameAndValue = data[j].Split('=');
                    //    if (nameAndValue[0] == "X")
                    //    {
                    //        _viewX = int.Parse(nameAndValue[1]);

                    //    }
                    //    else if (nameAndValue[0] == "Y")
                    //    {
                    //        _viewY = int.Parse(nameAndValue[1]);

                    //    }
                    //}
                    // = x;

                }
            }
            return map;
        }

    }
}
