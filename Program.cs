using System;
namespace TicTacToe

{
  internal class Program{
        static void Main(string[] args)
        { Console.Clear();
          char a1=' ',b1=' ',c1=' ',a2=' ',b2=' ',c2=' ',a3=' ',b3=' ',c3=' ';  
            string w ="";
            int a=0;
            for (int q=1 ;q<=9;q++)
            { if(q==1||q==3||q==5||q==7||q==9) w="kółko";
              else w="krzyżyk";
              if (q==1)DajPlansze();
              if (a1=='○' && b1=='○' && c1=='○' || a2=='○' && b2=='○' && c2=='○' ||  a3=='○' && b3=='○' && c3=='○' || a3=='○' && b3=='○' && c3=='○' || b1=='○' && b2=='○' && b3=='○'|| c1=='○' && c2=='○' && c3=='○'||a1=='○' && b2=='○' && c3=='○' || a3=='○' && b2=='○' && c1=='○') a=1;               
              if (a1=='x' && b1=='x' && c1=='x' || a2=='x' && b2=='x' && c2=='x' ||  a3=='x' && b3=='x' && c3=='x' || a3=='x' && b3=='x' && c3=='x' || b1=='x' && b2=='x' && b3=='x'|| c1=='x' && c2=='x' && c3=='x'||a1=='x' && b2=='x' && c3=='x' || a3=='x' && b2=='x' && c1=='x') a=1;               
              if (a!=0) break;
              Console.Write($"\n\t   Kolej gracza: {w}: ");
              IdzDo:
              ConsoleKeyInfo o = Console.ReadKey();
                if (w=="kółko")
              {
              if (o.Key == ConsoleKey.Q ||o.Key == ConsoleKey.NumPad7 || a1==' ') a1='○';
              else if (o.Key == ConsoleKey.W ||o.Key == ConsoleKey.NumPad8 && b1==' ') b1='○';
              else if (o.Key == ConsoleKey.E ||o.Key == ConsoleKey.NumPad9 && c1==' ') c1='○';
              else if (o.Key == ConsoleKey.A ||o.Key == ConsoleKey.NumPad4 && a2==' ') a2='○';
              else if (o.Key == ConsoleKey.S ||o.Key == ConsoleKey.NumPad5 && b2==' ') b2='○';
              else if (o.Key == ConsoleKey.D ||o.Key == ConsoleKey.NumPad6 && c2==' ') c2='○';
              else if (o.Key == ConsoleKey.Z ||o.Key == ConsoleKey.NumPad1 && a3==' ') a3='○';
              else if (o.Key == ConsoleKey.X ||o.Key == ConsoleKey.NumPad2 && b3==' ') b3='○';
              else if (o.Key == ConsoleKey.C ||o.Key == ConsoleKey.NumPad3 && c3==' ') c3='○';
              else goto IdzDo;
              }
                if (w=="krzyżyk")
              {
              if (o.Key == ConsoleKey.Q ||o.Key == ConsoleKey.NumPad7 || a1==' ') a1='x';
              else if (o.Key == ConsoleKey.W ||o.Key == ConsoleKey.NumPad8 && b1==' ') b1='x';
              else if (o.Key == ConsoleKey.E ||o.Key == ConsoleKey.NumPad9 && c1==' ') c1='x';
              else if (o.Key == ConsoleKey.A ||o.Key == ConsoleKey.NumPad4 && a2==' ') a2='x';
              else if (o.Key == ConsoleKey.S ||o.Key == ConsoleKey.NumPad5 && b2==' ') b2='x';
              else if (o.Key == ConsoleKey.D ||o.Key == ConsoleKey.NumPad6 && c2==' ') c2='x';
              else if (o.Key == ConsoleKey.Z ||o.Key == ConsoleKey.NumPad1 && a3==' ') a3='x';
              else if (o.Key == ConsoleKey.X ||o.Key == ConsoleKey.NumPad2 && b3==' ') b3='x';
              else if (o.Key == ConsoleKey.C ||o.Key == ConsoleKey.NumPad3 && c3==' ') c3='x';
              else goto IdzDo;
              }

                
                Console.Clear();
                DajPlansze(a1,b1,c1,a2,b2,c2,a3,b3,c3);
            }
            if(a==1)Console.WriteLine($"Wygrał {w}");
            else Console.WriteLine("Remis");
            
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