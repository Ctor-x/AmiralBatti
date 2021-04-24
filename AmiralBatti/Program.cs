using System;

namespace AmiralBatti
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 6;

            int sutun = 6;


            OyunAlaniOlustur(sayi);

            void OyunAlaniOlustur(int satir)
            {

                int[,] getir = new int[satir, sutun];
                getir[4, 2] = 1;
                getir[5, 2] = 1;
                getir[2, 1] = 1;
                getir[2, 2] = 1;

                int gemiSayisi = 4;

                while (gemiSayisi > 0)
                {
                    int oyunKontrol = 0;
                    Console.Write("    ");
                    for (int i = 0; i < sayi; i++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();


                    for (int i = 0; i < satir; i++)
                    {
                        Console.Write(" " + i + "  ");
                        for (int j = 0; j < sutun; j++)
                        {

                            if (getir[i, j] <= 1)
                            {
                                Console.Write("O" + " ");
                            }
                            else if (getir[i, j] == 2)
                            {
                                Console.Write("1" + " ");
                                oyunKontrol++;

                            }
                            else
                            {
                                Console.WriteLine("X" + " ");
                            }

                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    if (oyunKontrol == 4)
                    {
                        Console.WriteLine("KAZANDIN");
                        break;
                    }

                    Console.Write("    ");

                    Console.WriteLine();
                    Console.WriteLine("satır sayısını gir");

                    int sat;
                    bool girilenA = int.TryParse(Console.ReadLine(), out sat);

                    Console.WriteLine("sutun sayısını gir");
                    int sut;
                    bool girilenB = int.TryParse(Console.ReadLine(), out sut);


                    if (girilenA && girilenB)
                    {
                        sat -= 1;
                        sut -= 1;

                        if (sat >= satir || sat < 0 || sut >= sutun || sut < 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("1 İLE 6 ARASINDA SAYI GİRİLMELİ");
                            Console.WriteLine();
                        }

                        else if (getir[sat, sut] == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("VURDUN");
                            Console.WriteLine();
                            getir[sat, sut] = 2;
                        }


                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("ÖNCEDEN VURDUN");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("1 İLE 6 ARASINDA SAYI GİRİLMELİ");
                    }
                }
            };
        }
    }
}
