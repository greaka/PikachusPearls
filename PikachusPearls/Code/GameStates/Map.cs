﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using System.Drawing;

namespace PikachusPearls.Code.GameStates
{
    class Map
    {
        Tiles[,] map;
        int tileSize = 64;

        public static String water = "ff0000ff";
        public static String path = "ffff0000";
        public static String forest = "ff000000";
        public static String highGras = "ff00ff00";
        public static String gras = "ffffffff";

        public Vector2f MapSize
        {
            get
            {
                return new Vector2f(map.GetLength(0) * tileSize, map.GetLength(1) * tileSize);
            }
        }

        public Map(Bitmap mask)
        {

            map = new Tiles[mask.Width, mask.Height];

            for (int i=0; i<map.GetLength(0); i++)
            {
                for(int j=0; i<map.GetLength(1); j++)
                {
                    if(mask.GetPixel(i, j).Name == water)
                    {
                        //water_bottom
                        if ((mask.GetPixel(i - 1, j).Name == water) && (mask.GetPixel(i + 1, j).Name == water) && (mask.GetPixel(i, j + 1).Name != water))
                        {
                            map[i, j] = new Tiles(0, 0, new Vector2f(i * tileSize, j * tileSize));
                        }

                        //water_bottom_left
                        if (
                            (mask.GetPixel(i - 1, j).Name != water) && (mask.GetPixel(i, j + 1).Name != water))
                        {
                            map[i, j] = new Tiles(0, 1, new Vector2f(i * tileSize, j * tileSize));
                        }

                        //water_bottom_right
                        if ((mask.GetPixel(i + 1, j).Name != water) && (mask.GetPixel(i, j + 1).Name != water))
                        {
                            map[i, j] = new Tiles(0, 2, new Vector2f(i * tileSize, j * tileSize));
                        }

                        //water_inner_bottom_left
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_inner_bottom_right
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_inner_top_left
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_inner_top_right
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_left
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_middle
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_right
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_top
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_top_left
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }

                        //water_top_right
                        if ((mask.GetPixel(i - 1, j - 1).Name != water) && (mask.GetPixel(i, j - 1).Name != water) && (mask.GetPixel(i + 1, j - 1).Name != water) &&
                            (mask.GetPixel(i - 1, j).Name != water)                                                && (mask.GetPixel(i + 1, j).Name != water) &&
                            (mask.GetPixel(i - 1, j + 1).Name != water) && (mask.GetPixel(i, j + 1).Name != water) && (mask.GetPixel(i + 1, j + 1).Name != water))
                        {

                        }
                    }

                    if (mask.GetPixel(i, j).Name == path)
                    {

                    }

                    if (mask.GetPixel(i, j).Name == forest)
                    {

                    }

                    if (mask.GetPixel(i, j).Name == highGras)
                    {

                    }

                    if (mask.GetPixel(i, j).Name == gras)
                    {

                    }
                }
            }
        }
    }
}
