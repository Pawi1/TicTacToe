using System;
namespace TicTacToe
{internal class Program{
        static void Main(string[] args)
        { char a1=' ',b1=' ',c1=' ',a2=' ',b2=' ',c2=' ',a3=' ',b3=' ',c3=' ';  
            string w ="";
            for (int q=1 ;q<=9;q++)
            { if(q==1||q==3||q==5||q==7||q==9) w="kółko";
              else w="krzyżyk";
              if (q==1)DajPlansze();
              Console.Write($"\n\t   Kolej gracza: {w}: ");
              ConsoleKeyInfo o = Console.ReadKey();
                if (w=="kółko")
              {
              if (o.Key == ConsoleKey.Q ||o.Key == ConsoleKey.NumPad7) a1='○';
              if (o.Key == ConsoleKey.W ||o.Key == ConsoleKey.NumPad8) b1='○';
              if (o.Key == ConsoleKey.E ||o.Key == ConsoleKey.NumPad9) c1='○';
              if (o.Key == ConsoleKey.A ||o.Key == ConsoleKey.NumPad4) a2='○';
              if (o.Key == ConsoleKey.S ||o.Key == ConsoleKey.NumPad5) b2='○';
              if (o.Key == ConsoleKey.D ||o.Key == ConsoleKey.NumPad6) c2='○';
              if (o.Key == ConsoleKey.Z ||o.Key == ConsoleKey.NumPad1) a3='○';
              if (o.Key == ConsoleKey.X ||o.Key == ConsoleKey.NumPad2) b3='○';
              if (o.Key == ConsoleKey.C ||o.Key == ConsoleKey.NumPad3) c3='○';
              }
                if (w=="krzyżyk")
              {
              if (o.Key == ConsoleKey.Q ||o.Key == ConsoleKey.NumPad7) a1='x';
              if (o.Key == ConsoleKey.W ||o.Key == ConsoleKey.NumPad8) b1='x';
              if (o.Key == ConsoleKey.E ||o.Key == ConsoleKey.NumPad9) c1='x';
              if (o.Key == ConsoleKey.A ||o.Key == ConsoleKey.NumPad4) a2='x';
              if (o.Key == ConsoleKey.S ||o.Key == ConsoleKey.NumPad5) b2='x';
              if (o.Key == ConsoleKey.D ||o.Key == ConsoleKey.NumPad6) c2='x';
              if (o.Key == ConsoleKey.Z ||o.Key == ConsoleKey.NumPad1) a3='x';
              if (o.Key == ConsoleKey.X ||o.Key == ConsoleKey.NumPad2) b3='x';
              if (o.Key == ConsoleKey.C ||o.Key == ConsoleKey.NumPad3) c3='x';
              }
                Console.Clear();
                DajPlansze(a1,b1,c1,a2,b2,c2,a3,b3,c3);
            }
        }        
        static void DajPlansze(char a1=' ',char b1=' ',char c1=' ',char a2=' ',char b2=' ',char c2=' ',char a3=' ',char b3=' ',char c3=' ')
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("\n\n");
        for (int i=1;i<=5;i++)    
        { Console.Write("\t\t");
             for (int j=1;j<=5;j++)
            {   if ((i%2==0) && (j==1 || j==3 || j==5)) Console.Write("━━━");
                if ((i%2==0) &&( j==2 || j==4)) Console.Write("╋"); 
                if ((i%2!=0) && (j==2 || j==4)) Console.Write("┃");
                if (i==1)
                {   if (j==1) Console.Write(" "+a1+" ");
                    if (j==3) Console.Write(" "+b1+" ");
                    if (j==5) Console.Write(" "+c1+" "); }

                if (i==3)
                {   if (j==1) Console.Write(" "+a2+" ");
                    if (j==3) Console.Write(" "+b2+" ");
                    if (j==5) Console.Write(" "+c2+" ");}                
                
                if (i==5)
                {   if (j==1) Console.Write(" "+a3+" ");
                    if (j==3) Console.Write(" "+b3+" ");
                    if (j==5) Console.Write(" "+c3+" ");}            
            }
            Console.WriteLine(); }              
        }
}}