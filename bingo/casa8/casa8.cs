using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace casa8
{
    class casa8
    {
        //METODO PARA PRESENTACION
        static void Presentacion()
        {
            Console.SetWindowSize(100, 44);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.SetCursorPosition(36, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Beep(300, 200);
            Console.Beep(400, 300);
            Console.Beep(500, 400);
            Console.Beep(600, 500);
            Console.Write("B I N G O");
            Console.Beep(300, 200);
            Console.Beep(400, 300);
            Console.Beep(500, 400);
            Console.Beep(600, 500);

            Console.SetCursorPosition(52, 6);
            Console.Beep(500, 500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("PAC");
            Console.Beep(800, 300);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.Beep(500, 500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("MAN");

            Console.SetCursorPosition(0,15);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"                          oooo$$$$$$$$$$$$oooo
                      oo$$$$$$$$$$$$$$$$$$$$$$$$o
                   oo$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$o         o$   $$ o$
   o $ oo        o$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$o       $$ $$ $$o$
oo $ $ o$      o$$$$$$$$$    $$$$$$$$$$$$$    $$$$$$$$$o       $$$o$$o$
o$$$$$$o$     o$$$$$$$$$      $$$$$$$$$$$      $$$$$$$$$$o    $$$$$$$$
  $$$$$$$    $$$$$$$$$$$      $$$$$$$$$$$      $$$$$$$$$$$$$$$$$$$$$$$
  $$$$$$$$$$$$$$$$$$$$$$$    $$$$$$$$$$$$$    $$$$$$$$$$$$$$  ooo$$$
   o$$$ooo$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$     o$$$
    $$$   o$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$     o$$$o
   o$$o   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$       $$$o
   $$$    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$o o$$$$$$ooooo$$$$o
  o$$$oooo$$$$$  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$   o$$$$$$$$$$$$$$$$$
  $$$$$$$$o$$$$   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$     $$$$oooooooo
 ooo       $$$$    o$$$$$$$$$$$$$$$$$$$$$$$$$$$$o      o$$$
            o$$$o     ooo$$$$$$$$$$$$$$$$$$o$$o         $$$
              $$$o          o$$oo$$$$$$oooo           o$$$
               $$$$o                 oo             o$$$o
                o$$$$o      o$$$$$$oo$$$$o        o$$$$
                  o$$$$$oo     oo$$$$o$$$$$o   o$$$$oo 
                     oo$$$$$oooo  o$$$o$$$$$$$$$ooo   
                        oo$$$$$$$oo $$$$$$$$$$         
                                ooo$$$$$$$$$$$        
                                    $$$$$$$$$$$$       
                                     $$$$$$$$$$$      
                                      $$$$$$");

            Console.SetCursorPosition(60, 34);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Pulsa una tecla para empezar a jugar");

            Console.ReadLine();

            
        }

        // METODO PARA CREAR EL ENTORNO GRAFICO
        static void Graficos()
        {
            Console.SetWindowSize(80, 30);

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(3, 3);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 4);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 4);
            Console.Write("     Jugador 1      ");
            Console.SetCursorPosition(3, 5);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 6);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 7);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 8);
            Console.Write("                    ");
            Console.SetCursorPosition(3, 9);
            Console.Write("                    "); 
            Console.SetCursorPosition(3, 10);
            Console.Write("                    ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(28, 3);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 4);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 4);
            Console.Write("     Jugador 2      ");
            Console.SetCursorPosition(28, 5);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 6);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 7);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 8);
            Console.Write("                    ");
            Console.SetCursorPosition(28, 9);
            Console.Write("                    "); 
            Console.SetCursorPosition(28, 10);
            Console.Write("                    ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(53, 3);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 4);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 4);
            Console.Write("     Jugador 3      ");
            Console.SetCursorPosition(53, 5);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 6);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 7);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 8);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 9);
            Console.Write("\t\t\t   ");
            Console.SetCursorPosition(53, 10);
            Console.Write("\t\t\t   ");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(4, 17);
            Console.Write("                           ");
            Console.SetCursorPosition(4, 18);
            Console.Write("           LINEA           ");
            Console.SetCursorPosition(4, 19);
            Console.Write("                           ");
            Console.SetCursorPosition(4, 20);
            Console.Write("                           ");
            Console.SetCursorPosition(4, 21);
            Console.Write("                           ");
            Console.SetCursorPosition(4, 22);
            Console.Write("                           ");
            Console.SetCursorPosition(4, 23);
            Console.Write("                           ");

            Console.SetCursorPosition(50, 18);
            Console.Write("                           ");
            Console.SetCursorPosition(50, 19);
            Console.Write("           BINGO           ");
            Console.SetCursorPosition(50, 20);
            Console.Write("                           ");
            Console.SetCursorPosition(50, 21);
            Console.Write("                           ");
            Console.SetCursorPosition(50, 22);
            Console.Write("                           ");
            Console.SetCursorPosition(50, 23);
            Console.Write("                           ");

            Console.BackgroundColor = ConsoleColor.Black;
        }

        // METODO PARA CONTROLAR QUE NO SE REPITA EL MISMO CARTON IGUAL
        static void Controltotal(ref int[,] j1, ref int[,] j2, ref int[,] j3,Random jugar)
        {
            while ((j1 == j2) || (j1 == j3) || (j2 == j3))
            {
                if (j1 == j2)
                    j2=Asignar(jugar);

                if (j1 == j3)
                    j3=Asignar(jugar);

                if (j2 == j3)
                    j3=Asignar(jugar);
            }
        }


        // Metodo para saber si se repite la misma linea
        static bool Control(int[,] jugador, int columna,int numero)
        {
            bool valor;
            valor=true;
            int fil, col;

            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                for (col = 0; col < columna; col++)
                {
                    if (numero == jugador[fil,col])
                        valor = false;
                }
            }
            return (valor);
        }


        // Metodo para asignar valores  LOS NUMEROS SELECCIONES
        // TIENE UN METODO DENTRO QUE ES PARA QUE NO SE REPITAN LOS NUMEROS DENTRO DE LA MISMA LINEA
        static int[,] Asignar(Random jugar)
        {
            int[,] jugador = new int[5, 5];
            int fil, col;
            bool control;
            control = true;

            for(fil=0;fil<jugador.GetLength(0);fil++)
            {

                for (col = 0; col < jugador.GetLength(0); col++)
                {                                          
                    do
                    {
                        if (fil == 0)
                            jugador[fil, col] = jugar.Next(1,16);
                        if (fil == 1)
                            jugador[fil, col] = jugar.Next(17, 30);
                        if (fil == 2)
                            jugador[fil, col] = jugar.Next(31, 45);
                        if (fil == 3)
                            jugador[fil, col] = jugar.Next(46, 60);
                        if (fil == 4)
                            jugador[fil, col] = jugar.Next(61, 75);

                        // METODO PARA CONTROLAR QUE NO SE REPITAN LOS NUMEROS EN LA MISMA LINEA
                       control= Control(jugador,col,jugador[fil,col]);

                    } while (control==false);
                }
            }
            return (jugador);
        }

        // Muestra por pantalla el carton del jugador deseado
        static void Mostrar(int[,] jugador,int numjugador)
        {
            int fil,col, posjugador,filjugador;
            filjugador = 5;
            posjugador = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (numjugador == 1)
                posjugador = 3;
            if (numjugador == 2)
                posjugador = 28;
            if (numjugador == 3)
                posjugador = 53;

            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                Console.SetCursorPosition(posjugador, filjugador);
                for (col = 0; col < jugador.GetLength(0); col++)
                {
                    
                    Console.Write("{0,3} ", jugador[fil, col]);
                    
                }
                filjugador++;
            }
            Console.ForegroundColor = ConsoleColor.White; 
        }

        // MOSTRAR TODOS LOS JUGADORES
        static void Mostrartodos(int[,] jugador1, int[,] jugador2, int[,] jugador3)
        {
            Mostrar(jugador1,1);

            Mostrar(jugador2,2);
            
            Mostrar(jugador3,3);

        }

        //METODO PARA ORDENAR LOS NUMEROS DE LOS JUGADORES
        static void Ordenar(int[,] jugador)
        {                 
            int i, aux,j,fil;
            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                for (i = 1; i < jugador.GetLength(0); i++)
                {
                    aux = jugador[fil,i];

                    for (j = i - 1; j != -1 && aux < jugador[fil,j]; j--)
                    {
                        jugador[fil,j + 1] = jugador[fil,j];
                    }
                    jugador[fil,j + 1] = aux;
                }
            }
        }


        // METODO PARA INICIALIZAR LOS VALORES DE LOS JUGADORES
        static void Inicio(ref int[,] jugador1, ref int[,] jugador2, ref int[,] jugador3,Random jugar)
        {
            // ASGINA LOS VALORES A LOS JUGADORES
            // NOS CONTROLAR DENTRO QUE NO SE REPITA UN NUMERO DENTRO DE LA MISMA LINEA
            jugador1 = Asignar(jugar);
            jugador2 = Asignar(jugar);
            jugador3 = Asignar(jugar);

            //Metodo para ordenar los valores de los jugadores
            Ordenar(jugador1);
            Ordenar(jugador2);
            Ordenar(jugador3);

            // Metodo controlar que los cartones totales no se repitan
            Controltotal(ref jugador1, ref jugador2, ref jugador3,jugar);

            // Mostrar cartones de lo jugadores
            Mostrartodos(jugador1,jugador2,jugador3);

        }

        // METODO PARA CONTROLAR QUE NO SE REPITAN NUMEROS DENTRO DEL BINGO
        static bool Norepetir(int[] bingo,int numero,int posicion)
        {
            bool control;
            int pos;
            control = true;

            for (pos = posicion-1;pos >=0; pos--)
            {
                if (numero == bingo[pos])
                {
                    return false;
                }
            }
            return(control);
        }


        // METODO PARA IR SACANDO NUMEROS ALEATORIOS PARA EL BINGO
        static int[] Colocar(Random jugar)
        {
            int pos;
            int[] bingo = new int[75];
            bool control;
            control = true;

            for (pos = 0; pos < bingo.Length-1; pos++)
            {
                do
                {
                    bingo[pos] = jugar.Next(1, 75);
                    control = Norepetir(bingo,bingo[pos],pos);
                
                } while (control == false);
            }
            return (bingo);
        }

        // METODO PARA MOSTRAR EL BINGO
        static void Mostrarbingo(int[] bingo)
        {
            int pos;

            Console.SetCursorPosition(0, 18);

            for (pos = 0; pos < bingo.Length; pos++)
                Console.Write("{0} ", bingo[pos]);

        }

        //METODO QUE NOS TACHA LOS VALORES DE BINGO EN LOS CARTONES
        static void Controlar(int numero, int[,] jugador, int colocar)
        {
            int fil, col;

            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                for (col = 0; col < jugador.GetLength(0); col++)
                {
                    if (numero == jugador[fil, col])
                    {
                        jugador[fil, col] = 0;
                        Console.SetCursorPosition(3 + colocar * 25+col*4, fil +5);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0,3}", numero);
                        
                    }
                }
            }

        }

        // METODO PARA SABER SI HAN HECHO LINEA
        static bool Lineaa(int[,] jugador)
        {
            int fil,col,totallinea;
            bool linea;
            linea = false;
            totallinea=0;

            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                for (col = 0; col < jugador.GetLength(0); col++)
                {
                    totallinea = totallinea + jugador[fil, col];
                    if (col==jugador.GetLength(0)-1)
                    {
                        if (totallinea==0)
                            linea = true;
                    }
                }
                totallinea = 0;
            }

            return (linea);

        }

        // METODO PARA SABER SI ALGUIEN HA HECHO BINDO
        static bool Aporbingo(int[,] jugador)
        {
            int fil, col,totalbingo;
            bool bingo;
            totalbingo=0;
            bingo = false;

            for (fil = 0; fil < jugador.GetLength(0); fil++)
            {
                for (col = 0; col < jugador.GetLength(0); col++)
                {
                    totalbingo = totalbingo + jugador[fil, col];
                }
            }

            if (totalbingo == 0)
                bingo = true;
            return (bingo);

        }

        // METODO PARA IR TACHANDO LOS NUMEROS ORDENADAMENTE DE LOS CARTONES
        // EMPEZARA POR EL PRIMERO NUMERO DEL BINGO, E IRA AUMENTANDO
        static void Tachar(int[] bingo, int[,] j1, int[,] j2, int[,] j3,int [] ganador)
        {
            int posbingo,collinea;
            bool linea1, linea2, linea3, binnngo1, binnngo2, binnngo3, Sehizolinea;
            linea1 = false;
            linea2 = false;
            linea3 = false;
            binnngo1 = false;
            binnngo2 = false;
            binnngo3 = false;
            Sehizolinea = false;
            collinea = 20;

            Console.Write("\n");

            // Nos tacha los numeros de bingo de los jugadores sucesivamente
            // Nos dice cuando es linea, y sale cuando alguien hace bingo
            for (posbingo = 0; posbingo < bingo.Length; posbingo++)
            {
                // NOS MUESTRA SOLO EL NUMERO DEL BINGO A TACHAR
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(25, 13);
                Console.Beep(600, 500);
                Console.Write("                          ");
                Console.SetCursorPosition(25, 14);
                Console.Write("    Número sacado: {0}     ", bingo[posbingo]);
                Console.SetCursorPosition(25, 15);
                Console.Write("                          ");
                Console.Beep(20000, 300);
                Console.BackgroundColor = ConsoleColor.Black;


                // Nos tacha los numeros
                Controlar(bingo[posbingo], j1,0);
                Controlar(bingo[posbingo], j2,1);
                Controlar(bingo[posbingo], j3,2);

                // PARA SABER SI SE HA HECHO LINEA
                // BUCLE IF, SOLO SE PUEDE HACER LINEA UNA VEZ
                // VARIOS PUEDEN HACER LINEA A LA VEZ, SE REPARTIRIAN LAS GANANCIAS
                if (Sehizolinea == false)
                {
                    linea1 = Lineaa(j1);
                    linea2 = Lineaa(j2);
                    linea3 = Lineaa(j3);

                    //PARA INDICAR SI ALGUIEN HA HECHO LINEA, PARA QUE NO SE REPITA

                    if (linea1 == true || linea2 == true || linea3 == true)
                    {
                        Sehizolinea = true;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(13, collinea);
                        if (linea1 == true)
                        {
                            Console.Beep(800, 200);
                            Console.Beep(1000, 250);
                            Console.Beep(1200, 300);
                            Console.WriteLine("Jugador 1");
                            Console.ReadLine();
                            collinea++;
                        }
                        if (linea2 == true)
                        {
                            Console.Beep(800, 200);
                            Console.Beep(1000, 250);
                            Console.Beep(1200, 300);
                            Console.SetCursorPosition(13,collinea);
                            Console.WriteLine("Jugador 2");
                            Console.ReadLine();
                            collinea++;
                        }
                        if (linea3 == true)
                        {
                            Console.Beep(800, 200);
                            Console.Beep(1000, 250);
                            Console.Beep(1200, 300);
                            Console.SetCursorPosition(13 ,collinea);
                            Console.WriteLine("Jugador 3");
                            Console.ReadLine();
                        }
                    }
                }
                // METODO PARA SABER SI ALGUIEN HA HECHO BINGO
                // Nos indica en ganador quien lo ha hecho
                binnngo1=Aporbingo(j1);
                if (binnngo1 == true)
                    ganador[0] = 1;
                binnngo2=Aporbingo(j2);
                if (binnngo2 == true)
                    ganador[1] = 1;
                binnngo3=Aporbingo(j3);
                if (binnngo3== true)
                    ganador[2] = 1;

                // SI ALGUIEN HA HECHO BINGO, SE SALE
                if (binnngo1 == true || binnngo2 == true || binnngo3 == true)
                {
                    posbingo = bingo.Length+10;
                }
            }
        }

        // METODO PARA JUGAR AL BINGO
        static int[] Jugar(int[,] jugador1, int[,] jugador2, int[,] jugador3,Random jugar)
        {
            int [] ganador=new int[3];
            
            int[] bingo=new int[76];

            // METODO PARA HACER EL BINGO
            bingo=Colocar(jugar);

            //METODO PARA MOSTRAR EL BINGO
            //Mostrarbingo(bingo);

            // METODO PARA IR TACHANDO LOS NUMEROS ORDENADAMENTE DE LOS CARTONES
            // EMPEZARA POR EL PRIMERO NUMERO DEL BINGO, E IRA AUMENTANDO
            Tachar(bingo,jugador1,jugador2,jugador3,ganador);

            return (ganador);
        }

        // METODO CANCION FINAL
        static void Cancion()
        {
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

            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(mi, 300);
            Console.Beep(fa, 300);
            Console.Beep(mi, 300);
            Console.Beep(re, 300);
            Console.Beep(doo, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(sol, 300);
            Console.Beep(sol, 300);
            Console.Beep(fa, 300);

            Console.Beep(mi, 300);
            Console.Beep(mi, 300);
            Console.Beep(re, 300);
            Console.Beep(doo, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
            Console.Beep(mi, 300);
            Console.Beep(fa, 300);
            Console.Beep(mi, 300);
            Console.Beep(re, 300);
            Console.Beep(doo, 300);
            Console.Beep(re, 300);
            Console.Beep(re, 300);
        }

        //METODO PARA VER FINAL TOTAL
        static void Videofinal(int[] ganador)
        {
            int pos,colocar;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            colocar=30;


            Console.SetCursorPosition(15, 4);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enhorabuena : " );
            
            for (pos = 0; pos < ganador.Length; pos++)
            {
                if (ganador[pos] > 0)
                {
                    Console.SetCursorPosition(colocar, 4);
                    Console.WriteLine("Jugador {0} ", pos + 1);
                    colocar+=12;
                }

            }
        
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 8);
            Console.Write(@"
                                  |>>>                                 
                                  |                               
                    |>>>      _  _|_  _         |>>>              
                    |        |;| |;| |;|        |
                _  _|_  _    \\.    .  /    _  _|_  _
               |;|_|;|_|;|    \\:. ,  /    |;|_|;|_|;|
               \\..      /    ||;   . |    \\.    .  /
                \\.  ,  /     ||:  .  |     \\:  .  /
                 ||:   |_   _ ||_ . _ | _   _||:   |
                 ||:  .|||_|;|_|;|_|;|_|;|_|;||:.  |
                 ||:   ||.    .     .      . ||:  .|
                 ||: . || .     . .   .  ,   ||:   |       \,/
                 ||:   ||:  ,  _______   .   ||: , |            /`\
                 ||:   || .   /+++++++\    . ||:   |
                 ||:   ||.    |+++++++| .    ||: . |
              __ ||: . ||: ,  |+++++++|.  . _||_   |
     ____--`~    '--~~__|.    |+++++__|----~    ~`---,              ___
-~--~                   ~---__|,--~'                  ~~----_____-~'   `~----~~
                   Diseñado por Jesús Cuesta Arza ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Cancion();
            Console.ReadLine();
        }

        // METODO PARA MOSTRAR QUIEN HA GANADO
        static void Final(int[] ganador)
        {
            int pos,colocar;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep(800, 600);
            Console.Beep(1200, 600);
            Console.Beep(1600, 600);
            Console.Beep(2000, 600);
            colocar = 21;
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;

            for (pos = 0; pos < ganador.Length; pos++)
            {
                if (ganador[pos] > 0)
                {
                    Console.SetCursorPosition(59, colocar);
                    Console.WriteLine("Jugador {0}", pos + 1);
                    colocar++;
                }

            }
            Console.ReadLine ();
            Videofinal(ganador);


        }

        /* ----------------------------------------------------------------------------*/
        /* ------------------------------- MAIN ---------------------------------------*/
        /* ----------------------------------------------------------------------------*/
        static void Main(string[] args)
        {
            // METODO PRESENTACION
            Presentacion();

            // METODO PARA ENTORNO GRAFICO
            Graficos();

            // DECLARACION DE VARIABLES
            Random jugar = new Random(DateTime.Now.Millisecond);
            int[,] jugador1 = new int[5, 5];
            int[,] jugador2 = new int[5, 5];
            int[,] jugador3 = new int[5, 5];
            int[] ganador = new int[3];

            // Metodo inicializar jugadores
            Inicio(ref jugador1,ref jugador2,ref jugador3,jugar);

            // METODO PARA EMPEZAR A JUGAR y nos dice quien gana
            ganador=Jugar(jugador1, jugador2,jugador3,jugar);

            //MOSTRAR QUIEN HA HECHO BINGO
            Final(ganador);

            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
