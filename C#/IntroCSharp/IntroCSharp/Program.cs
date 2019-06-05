using System;

namespace IntroCSharp
{
    class Program
    {
        /* To hovedting inne i en klasse:
         *      Felt - Tilsvarer (nesten) JS globale variable
         *      Metoder - tilsvarer funksjon i JS
         * 
         * Pensum idag:
         *  C# er et sterkt typet programmeringsspråk
         *  Intro til Visual Studio
         *  Debugging
         *  Grunnskjelettet i en class
         *  Variable, tilordning og datatyper
         *      bool - boolean (true/false)
         *      int - heltall
         *      float/double - desimaltall
         *      string - tekst
         *  Valgsetning
         *  Løkker - for og while som i Js - foreach (for tabeller)
         *  Tabeller
         *  Metoder (funksjoner)
         *  Input og Output
         */
        static void Main(string[] args)
        {
            //Deklarere en variabel av hver av di nevnte datatypene
            bool b;
            int i;
            float f;
            double d;
            string s;

            //tilordning
            b = true;
            i = 5;
            f = 3.2f;
            d = 1.2;
            s = "eheheheh";
            //kan også deklarere og tilordne samtidig
            bool b2 = false;
            int i2 = 3;
            float f2 = 1.3f;
            double d2 = 7.7;
            string s2 = "hahahahha";

            var b3 = false;
            var i3 = 9;
            var f3 = 5.5f;
            var d3 = 9.9;
            var s3 = "xdxdxd";


            //if (args.Length == 0)
            //{
            //    Console.WriteLine("Hallo! Ingen parametre. ");
            //}
            //else
            //{
            //    Console.WriteLine("Hallo! Antall parametre: " + args.Length);
            //}

            //foreach (string t in args)
            //{
            //    Console.WriteLine("parameter " +  t);
        }
        }

    }