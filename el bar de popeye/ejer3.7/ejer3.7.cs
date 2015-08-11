using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejer3._7
{
    class Program
    {
        static void Presentacion()
        {
            int num;
            Random jugar = new Random(DateTime.Now.Millisecond);

            // GRAFICOS
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            num = jugar.Next(0, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(17, 5);
            Console.WriteLine(" ----  ---- ----   ----  |  |  ----");
            Console.SetCursorPosition(17, 6);
            Console.WriteLine(" |  |  |  | |  |   |     \\  /  |   ");
            Console.SetCursorPosition(17, 7);
            Console.WriteLine(" ----  |  | ----   ---    ||   --- ");
            Console.SetCursorPosition(17, 8);
            Console.WriteLine(" |     |  | |      |      ||   |   ");
            Console.SetCursorPosition(17, 9);
            Console.WriteLine(" |     ---- |      ----   ||   ----");

            int doo, do2, re, re2, mi, fa, fa2, sol, sol2, la, la2, si;


            doo = 261;
            do2 = 277;
            re = 293;
            re2 = 311;
            mi = 329;
            fa = 349;
            fa2 = 369;
            sol = 392;
            sol2 = 415;
            la = 440;
            la2 = 466;
            si = 493;

            Console.Beep(mi, 300);
            Console.Beep(sol, 300);
            Console.Beep(sol, 300);
            Console.Beep(sol, 300);
            Console.Beep(fa, 300);
            Console.Beep(mi, 300);
            Console.Beep(sol, 300);

            Console.Beep(20000, 500);

            Console.Beep(sol, 300);
            Console.Beep(la, 300);
            Console.Beep(fa, 300);
            Console.Beep(la, 300);
            Console.Beep(doo, 300);
            Console.Beep(la, 300);
            Console.Beep(sol, 300);

            Console.Beep(20000, 500);

            Console.Beep(sol, 300);
            Console.Beep(la, 300);
            Console.Beep(fa, 300);
            Console.Beep(la, 300);
            Console.Beep(doo, 300);
            Console.Beep(si, 300);
            Console.Beep(la, 300);
            Console.Beep(sol, 300);
            Console.Beep(la, 300);
            Console.Beep(sol, 300);
            Console.Beep(mi, 300);
            Console.Beep(doo, 300);


            Console.Beep(sol, 250);
            Console.Beep(la, 250);
            Console.Beep(fa, 250);
            Console.Beep(la, 250);
            Console.Beep(si, 250);
            Console.Beep(si, 250);
            Console.Beep(doo, 250);

            Console.SetCursorPosition(50, 12);
            Console.Write("El   ");
            Console.Beep(20000, 500);
            Console.Beep(100, 800);
            Console.Write("Bar");
            Console.Beep(100, 800);
        }


        // NOS MUESTRA EL MENU y nos deja ELEGIR JUGAR O VER INSTRUCCIONES
        static int Menu()
        {
            int elec;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, 4);
                Console.Write("\t\t\t");
                Console.SetCursorPosition(10, 8);
                Console.Write("\t\t\t");
                Console.SetCursorPosition(10, 16);
                Console.Write("\t\t\t");
                Console.SetCursorPosition(10, 20);
                Console.Write("\t\t\t");
                Console.SetCursorPosition(19, 6);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("MENU");
                Console.SetCursorPosition(11, 11);
                Console.Write("1: Ver instrucciones");
                Console.SetCursorPosition(11, 13);
                Console.Write("2: Jugar");
                Console.SetCursorPosition(11, 18);
                Console.Write("Opción: ");

                elec = int.Parse(Console.ReadLine());
            } while (elec != 1 & elec != 2);


            return (elec);
        }


        // NOS MUESTRA LAS INSTRUCCIONES
        static void Instruc()
        {

            Console.Clear();

            Console.SetCursorPosition(20, 4);
            Console.Write("INSTRUCCIONES");
            Console.Beep(300, 200);
            Console.SetCursorPosition(10, 7);
            Console.Write("1.- El que saque mayor puntuación ganará");
            Console.Beep(300, 700);
            Console.SetCursorPosition(10, 9);
            Console.Write("2.- Asignación de puntos");
            Console.Beep(300, 700);
            Console.SetCursorPosition(14, 11);
            Console.WriteLine("Si es múltiplo de 3 o de 5 sumara 10pts");
            Console.Beep(700, 400);
            Console.SetCursorPosition(14, 12);
            Console.WriteLine("Si es múltiplo de 4 o de 6 sumara 5pts.");
            Console.Beep(700, 400);
            Console.SetCursorPosition(14, 14);
            Console.WriteLine("Si es mayor de 80 sumara 2pts.");
            Console.Beep(700, 400);
            Console.SetCursorPosition(14, 15);
            Console.WriteLine("Si es mayor de 50 sumar 1pts.");
            Console.Beep(700, 400);
            Console.SetCursorPosition(14, 17);
            Console.WriteLine("Si es menor de 50 restará 2pts.");
            Console.Beep(700, 400);
            Console.SetCursorPosition(14, 18);
            Console.WriteLine("Si es menor de 20 restará 1pts.");
            Console.Beep(700, 400);
            Console.Beep(1000, 300);
            Console.Beep(1200, 300);
            Console.Beep(20000, 5000);
            Console.WriteLine(" ");
        }


       
        // NOS PIDE EL NUMERO DE JUGADORES
        static int NumeroParticipantes()
        {
            int part;

            Console.Beep(100, 800);
            Console.Beep(100, 800);

            do
            {

            Console.SetCursorPosition(40, 4);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("\t\t\t");
            Console.SetCursorPosition(40, 8);
            Console.Write("\t\t\t");
            Console.SetCursorPosition(40, 12);
            Console.Write("\t\t\t");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(42,6);
            Console.Write("Nº jugadores:                 ");
            Console.SetCursorPosition(42, 10);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Mínimo 2");
            Console.SetCursorPosition(42, 14);
            Console.Write("\t\t\t\t");
            Console.SetCursorPosition(56, 6);

            Console.ForegroundColor = ConsoleColor.Black;

                part=int.Parse(Console.ReadLine());
                if (part < 2)
                {
                    Console.SetCursorPosition(42, 14);
                    Console.WriteLine("Número no válido");
                    Console.Beep(1222, 500);
                    Console.Beep(1222, 500);
                }

            }   while(part<2);
                
            return(part);
        }

        static int Tirardado(Random jugar)
        {
            // Variables
            int dado;

            //Solicita un numero aleatorio
        
            dado = jugar.Next(50);

            return (dado);
        }


        static int Calcularpuntos(int dado)
        {
            int total;
            total=0;

            if (dado % 3 == 0 || dado % 5 == 0)
                total = 10;

            if (dado % 4 == 0 || dado % 6 == 0)
                total = total + 5;

            if (dado >= 50)
            {
                if (dado > 80)
                    total += 2;
                else
                    total += 1;
            }


            if (dado < 50)
            {
                if (dado < 20)
                    total -= 1;
                else
                    total -= 2;
            }

            return (total);

        }

        static int Trofeo(ref int part, ref int puntos, ref int aux, ref int pos1)
        {                        
            if (puntos > aux)
            
                pos1 = part;
                
            return (pos1);
            
        }





        static void Main(string[] args)
        {
            // VARIABLES
            Random jugar = new Random(DateTime.Now.Millisecond);
            int part,dado,puntos,menu,pos1,aux;
            pos1=0;
            aux = 0;
            puntos = 0;

            // PRESENTACION
            Presentacion();

            do
            {
                // MENU
                menu = Menu();
                            
                if (menu==1)    
                    Instruc();
            }while(menu==1);
            
            

            // MODULO PARA PEDIR PARTICIPANTES
            part=NumeroParticipantes();
            Console.Beep(900, 300);
            Console.Beep(1200, 300);
            Console.Beep(1500, 300);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(5, 3);
            Console.Write("__________________________________________________");
            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                     Clasificación");
            Console.SetCursorPosition(5, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("__________________________________________________");
            Console.SetCursorPosition(5, 8);
            Console.Beep(600, 300);
            Console.Beep(400, 300);
            Console.Beep(200, 300);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("         Jugador                      Puntos");

            Console.SetCursorPosition(0, 10);

            // BUCLE PARA JUGAR TODOS
            for (; part > 0; part--)
            {
                // TIRA DADO Y NOS DICE LO QUE HA SACADO
                dado = Tirardado(jugar);

                // Calcular PUNTOS
                aux = puntos;
                puntos = Calcularpuntos(dado);

                // MOSTRAR PUNTUACION
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                {0}                            {1} ", part, puntos);
                Console.Beep(600, 300);
                Console.Beep(18000, 500);

                // PARA SABER LOS GANADORES

                pos1 = Trofeo(ref part, ref puntos, ref aux, ref pos1);

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("        --------------------------------------------");
            }
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     __________________________________________________");
            Console.Beep(1500, 300);
            Console.Beep(1200, 300);
            Console.Beep(900, 300);
            
            
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t El ganador es el Jugador {0}",pos1);
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     __________________________________________________");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
                
        }
    }
}
