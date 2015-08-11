using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace blackjack
{
    class blackjack
    {

        // METODO PARA DIBUJAR LOS BORDES A LAS CARTAS
        static void Bordescartas(int coloc)
        {
            int fil, col;
            col = 6 + coloc * 12;
            fil = 7;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(col + 0, fil + 0);
            Console.Write("-----------");
            Console.SetCursorPosition(col + 0, fil + 1);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 2);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 3);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 4);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 5);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 6);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 7);
            Console.Write("|         |");
            Console.SetCursorPosition(col + 0, fil + 8);
            Console.Write("-----------");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
        }

        // DIBUJO CORAZON
        static char Corazon()
        {
            int corazon2;
            corazon2 = 3;
            char corazon;
            corazon = Convert.ToChar(corazon2);
            return (corazon);
        }

        //DIBUJO DIAMANTE
        static char Diamante()
        {
            int diamante2;
            diamante2 = 4;
            char diamante;
            diamante = Convert.ToChar(diamante2);
            return (diamante);
        }

        //DIBUJO TREBOL
        static char Trebol()
        {
            int trebol2;
            trebol2 = 5;
            char trebol;
            trebol = Convert.ToChar(trebol2);
            return (trebol);
        }

        // DIBUJO PICAS
        static char Picas()
        {
            int picas2;
            picas2 = 6;
            char picas;
            picas = Convert.ToChar(picas2);
            return (picas);

        }

        //DIBUJO NUMEROS
        static void Dibnumeros(int numero, char palo,int coloc)
        {
            int fil, col;
            col = 8 + coloc * 12;
            fil = 8;
            Console.BackgroundColor = ConsoleColor.White;
            switch (numero)
            {
                case 1:
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("{0}", palo);
                    break;

                case 2:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    break;

                case 3:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("{0}", palo);
                    break;

                case 4:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 0, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    break;

                case 5:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 0, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("{0}", palo);
                    break;

                case 6:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 0, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 0, fil + 3);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 3);
                    Console.Write("{0}", palo);
                    break;

                case 7:
                    Console.SetCursorPosition(col + 0, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 0, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 6, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 6);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 0);
                    Console.Write("{0}", palo);
                    break;

                case 8:
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("J");
                    break;

                case 9:
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("Q");
                    break;

                default:
                    Console.SetCursorPosition(col + 6, fil + 0);
                    Console.Write("{0}", palo);
                    Console.SetCursorPosition(col + 3, fil + 3);
                    Console.Write("K");
                    break;
            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        // METODO PARA PONER COLOR CARTAS
        static void Colorcartas(char palo)
        {
            int eleccion;
            eleccion = palo;
            switch(eleccion)
            {
                case  3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                default:
                    break;
            }

        }

        //METODO PARA PONER NOMBRES A LOS JUGADORES
        static string[] Ponernombres(int cantjugador)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            string[] nombres = new string[cantjugador];
            int pos,fil;
            fil = 12;
            for (pos = 0; pos < nombres.Length-1; pos++)
            {
                Console.SetCursorPosition(16, fil);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0}              ", pos + 1);
                nombres[pos] = Console.ReadLine();
                Console.SetCursorPosition(14, fil + 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("---------------------------------------------------------------------------");

                fil += 2;
            }
            nombres[pos] = "Banca";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            return (nombres);
            
        }

        //METODO PARA SABER CON CUANTO DINERO EMPIEZAN
        static double[] Cantidadinicial(int cantjugador,string[]nombres)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            double[] dinero = new double[cantjugador];
            int pos,fil;
            fil = 12;
            for (pos = 0; pos < dinero.Length - 1; pos++)
            {
                Console.SetCursorPosition(66, fil);
                dinero[pos] = float.Parse(Console.ReadLine());
                fil += 2; ;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            return (dinero);

        }

        //METODO NOS Calcula LOS PUNTOS QUE TIENE CADA UNO
        static int[] Puntuacion(int quienjuega, int[,] jugadores)
            // SI LA CARTA TERMINA EN 8- 9 -0, SON LAS FIGURAS Y VALEN 10
        {
            int pos, total;
            int[] puntos = new int[jugadores.Length - 1];

            for (quienjuega = 0; quienjuega < jugadores.GetLength(0); quienjuega++)
            {
                total = 0;
                for (pos = 0; pos < jugadores.GetLength(1); pos++)
                {
                    // PARA QUE SUME 10 PUNTOS CUANDO VALGA 0, PERO QUE NO LO CONFUNDA, CON LOS
                    // O PUESTOS PARA RELLENAR HUECOS. EL O ES EL REY
                    if (jugadores[quienjuega, pos] > 0)
                    {
                        if (jugadores[quienjuega, pos] % 10 == 0)
                            total += 10;
                        else
                        {
                            // TERMINACIONES 8 Y 9 SON SOTA Y CABALLO
                            if (jugadores[quienjuega, pos] % 10 == 8 || jugadores[quienjuega, pos] % 10 == 9)
                                total += 10;
                            else
                                total += jugadores[quienjuega, pos] % 10;
                        }
                    }
                }
                puntos[quienjuega] = total;
            }

            return (puntos);
        }

        // SI ALGUIEN SUPERA LOS 21 PUNTOS, YA NO PUEDE CONTINUAR JUGANDO
        static bool Controlpuntos(int quienjuega, int[,] jugadores)
        {
            bool jugar;
            int[] puntos;
            puntos=Puntuacion(quienjuega, jugadores);
            jugar = true;

            if (puntos[quienjuega] > 21)
                jugar = false;
            return (jugar);
        }

        // METODO PARA MOSTRAR LA BARAJA
        static void Mostrarbaraja(int[] baraja)
        {
            int pos;

            Console.SetCursorPosition(0, 18);

            for (pos = 0; pos < baraja.Length; pos++)
                Console.Write("{0} ", baraja[pos]);

            Console.Write("------\n");
        }

        // METODO PARA CONTROLAR QUE NO SE REPITAN NUMEROS DENTRO DE LA BARAJA
        static bool Norepetir(int[] baraja, int numero, int posicion)
        {
            bool control;
            int pos;
            control = true;

            for (pos = posicion - 1; pos >= 0; pos--)
            {
                if (numero == baraja[pos])
                {
                    return false;
                }
            }
            return (control);
        }

        // NOS BARAJA LAS CARTAS Y LAS DEJA EN UN ORDEN
        static void Ordenarcartas(int[] baraja,Random aleatorio)
        {
            int pos;
            bool control;
            control = true;

            for (pos = 0; pos < baraja.Length - 1; pos++)
            {
                do
                {
                    baraja[pos] = aleatorio.Next(1, 40);
                    control = Norepetir(baraja, baraja[pos], pos);

                } while (control == false);
            }

        }

        // SOLICITA NUMERO JUGADORES Y LE SUMAMOS UNO POR LA BANCA
        static int Cuantosjuegan()
        {
            int jugador;
            ConsoleKey cantidadjugadores;
            Console.SetCursorPosition(13, 7);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  Cantidad de jugadores  ");
            Console.SetCursorPosition(45, 7);
            Console.Write("   ");
            Console.ForegroundColor = ConsoleColor.Blue;
            do
            {
                Console.SetCursorPosition(46, 7);
                cantidadjugadores = Console.ReadKey().Key;
                jugador = (int)cantidadjugadores - 48;
            } while (jugador > 5||jugador<1);
            // LO AUMENTAMOS EN UNO POR LA BANCA
            jugador += 1;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            return (jugador);
        }

        // REPARTE LA SIGUIENTE CARA AL JUGADOR
        static void Repartir(int quienjuega,int[,] jugadores, int[] baraja,ref int posbaraja)
        {
            int carta;

            for (carta=0; carta < jugadores.GetLength(1); carta++)
            {
                if (jugadores[quienjuega,carta]==0)
                {
                    jugadores[quienjuega, carta] = baraja[posbaraja];
                    posbaraja++;
                    carta = jugadores.GetLength(1);
                }

            }

        }

        // MOSTRAR CARTAS DE LOS JUGADORES -- ya no lo uso, pero lo guardo para corregir errores
        static void Mostrarjugadores(int[,] jugadores)
        {
            int fil, col;

            for (fil = 0; fil < jugadores.GetLength(0); fil++)
            {
                for (col = 0; col < jugadores.GetLength(1); col++)
                {
                    if (jugadores[fil,col]>0)
                    Console.Write("{0,4}",jugadores[fil,col]%10);
                }
                Console.WriteLine("");
            }

        }

        // METODO PARA INICAR EL PRIMER REPARTO
        static void Inicioreparto(int quienjuega, int[,]jugadores, int[]baraja, ref int posbaraja,double[] dinero)
        {
            // NOS PASA POR TODOS LOS JUGADORES DOS VECES
            for (quienjuega = 0; quienjuega < jugadores.GetLength(0); quienjuega++)
            {
                // SI NO TIENE DINERO YA NO LE DAMOS CARTAS
                if (dinero[quienjuega]>0)
                    // REPARTE  CARTA A UN JUGADOR
                    Repartir(quienjuega, jugadores, baraja, ref posbaraja);
            }
            for (quienjuega = 0; quienjuega < jugadores.GetLength(0); quienjuega++)
            {
                // SI NO TIENE DINERO YA NO LE DAMOS CARTA
                if (dinero[quienjuega] > 0)
                    // REPARTE  CARTA A UN JUGADOR
                    Repartir(quienjuega, jugadores, baraja, ref posbaraja);
            }
        }

        //METODO PARA APOSTAR DINERO
        static int Apostar(double[] dinero,int quienjuega,string[] nombres)
        {
            int apuesta;
            Console.WriteLine("{0}: ", nombres[quienjuega]);
            Console.WriteLine("Dinero que tiene: {0}", dinero[quienjuega]);
            Console.Write("Dinero que apuesta: ");
            do
            {
                apuesta = int.Parse(Console.ReadLine());
                if (apuesta> dinero[quienjuega])
                    Console.WriteLine("No tienes suficiente dinero para esa apuesta. Escribe otra cantidad: ");
            } while (apuesta > dinero[quienjuega]);
            return (apuesta);
        }

        //METODO PARA DIBUJAR LA CABECERA DE LAS CARTAS DE LOS JUGADORES
        static void Cabeceracartas(int quienjuega,string[]nombres)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(16, 1);
            Console.Write("---------------------------------------------------------------------");
            Console.SetCursorPosition(16, 2);
            Console.Write("                                                                     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(16, 3);
            Console.Write("                                                                     ");
            Console.SetCursorPosition(45, 3);
            Console.Write("{0}", nombres[quienjuega]);
            Console.SetCursorPosition(16, 4);
            Console.Write("                                                                     ");
            Console.SetCursorPosition(16, 5);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("---------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //METODO PARA REPARTIR LAS CARTAS A LOS JUGADORES MIENTRAS QUIERAN
        static double[] Repartocartas(ref int quienjuega, int[,] jugadores, int[] baraja, ref int posbaraja,string[] nombres,double[]dinero) 
        {
            int[] seguir=new int[jugadores.GetLength(1)];
            bool jugar;
            jugar = true;
            char cogcart2;
            double[] apuesta = new double[dinero.Length]; 

            for (quienjuega = 0; quienjuega < jugadores.GetLength(0)-1; quienjuega++)
            {
                Console.Clear();
                if (dinero[quienjuega] > 0)
                {
                    apuesta[quienjuega] = Apostar(dinero, quienjuega, nombres);
                    do
                    {
                        Console.Clear();
                        Cabeceracartas(quienjuega, nombres);
                        Mostrarealesuno(jugadores, quienjuega, nombres);
                        Console.SetCursorPosition(0, 17);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("¿Deseas coger una carta?");
                        do
                        {
                            cogcart2 = Console.ReadKey(true).KeyChar;
                            cogcart2 = char.ToUpper(cogcart2);
                            switch (cogcart2)
                            {
                                case 'S':
                                    Console.Beep(1000, 300);
                                    Repartir(quienjuega, jugadores, baraja, ref posbaraja);
                                    jugar = Controlpuntos(quienjuega, jugadores);
                                    if (jugar == false)
                                    {
                                        Mostrarealesuno(jugadores, quienjuega, nombres);
                                        Console.SetCursorPosition(0, 18);
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("- Has superado los 21 puntos, has perdido");
                                        Console.Beep(300, 400);
                                        Console.Beep(400, 450);
                                        Console.Beep(500, 500);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ReadKey();
                                    }
                                    break;

                                default:
                                    break;
                            }
                        } while (cogcart2 != 'S' && cogcart2 != 'N');

                    } while (cogcart2 == 'S' && jugar == true);
                }
            }
            return (apuesta);

        }

        //NOS MUESTRA LOS PUNTOS DE LOS JUGADORES
        static void Mostrarpuntuacion(int[] puntos,string[]nombres)
        {
            int pos;

            for (pos = 0; pos < puntos.Length; pos++)
            {
                if (puntos[pos]!=0)
                    Console.WriteLine("{0}: {1} puntos", nombres[pos],puntos[pos]); 
            }

        }

        //METODO PARA VER EL DINERO QUE TIENEN LOS JUGADORES - LO DEJO PARA CORRREGIR ERRORES
        static void Dinerototal(double []dinero)
        {
            int pos;

            for (pos = 0; pos < dinero.Length; pos++)
            {
                Console.WriteLine("{0}", dinero[pos]);
                Console.ReadKey();
            }
        }

        //METODO PARA VER LAS APUESTAS DE LOS JUGADORES - DEJADO PARA CORREGIR ERRORES
        static void Apuestastotal(double[] apuestas)
        {
            int pos;

            for (pos = 0; pos < apuestas.Length; pos++)
            {
                Console.WriteLine("{0}", apuestas[pos]);
                Console.ReadKey();
            }
        }

        //METODO QUE NOS DICE QUIEN GANA  Y HACE LAS MODIFICACIONES DE DINERO DE DINERO
        static void Ganador(int[] puntos, int[,] jugadores, string[] nombres, double[] dinero, double[] apuesta)
        {
            Console.Clear();
            int pos;

            //CONTROL POR SI LA BANCA SE PASA DE 21
            // IGUALA a 0 PUNTOS SI SE HAN PASADO DE 21
            if (puntos[jugadores.GetLength(0)-1] > 21)
            {
                puntos[jugadores.GetLength(0)-1] = 0;
                Console.Write("La Banca se ha pasado de 21");
                Console.ReadKey();
            }

            for (pos = 0; pos < jugadores.GetLength(0) - 1; pos++)
            {
                if (dinero[pos] > 0)
                {
                    //NOS DICE SI ALGUIEN HA HECHO BLACKJACK, NECESITA TENER UN AS Y UNA FIGURA, DOS CARTAS
                    if (jugadores[pos, 2] == 0)
                    {
                        if (21 - puntos[pos] == 0)
                        {
                            Console.Write("{0} has hecho blackjack", nombres[pos]);
                            dinero[pos] += (apuesta[pos] * 1.5);
                        }
                    }

                    // IGUALA a 0 PUNTOS SI SE HAN PASADO DE 21
                    if (puntos[pos] > 21)
                    {
                        puntos[pos] = 0;
                    }

                    // PARA SABER QUIEN LE HA  GANADO A LA BANCA, SI SUPERA SU PUNTUACIÓN
                    if (puntos[pos] > puntos[(jugadores.GetLength(0) - 1)])
                    {
                        Console.WriteLine("Has ganado la apuesta {0}", nombres[pos]);
                        dinero[pos] += (apuesta[pos] * 2);
                    }
                    else
                    {
                        puntos[pos] = 0;
                    }

                    // PARA QUITAR EL DINERO APOSTADO QUIENES HAYAN PERDIDO Y NO ESTEN EN LAS OTRAS
                    // CARACTERISTICAS
                    if (puntos[pos] == 0)
                    {
                        dinero[pos] = dinero[pos] - apuesta[pos];
                        Console.WriteLine("Has perdido este juego {0}", nombres[pos]);
                    }
                    Console.WriteLine("Dinero: {0}\n", dinero[pos]);
                }
            }

        }

        //--METODO PARA VER LAS CARTAS REALES EN FIGURAS DE LOS JUGADORES--
        static void Mostrarealesuno(int[,] jugadores, int fil, string[] nombres)
        {

            int col;
            char palo;
            for (col = 0; col < jugadores.GetLength(1); col++)
            {
                if (jugadores[fil, col] > 0)
                {
                    if (jugadores[fil, col] < 11)
                        palo = Corazon();
                    else
                    {
                        if (jugadores[fil, col] < 21)
                            palo = Picas();
                        else
                        {
                            if (jugadores[fil, col] < 31)
                                palo = Trebol();
                            else
                                palo = Diamante();
                        }
                    }
                    Bordescartas( col);
                    Colorcartas(palo);
                    Dibnumeros(jugadores[fil, col] % 10, palo,col);
                }
            }
            Console.WriteLine("");
        }

        //METODO PARA MOSTRAR LA CABECERA DE TODAS LAS CARTAS
        static void Cabeceratotal()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(9, 3);
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.SetCursorPosition(9, 4);
            Console.Write("                                          ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(9, 5);
            Console.Write("      CARTAS DE TODOS LOS JUGADORES       ");
            Console.SetCursorPosition(9, 6);
            Console.Write("                                          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
        }

        // METODO PARA MOSTRAR PON PANTALLA EL NUMERO DE LA CARTA y el palo
        // NOS CONVIERTE LA J,Q Y K
        static void Figuras(int[,] jugadores, char palo,int fil,int col)
        {
            if (jugadores[fil, col] % 10 == 8)
                Console.Write("{0,4} {1}", 'J', palo);
            else
            {
                if (jugadores[fil, col] % 10 == 9)
                    Console.Write("{0,4} {1}", 'Q', palo);
                else
                {
                    if (jugadores[fil, col] % 10 == 0)
                        Console.Write("{0,4} {1}", 'K', palo);
                    else
                    {
                        Console.Write("{0,4} {1}", jugadores[fil, col] % 10, palo);
                    }
                }
            }
        }

        //METODO PARA VER LAS CARTAS REALES DE TODOS LOS JUGADORES
        static void Mostrareales(int[,] jugadores,string []nombres)
        {
            Console.Clear();
            //METODO PARA MOSTRAR CABECERA DE TODAS LAS CARTAS
            Cabeceratotal();
            int fil, col;
            char palo;
            Console.WriteLine("  -----------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("   JUGADORES                          CARTAS\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  -----------------------------------------------------------------------\n");
            for (fil = 0; fil < jugadores.GetLength(0); fil++)
            {
                // POR SI EL JUGADOR NO TIENE CARTAS PORQUE SE HA RETIRADO
                Console.Write("    {0,-15} ", nombres[fil]);
                // SI NO TIENE CARTAS APARECEREA QUE ESTA RETIRADO
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (jugadores[fil, 0] == 0)
                    Console.Write(" -- RETIRADO -- ");
                Console.ForegroundColor = ConsoleColor.White;

                for (col = 0; col < jugadores.GetLength(1); col++)
                {
                    if (jugadores[fil, col] > 0)
                    {
                        if (jugadores[fil, col] < 11)
                            palo = Corazon();
                        else
                        {
                            if (jugadores[fil, col] < 21)
                                palo = Picas();
                            else
                            {
                                if (jugadores[fil, col] < 31)
                                    palo = Trebol();
                                else
                                    palo = Diamante();
                            }
                        }
                        // METODO PARA MOSTRAR PON PANTALLA EL NUMERO DE LA CARTA y el palo
                        // NOS CONVIERTE LA J,Q Y K
                        Figuras(jugadores,palo,fil,col);
                    }
                }
                Console.WriteLine("\n");
                if (fil==jugadores.GetLength(0)-2)
                    Console.WriteLine("  ------------------------------------------------------\n");
            }
            Console.WriteLine("  ------------------------------------------------------\n");

        }

        //PARA ELEGIR QUIEN TENGA UN AS, SI QUIERE 1 O 11 PUNTOS
        // la banca no elige as
        static void ElegirAs(int[,] jugadores, string[] nombres, int[] puntos)
        {
            int fil,col;
            char elegir;

            for (fil = 0; fil < jugadores.GetLength(0)-1; fil++)
            {
                for (col = 0; col < jugadores.GetLength(1); col++)
                {
                    if (jugadores[fil,col] % 10 == 1)
                    {
                        Console.WriteLine("\n {0} tienes un as, ¿deseas que valga 11 puntos?",nombres[fil]);
                        do
                        {
                            elegir = Console.ReadKey(true).KeyChar;
                            elegir = char.ToLower(elegir);
                            if (elegir == 's')
                                puntos[fil] += 10;
                        } while (elegir != 's' && elegir != 'n');
                    }
                }
            }

        }

        // METODO PARA SABER SI LA BANCA COGE 11 O 1 PUNTO DEL AS
        static void Asbanca(int[,] jugadores,int[]  puntos)
        {
            int pos;
            // SE APLICARA CUANDO TENGA MENOS DE 11 PUNTOS, YA QUE SINO, SE PASARIA DE PUNTUACION
            // SOLO SE LE SUMA 10, PORQUE EL 1 YA SE LE HA SUMADO
            if (puntos[jugadores.GetLength(0) - 1] < 11)
            {
                Console.Write("{0}", jugadores.GetLength(0) - 1);
                for (pos = 0; pos < jugadores.GetLength(1); pos++)
                {
                    if (jugadores[jugadores.GetLength(0) - 1, pos] == 1)
                    {
                        if (puntos[jugadores.GetLength(0) - 1] < 11)
                        {
                            puntos[jugadores.GetLength(0) - 1] += 10;
                        }
                    }
                }
            }
        }

        //LA BANCA COGE CARTAS HASTA TENER 16 O MÁS PUNTOS
        // PONGO PUNTUACION ANTES Y DESPUES, PORQUE NOS TIENE QUE CALCULAR LOS PUNTOS ANTES DE ENTRAR
        // Y DESPUES DE COGER LA CARTA, POR SI DEBE COGER MÁS CARTAS
        static void Jugarbanca(int [,]jugadores,int[]baraja,ref int posbaraja)
        {
            int quienjuega;
            int[] puntos;
            quienjuega = jugadores.GetLength(0)-1;
            puntos = Puntuacion(quienjuega, jugadores);
            Asbanca(jugadores, puntos);
            puntos = Puntuacion(quienjuega, jugadores);
            do
            {
                Repartir(quienjuega, jugadores, baraja, ref posbaraja);
                Asbanca(jugadores, puntos);
                puntos = Puntuacion(quienjuega, jugadores);
            } while ((puntos[quienjuega] < 15));
            
        }

        // METODO PARA EMPEZAR A JUGAR
        static void Jugar(int[,] jugadores, int[] baraja, string[] nombres,double[] dinero)
        {
            // COGER CARTAS NOS DIRA SI QUEREMOS COGER CARTAS O NO

            int posbaraja,quienjuega;
            posbaraja = 0;
            quienjuega = 0;
            int[] puntos;
            double[] apuesta;

            // METODO PARA REPARTO DE CARTAS INCIAL
            Inicioreparto(quienjuega, jugadores, baraja, ref posbaraja,dinero);

            // METODO PARA REPARTIR CARTAS A LOS JUGADORES SI QUIEREN
            apuesta=Repartocartas(ref quienjuega, jugadores, baraja, ref posbaraja,nombres,dinero);

            // LA BANCA COJE CARTAS HASTA TENER 16 O MAS PUNTOS
            Jugarbanca(jugadores,baraja,ref posbaraja);

            // ----------- PARA IR COMPROBANDO LAS CARTAS DE LOS JUGADORES ------
            Mostrareales(jugadores,nombres);
            Console.ReadKey(true);

            // METODO PARA SABER CUANTOS PUNTOS TENEMOS
            puntos=Puntuacion(quienjuega,jugadores);

            //PARA ELEGIR QUIEN TENGA UN AS, SI QUIERE 1 O 11 PUNTOS
            ElegirAs(jugadores, nombres, puntos);

            // METODO NOS MUESTRA LOS PUNTOS QUE TENEMOS
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Mostrarpuntuacion(puntos,nombres);
            Console.ReadKey();

            // NOS DICE QUIEN HA GANADO
            Ganador(puntos,jugadores,nombres,dinero,apuesta);
        }

        //METODO PARA SABER SI SE QUIERE CONTINUAR JUGANDO
        static bool Seguirjugando()
        {
            bool continuar;
            continuar = true;
            char eleccion;

            Console.WriteLine("¿Desea alguien continuar jugando en esta Mesa?");
            do
            {
                eleccion = Console.ReadKey(true).KeyChar;
                eleccion = char.ToLower(eleccion);
                if (eleccion == 's')
                    continuar = true;
                else
                    continuar = false;
            } while (eleccion != 's' && eleccion != 'n');

            return (continuar);
        }

        // METODO PARA PREGUNTARLE A LOS JUGADORES SI QUIEREN CONTINUAR JUGANDO
        static void Preguntarjugadores(double[] dinero,string[] nombres)
        {
            int pos;
            char retiro;
            for (pos = 0; pos < nombres.Length-1; pos++)
            {
                if (dinero[pos] > 0)
                {
                    Console.WriteLine("{0} ¿Deseas retirarte?", nombres[pos]);
                    retiro = Console.ReadKey(true).KeyChar;
                    retiro = char.ToLower(retiro);
                    if (retiro == 's')
                        dinero[pos] = 0;
                }

            }
        }
        
        //PRESENTACION
        static void Presentacion()
        {
            Console.SetWindowSize(85, 45);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(@"                                 .     @$* @$3
                                '$Nueeed$$ed$$eeec$$
             ,            4$Lze@*$C2$b* ed(he*rb$CC$*$bc@$r              
       /@ |~~            .e$$'W$$B$B$**  ^$  e""##d?$Bd$$$Nc. ..      @\/~\ 
       \==|         4$kd*Cr$6F#'`  **   .*==      # ''**F#$I$b$*       |   I
          |         d$5N@$$'   ....eu$$$$$$N$*$zbeuu     #$d$$$$b.     / @/
         @/     . z$Ted*'$P zue$*9d$$$@##  .  #W$e@B$$L.    '#@$E$b@N
               #d$Id*P#  'Nd$$B$**¨       .*,     ¨#*N$$b$c   $$$*$$c
              .d#+C6J   @@$B$*¨          -***-        ¨#$$$$c   *$$$#$u
           ..u$l4@¨^¨zJ$7W*¨              '*`            ^*$@$$$r ¨$$E$@B>
           *@$l$P¨+Rd$$N#¨          *     /|\     *        '¨$$$c.. ?E$*b
           z$ ¨*.  .Jz$¨           ***   / | \   ***         '*@N$b   d**N
         .z$JBR^bs@$$#          *   *   /  |  \   *  *         ¨$l*9N ¨bN$Nee
        4$$.C*   dB@¨          ***    _/  /^\  \_   ***         '$$$z> 3$b$$#
         $¨$e$  @*$¨        *   *     \\^|   |^//    *   *        $$$u.^*$N$c
        JPd$%  @@d¨        ***        ***********       ***       '$Ni$  $EP$
      :e$¨*$  :et$          *         ***********        *         ^$$E  4$N$be
      ')$ud¨  @6$                                                   9$$   $*@$¨
       @F*$   *4P                       ./                          '$m#   .$$.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@"
    u*¨¨¨¨¨¨¨¨¨¨¨¨h                     ##=====                    e#¨¨¨¨¨¨¨¨¨¨¨#
    E +e       ue. N                 ___##_______                 4F e=c     z*c
    #e$@e.. ..z6+6d¨                #*JESUSCUESTA*/               ^*cBe$u.  .$$@
       $ ^¨¨¨¨ 4F¨  ze=eu              *1ºDAI**              z***hc ^¨$ ¨¨*¨¨ $
       $       ^F :*    3r                                  @¨  e ¨b  $       $
     .e$        N $  'be$L...                            ...?be@F  $F $       9F
    4¨ $        $ $.  zm$*****h.                      ue¨¨¨¨*h6   J$¨ $       4%
    $  $        $ $$u5e¨ .     ¨k                    d¨       #$bu$F  $       4F
    ¨N $        $ ^d%P  dF      $  .            .e   $     -c  ¨N$F  .$       4F
     #$$        $  $4*. ¨N.    zP  3r ..    ..  $c   *u     $  u$K$  4F       4L
      ^N$e.     3  F$k*. ¨*C$$$# .z$¨ '$    4L  ¨$c. '#$eeedF  $$$9r JF       J$
       $'¨$$eu. 4  F3¨K$ .e=*CB$$$$L .e$    '$bc.u$***hd6C¨¨  4kF$4F $F     u@$F
       $   '¨*$*@u N'L$B*¨z*¨¨     ¨$F¨ 4k 4c '7$¨      ¨*$eu 4'L$J¨ $   .e$*¨4F
       $      '¨hC*$ ¨$#.P¨          $me$¨  #$*$       .  ^*INJL$¨$  $e$$*#   4F
       $         $b¨h ¨.F     $¨     ^F        $       9r   #L#$FJEd#C@¨      4L
      .$         $Jb   J¨..  4b      uF        *k      J%    #c^ $¨ d$        4L
     :¨$         $k9   $ $%4c $Bme.ze$         '*$+eee@*$¨  :r$    @L$        4$
     $ $         $$Jr  $d¨ '$r ¨*==*¨            ¨#**¨¨ $r  4$3r  db$F        4F
     $c$         $'*F  $¨   '$            /\            $    *(L  $$$F         k
     #i*e.       $ 4>  $  ue $         \`.||.'/         'L c  $$ .L$d         .$
      ¨b.¨*e.    4 4   $  $%db=eL     `.<\||/>.'      e*+$/$r  $ '$¨$       .d$$
       $^#+cC*mu 4r4   4r:6@F  $$    -----++-----    <$. ¨N?N  F  $ $    ud$$* $
       $    ¨*eJ¨@L4   4k*3Ic.*¨      .'</||\>`.      #*5.J$$..F  $ $ ue#2*¨   $
       $       ¨N.¨@r  4Fd¨ '$r        /.'||`.\        4$ '¨N*d¨  9.$#Ce*¨     $
       $         ¨e^¨  'd¨ uz$%           \/           '$czr¨k#¨  4Pu@¨        $
");
            Console.SetCursorPosition(39, 17);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("BLACKJACK");
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }

        //PARA SABER SI QUEDAN JUGADORES EN LA MESA
        static bool Quedanjugadores(double[] dinero)
        {
            bool quedan;
            int pos;
            double cant;
            cant = 0;
            quedan = true;
            for (pos = 0; pos < dinero.Length; pos++)
            {
                cant += dinero[pos];
            }
            if (cant == 0)
                quedan = false;
            return (quedan);
        }

        //METODO PARA JUGAR Y SEGUIR JUGANDO VARIAS PARTIDAS
        static void Juegototal(int[,] jugadores, int[] baraja, string[] nombres, double[] dinero, bool continuar, int cantjugador,Random jugar)
        {
            do
            {
                //METODO PARA SABER SI QUEDAN JUGADORES EN LA MESA, SI NO QUEDAN DA FALSE Y TERMINA
                continuar = Quedanjugadores(dinero);
                if (continuar == true)
                {
                    // EMPEZAR A JUGAR
                    Jugar(jugadores, baraja, nombres, dinero);

                    //SI AL TERMINAR LA PRIMERA PARTIDA, YA NADIE TIENE DINERO
                    continuar = Quedanjugadores(dinero);
                    if (continuar == true)
                    {
                        continuar = Seguirjugando();
                        if (continuar == true)
                        {
                            //METODO PARA BORRAR LAS CARTAS QUE TENIAN ANTES,BARAJAR OTRA VEZ LA BARAJA
                            // PREGUNTAR A LOS JUGADORES SI QUIEREN CONTINUAR JUGANDO
                            Ordenarcartas(baraja, jugar);
                            jugadores = new int[cantjugador, 10];
                            Preguntarjugadores(dinero, nombres);
                        }
                    }
                }
            } while (continuar == true);
        }

        //METODO GRAFICOS PARTIDA NORMAL
        static void Graficos()
        {
            Console.SetWindowSize(100, 35);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //GRAFICOS EMPIEZAN JUGADORES
        static void Graficosjugadores()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(10, 3);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 4);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 5);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 6);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 7);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 8);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 9);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 10);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 11);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 12);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 13);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 14);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 15);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 16);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 17);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 18);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 19);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 20);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 21);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 22);
            Console.Write("                                                                                   ");
            Console.SetCursorPosition(10, 23);
            Console.Write("                                                                                   ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(12, 4);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                                   BLACKJACK                                   ");
            Console.SetCursorPosition(13, 9);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 10);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 11);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 12);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 13);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 14);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 15);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 16);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 17);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 18);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 19);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 20);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(13, 21);
            Console.Write("                                                                             ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(16, 10);
            Console.Write("Nº                NOMBRE");
            Console.SetCursorPosition(64, 10);
            Console.Write("DINERO INICIAL");
        }

        // ------- MAIN --------- 
        static void Main(string[] args)
        {
            Presentacion();

            Random jugar = new Random(DateTime.Now.Millisecond);
            int[] baraja = new int[40];
            int cantjugador;
            string[] nombres;
            double[] dinero;
            bool continuar;
            continuar = true;

            //GRAFICOS PARTIDA NORMAL
            Graficos();

            //GRAFICOS PRIMERA PANTALLA
            Graficosjugadores();

            // METODO QUE NOS PIDE EL NUMERO DE JUGADORES
            cantjugador = Cuantosjuegan();

            //METODO PARA SABER NOMBRES DE JUGADORES
            nombres = Ponernombres(cantjugador);

            //METODO PARA SABER CUANTO DINERO TIENE CADA JUGADOR
            dinero = Cantidadinicial(cantjugador, nombres);

            // CREAMOS LA MATRIZ PARA JUGADORES Y DENTRO LAS CARTAS QUE TENDRAN
            int [,] jugadores=new int[cantjugador,10];

            // METODO PARA CREAR EL ORDEN DE LAS CARAS
            Ordenarcartas(baraja,jugar);      
            
            //COMENZAR A JUGAR AL BLACKJACK
            Juegototal(jugadores, baraja, nombres, dinero, continuar, cantjugador,jugar);
        }
    }
}
