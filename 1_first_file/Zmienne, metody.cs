using System;


namespace Lekcja_1
    //ZMIENNE
{
   public partial class MainWindow

    {
        //Zmiennie

        int liczbaCalkowita = 10; // 4 bajty   | 

        long liczbaCalkowitaDluga = 1000000000;  // 8 bajtów  |

        short liczbaCalkowitaKrotka = 255;  // 2 bajty    |

        float liczbaZmiennoprzecinkowa = 1.2f; // 4 bajty

        double liczbaZmiennoprzecinkowa2 = 1.2; // 8 bajtów 

        string tekst = "To jest prawidłowy tekst"; // długość  *  char => 2 bajty 

        ulong liczbaCalkowitaDlugaDodatnia = ulong.MaxValue; // liczby dodatnie


        // Konstruktor klasy

        public MainWindow()
        { 
        
        }

        //Metoda

        //lekcja 2 var

        int liczbaPolubien = 10;
        public void PierwszaMetoda()
        {
            var naszPierwszyVar = liczbaPolubien;  // var = metoda, która przejmuje typ po zmienniej
        }

        public void DrugaMetoda()
        {
            var naszDrugiVar = liczbaPolubien;
        }

    }
}
