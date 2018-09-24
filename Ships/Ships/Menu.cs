using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships
{
    class Menu
    {
        private static int index = 0;
        public static int MenuCreate()
        {
            int shipTypeCount = Enum.GetNames(typeof(ShipTypes)).Length;
            for (int i = 0; i < shipTypeCount; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine((ShipTypes)i);
                }
                else
                {
                    Console.WriteLine((ShipTypes)i);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == shipTypeCount - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = shipTypeCount - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                return index;
            }
            else
            {
                return 0;
            }


            Console.Clear();
            return 100;

        }

        public static void MenuGenerate()
        {
            List<Ship> ship = new List<Ship>();

            int ponorky = 1;
            int ponorkyCount = 1;
            int torpedoborce = 1;
            int torpedoborceCount = 1;
            int krizniky = 0;
            int kriznikyCount = 0;
            int bitevnilode = 0;
            int bitevnilodeCount = 0;

            int pocetlodi = ponorkyCount + torpedoborce + krizniky + bitevnilode;

            while (pocetlodi > 0)
            {
                pocetlodi = ponorkyCount + torpedoborceCount + kriznikyCount + bitevnilodeCount;
                Console.WriteLine(pocetlodi);
                int selectedMenuIndex = MenuCreate();
                if (selectedMenuIndex == 100)
                {

                }
                else if (selectedMenuIndex == 0)
                {
                    if (ponorkyCount > 0)
                    {
                        for (int i = 0; i < ponorky; i++)
                        {
                            bool add = true;
                            Console.Clear();

                            Console.WriteLine($"Rozmisěte {ponorkyCount} ponorek");
                            Console.WriteLine("napiste souradnici x");
                            int shipx = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("napiste souradnici y");
                            int shipy = Convert.ToInt32(Console.ReadLine());

                            if (ship.Count() != 0)
                            {
                                foreach (Ship lod in ship)
                                {
                                    if (shipx == lod.x && shipy == lod.y)
                                    {
                                        add = false;
                                        Console.WriteLine("Pozice je obsazená");
                                        i--;
                                    }
                                }
                            }

                            if (add == true)
                            {
                                ship.Add(new Ship
                                {
                                    type = "Ponorka",
                                    posX = new List<int>() { 0 },
                                    posY = new List<int>() { 0 }
                                });
                                ponorkyCount--;
                            }

                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti ponorky");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (selectedMenuIndex == 1)
                {
                    if (torpedoborceCount > 0)
                    {
                        for (int i = 0; i < torpedoborce; i++)
                        {
                            bool add = true;
                            Console.Clear();

                            Console.WriteLine($"Rozmisěte {torpedoborceCount} torpedoborce");
                            Console.WriteLine("napiste souradnici x");
                            int shipx = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("napiste souradnici y");
                            int shipy = Convert.ToInt32(Console.ReadLine());

                            if (ship.Count() != 0)
                            {
                                foreach (Ship lod in ship)
                                {
                                    if (shipx == lod.x && shipy == lod.y)
                                    {
                                        add = false;
                                        Console.WriteLine("Pozice je obsazená");
                                        i--;
                                    }
                                }
                            }

                            if (add == true)
                            {
                                ship.Add(new Ship
                                {
                                    type = "Torpedoborec",
                                    posX = new List<int>() { 0 },
                                    posY = new List<int>() { 0, 1 }
                                });
                                torpedoborceCount--;
                            }

                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Došli ti torpedoborce");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
