using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomplexeZahlen
{
    public class Rechner
    {
        public double Komplex1;
        public double Real1;
        public double Komplex2;
        public double Real2;
        public double Komplex3;
        public double Real3;
        public void eingeben()
        {
     
            Console.WriteLine("Geben Sie eine Komplexe Zahl ein");
            string text1 = "";
            text1 = Console.ReadLine();
            for (int i = 1; i < text1.Length; i++)
            {
                if (text1.Substring(i, 1) == "+" | text1.Substring(i, 1) == "-")
                {
                    if (text1.Substring(i, 1) == "i")
                    {
                        this.Komplex1 = Convert.ToInt32(text1.Substring(0, i));
                        this.Real1 = Convert.ToInt32(text1.Substring(i, text1.Length - (i + 1)));
                    }
                    else
                    {
                        this.Real1 = Convert.ToInt32(text1.Substring(0, i));
                        this.Komplex1 = Convert.ToInt32(text1.Substring(i, text1.Length - (i + 1)));
                    }
                }
            }
                Console.WriteLine("Geben Sie eine Komplexe Zahl ein");
                string text2 = "";
                text2 = Console.ReadLine();
                for (int i = 1; i < text2.Length; i++)
                {
                    if (text2.Substring(i, 1) == "+" | text2.Substring(i, 1) == "-")
                    {
                        if (text2.Substring(i, 1) == "i")
                        {
                            this.Komplex2 = Convert.ToInt32(text2.Substring(0, i));
                            this.Real2 = Convert.ToInt32(text2.Substring(i, text2.Length - (i + 1)));
                        }
                        else
                        {
                            this.Real2 = Convert.ToInt32(text2.Substring(0, i));
                            this.Komplex2 = Convert.ToInt32(text2.Substring(i, text2.Length - (i + 1)));
                        }
                    }

                }

            }
        
        public void Addition()
        {
            this.Real3= this.Real1 + this.Real2; 
            this.Komplex3=this.Komplex1 + this.Komplex2;
        }

        public void Subtrakion()
        {
           this.Real3 =this.Real1 - this.Real2;
           this.Komplex3= this.Komplex1 - this.Komplex2;
        }
        public void ausgabe()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (Real3 == 0 & Komplex3 == 0)
                Console.WriteLine("\n" + "0");
            else if (Komplex3 == 0)
                Console.WriteLine("\n" + this.Real3);
            else if (Real3 == 0)
                Console.WriteLine("\n"+this.Komplex3+"i");
            else if (Komplex3 >= 0)
                Console.WriteLine("\n{0}+{1}i", this.Real3, this.Komplex3);
            else
                Console.WriteLine("\n{0}{1}i", this.Real3, this.Komplex3);
           
        }
        public void Multiplikation()
        {
            this.Real3 = (this.Real1 * this.Real2) + ((this.Komplex1 * this.Komplex2)*-1);
            this.Komplex3 = (this.Real1 * this.Komplex2) + (this.Komplex1 * this.Real2);

        }
        public void Division()
        {
            this.Real3 = (this.Real1 * this.Real2) + ((this.Komplex1 * -this.Komplex2)*(-1));
            this.Komplex3 = (this.Real1 * -this.Komplex2) + (this.Komplex1 * this.Real2);

            this.Real1 = (this.Real2 * this.Real2) + ((this.Komplex2 * -this.Komplex2) * (-1));

            this.Real2 = (this.Real3 / this.Real1);
            this.Komplex2 = (this.Komplex3 / this.Real1);

            this.Real3 = this.Real2;
            this.Komplex3 = this.Komplex2;
        }
        public void Auswahl()
        {
            char a = ' ';
            Console.WriteLine("Wollen Sie (+),(-),(*)oder(/)");
            
             a = Convert.ToChar(Console.ReadLine());
            if (a == '+')
            {
                this.Addition();
                this.ausgabe();
            }
            else if (a == '-')
            {
                this.Subtrakion();
                this.ausgabe();
            }
            else if (a == '*')
            {
                this.Multiplikation();
                this.ausgabe();
            }
            else if (a == '/')
            {
                this.Division();
                this.ausgabe();
            }
        }
    }
}
