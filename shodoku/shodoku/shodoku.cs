using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace shodoku
{
    class shodoku
    {
        static int[,] shodokuvalores = new int[9, 9];
        static int[,] shodokuresuelto = new int[9,9];
        static System.Media.SoundPlayer musicapre,msalir,mganar;
        //DONDE ESTA LA MUSICA DEL JUEGO
        static string ubicacion=@"sonidos\";

        //CREDITOS FINAL
        static void Creditos()
        {
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(@"
                          __                    __
          __       __     \_\  __          __   \_\  __   __       __
          \_\     /_/        \/_/         /_/      \/_/   \_\     /_/
        .-.  \.-./  .-.   .-./  .-.   .-./  .-.   .-\   .-.  \.-./  .-.
       //-\\_//-\\_//-\\_//-\\_//-\\_//-\\_// \\_//-\\_//-\\_//-\\_//-\\
     __(   '-'   '-'\  '-'   '-'  /'-'   '-'\__'-'   '-'__/'-'   '-'\__
    /_/))            \__       __/\          \_\       /_/           \_\
 ___\_//              \_\     /_/  \__
/_/  ((                             \_\
      )) __
__   // /_/
\_\_((_/___
     ))  \_\
     \\
      )) 
__   // /_/           GRACIAS POR JUGAR
\_\_((
     \\
      )) __
__   // /_/
\_\_((_/___
     ))  \_\
     \\
      )) _
__   // /_/                    AUTOR   JESUS CUESTA ARZA
\_\_((_/
     \\
      )) __
__   // /_/                                   
\_\_((_/___
     ))  \_\              __                    __
     \\     __       __     \_\  __          __   \_\  __   __       __
  __  ))    \_\     /_/        \/_/         /_/      \/_/   \_\     /_/
  \_\_((   .-.  \.-./  .-.   .-./  .-.   .-./  .-.   .-\   .-.  \.-./  .-.
       \\_//-\\_//-\\_//-\\_//-\\_//-\\_//-\\_// \\_//-\\_//-\\_//-\\_//-\\
           \__'-'   '-'\  '-'   '-'  /'-'   '-'\__'-'   '-'__/'-'   '-'\__
            \_\         \__       __/\          \_\       /_/           \_\
                         \_\     /_/  \__
                                       \_\");
        }

        //FONDO BLANCO TABLERO
        static void Fondoblanco()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 0; pos < 36; pos++)
            {
                Console.WriteLine("                                                                         ");
            }
        }

        //MUSICA PRESENTACION
        static void Musicapresentacion()
        {
            musicapre = new System.Media.SoundPlayer(ubicacion + "ENDS.wav");
            musicapre.Play();
        }

        //MUSICA SALIR
        static void Musicasalir()
        {
           msalir = new System.Media.SoundPlayer(ubicacion + "salir.wav");
           msalir.Play();
        }

        //MUSICA GANAR
        static void Musicaganar()
        {
            mganar = new System.Media.SoundPlayer(ubicacion + "ganar.wav");
            mganar.Play();
        }

        //BORDES LINEAS HORIZONTALES
        static void Lineashori()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
            Console.Write("                                                                         ");
            Console.SetCursorPosition(0, 12);
            Console.Write("                                                                         ");
            Console.SetCursorPosition(0, 24);
            Console.Write("                                                                         ");
            Console.SetCursorPosition(0, 36);
            Console.Write("                                                                         ");
        }

        //BORDES LINEAS VERTICALES
        static void Lineasverti()
        {
            int col, fil,tope;
            tope = 37;
            col = 0;
            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col, fil);
                Console.Write(" ");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col + 24, fil);
                Console.Write(" ");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col + 48, fil);
                Console.Write(" ");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col + 72, fil);
                Console.Write(" ");
            }
        }

        //BORDES GRUESOS TABLERO
        static void Bordestablero()
        {
            Lineashori();
            Lineasverti();
        }

        //SEPARADORS VERTICALES
        static void Separadoresver()
        {
            int fil,col,tope;
            tope = 37;
            col = 0;
            Console.ForegroundColor = ConsoleColor.Black;
            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+8, fil);
                Console.Write("|");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+16, fil);
                Console.Write("|");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+32, fil);
                Console.Write("|");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+40, fil);
                Console.Write("|");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+56, fil);
                Console.Write("|");
            }

            for (fil = 0; fil < tope; fil++)
            {
                Console.SetCursorPosition(col+64, fil);
                Console.Write("|");
            }
        }

        //SEPARADORES HORIZONTALES
        static void Separadoreshorin()
        {
            int fil, col;
            for (fil = 4; fil < 34; fil+=4)
            {
                for (col = 0; col < 72; col++)
                {
                    Console.SetCursorPosition(col, fil);
                    Console.Write("-");
                }
            }
        }

        //DIBUJO SEPARADORES
        static void Separadores()
        {
            Separadoresver();
            Separadoreshorin();

        }

        //DIBUJO DEL TABLERO
        static void Dibujotablero()
        {
            Fondoblanco();
            Separadores();
            Bordestablero();

        }

        //DIBUJAR FONDO
        static void Dibujofondo()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
        }

        //LETRAS DERECHA MEMBRETE
        static void Letrasmembrete(int col, int fil)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(col + 8, fil - 5);
            Console.Write("SUDOKU");
        }

        //FONDO NEGRO DERECHA
        static void Fondonegro()
        {
            int fil;
            Console.BackgroundColor = ConsoleColor.Black;
            for (fil = 0; fil < 5; fil++)
            {
                Console.SetCursorPosition(73, fil);
                Console.Write("                           ");
            }
            for (fil = 18; fil < 37; fil++)
            {
                Console.SetCursorPosition(73, fil);
                Console.Write("                           ");
            }
            for (fil = 0; fil < 36; fil++)
            {
                Console.SetCursorPosition(99, fil);
                Console.Write(" ");
            }
        }

        //LETRAS DEL LADO DERECHO DEL TABLERO
        static void Letrasderecha()
        {
            int col, fil;
            col = 75;
            fil = 7;
            Fondonegro();
            Letrasmembrete(col, fil);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(col, fil);
            Console.Write("Jugador");
            Console.SetCursorPosition(col, fil + 4);
            Console.Write("Nivel");
            Console.SetCursorPosition(col, fil + 8);
            Console.Write("Nº Movimientos: ");
        }

        //LETRAS DERECHA INFERIOR
        static void Letrasderechainfe()
        {
            int col, fil;
            col = 75;
            fil = 24;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(col, fil-3);
            Console.Write("      OPCIONES");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(col, fil);
            Console.Write("Salir: Escape");
            Console.SetCursorPosition(col, fil + 2);
            Console.Write("Ayuda: A");
            Console.SetCursorPosition(col, fil + 4);
            Console.Write("Resolver: R");
        }

        //ENTORNO GRAFICO
        static void Entornografico()
        {
            Dibujofondo();
            Dibujotablero();
            Console.CursorSize=100;
            //LETRAS DERECHA
            Letrasderecha();
        }

        //CONTROL LIMITES
        static void Controllimites(ref int valorver,int sup,int inf)
        {
            if (valorver > sup)
                valorver = inf;
            if (valorver < inf)
                valorver = sup;
        }

        //ACTUALIZAR VALOR DEL CURSOR
        static void Actualizarposicion(ref int col, ref int fil, ConsoleKeyInfo eleccion)
        {
            if (eleccion.Key == ConsoleKey.DownArrow || eleccion.Key == ConsoleKey.UpArrow)
            {
                if (eleccion.Key == ConsoleKey.DownArrow)
                    fil += 4;
                if (eleccion.Key == ConsoleKey.UpArrow)
                    fil -= 4;
                Controllimites(ref fil, 34, 2);
            }
            if (eleccion.Key == ConsoleKey.RightArrow || eleccion.Key == ConsoleKey.LeftArrow)
            {
                if (eleccion.Key == ConsoleKey.RightArrow)
                    col += 8;
                if (eleccion.Key == ConsoleKey.LeftArrow)
                    col -= 8;
                Controllimites(ref col, 68, 4);
            }
        }

        //CONTROL PARA QUE NO PUEDA PONER 0 COMO NUMERO
        static int Control(int fil,int col)
        {
            char num;
            int numelegido;
            do
            {
                Console.SetCursorPosition(col, fil);
                num = Console.ReadKey().KeyChar;
                numelegido = (int)num - 48;
            } while (numelegido< 1||numelegido>9);
            return (numelegido);
        }

        //MOVER CURSOR POR LA PANTALLA
        static ConsoleKeyInfo Movercursor(ref int col, ref int fil)
        {
            ConsoleKeyInfo eleccion;
            do
            {
                Console.SetCursorPosition(col, fil);
                eleccion=Console.ReadKey(true);
                Actualizarposicion(ref col,ref fil, eleccion);
            } while (eleccion.Key != ConsoleKey.Enter && eleccion.Key != ConsoleKey.Escape && eleccion.Key != ConsoleKey.R && eleccion.Key != ConsoleKey.A);
            Console.ForegroundColor = ConsoleColor.Blue;
            return (eleccion);
        }
        
        //CAMBIAR EL ORDEN DE LAS COLUMNAS
        //LO DIVIDO ENTRE 3 PARA QUE ME DE EL CUADRANTE DONDE ESTA
        static void Cambiarcolum(Random aleatorio,int[,] sodokubase,int[,]auxiliar)
        {
            int col, col2,fil;
            col = aleatorio.Next(0, 9);
            col2 = (col/3)*3+aleatorio.Next(0, 2);
            for (fil = 0; fil < sodokubase.GetLength(0); fil++)
            {
                auxiliar[fil, 0] = sodokubase[fil, col];
                sodokubase[fil, col] = sodokubase[fil, col2];
                sodokubase[fil, col2] = auxiliar[fil, 0];
            }
        }

        //CAMBIAR EL ORDEN DE LAS FILAS
        //LO DIVIDO ENTRE 3 PARA QUE ME DE EL CUADRANTE DONDE ESTA
        static void Cambiarfil(Random aleatorio, int[,] sodokubase, int[,] auxiliar)
        {
            int fil, fil2, col;
            fil = aleatorio.Next(0, 9);
            fil2 = (fil/3)*3+aleatorio.Next(0, 2);
            for (col = 0; col < sodokubase.GetLength(0); col++)
            {
                auxiliar[0, col] = sodokubase[fil, col];
                sodokubase[fil, col] = sodokubase[fil2, col];
                sodokubase[fil2, col] = auxiliar[0, col];
            }
        }

        //CREAR NUMEROS SHODOKU ALEATORIOS PARTIENDO DE UN SODOKU BASE
        static void Crearnumeros(Random aleatorio)
        {
            int numcambios;
            int[,] auxiliar = new int[9, 9];
            int[,] sodokubase = new int[,] { { 4, 2, 5, 7, 1, 6, 8, 3, 9 }, { 3, 6, 8, 5, 4, 9, 1, 7, 2 }, { 1, 9, 7, 3, 8, 2, 6, 5, 4 }, { 8, 4, 9, 1, 6, 7, 5, 2, 3 }, { 5, 3, 1, 2, 9, 4, 7, 6, 8 }, { 2, 7, 6, 8, 5, 3, 4, 9, 1 }, { 9, 1, 2, 6, 7, 8, 3, 4, 5 }, { 6, 8, 3, 4, 2, 5, 9, 1, 7 }, { 7, 5, 4, 9, 3, 1, 2, 8, 6 } };
            for (numcambios = 0; numcambios < 15; numcambios++)
            {
                //CAMBIAR ORDEN DE LAS COLUMNAS
                Cambiarcolum(aleatorio,sodokubase,auxiliar);

                //CAMBIAR ORDEN DE LAS FILAS
                Cambiarfil(aleatorio, sodokubase, auxiliar);
            }
            shodokuresuelto = sodokubase;
        }

        //COMPROBAR SI EL RESULTADO ESTA BIEN
        static bool Esigual()
        {
            bool mismo;
            mismo=true;
            int fil, col;
            for (fil = 0; fil < shodokuresuelto.GetLength(0); fil++)
            {
                for (col = 0; col < shodokuresuelto.GetLength(0); col++)
                {
                    if (shodokuvalores[fil, col]!=shodokuresuelto[fil, col])
                        mismo = false;
                }
            }
            return(mismo);
        }

        //PARA CONTROLAR QUE NUMEROS INICIALES SALEN
        static bool Controlinicial(int[,] numeroinicial,int fil,int col,int veces)
        {
            int pos;
            bool existe;
            existe = false;
            for (pos = 0; pos < numeroinicial.GetLength(0); pos++)
            {
                if (numeroinicial[pos, 0] == fil && numeroinicial[pos, 1] == col)
                    existe = true;
            }
            if (existe == false)
            {
                numeroinicial[veces, 0] = fil;
                numeroinicial[veces, 1] = col;
            }
            return (existe);
        }

        //MUESTRA EL NUMERO EN PANTALLA
        static void Mostrarnumero(int fil,int col)
        {
            Console.SetCursorPosition(col * 8 + 4, fil * 4 + 2);
            Console.Write("{0}", shodokuresuelto[fil, col]);
        }

        //ELIGE UNA POSICION ALEATORIA DENTRO DE LA MATRIZ
        static int Posicionelegida(Random aleatorio, int[,] numeroinicial)
        {
            int numeroaleatorio;
            numeroaleatorio = aleatorio.Next(0, 9);
            return (numeroaleatorio);
        }

        //NOS CONTROLA QUE LA POSICION A MOSTRAR YA NO HAYA SIDO MOSTRADA ANTES
        static void Controlposicion(ref int fil, ref int col,Random aleatorio, int[,] numeroinicial,int veces)
        {
            bool existe;
            do
            {
                existe = false;
                fil = Posicionelegida(aleatorio, numeroinicial);
                col = Posicionelegida(aleatorio, numeroinicial);
                existe = Controlinicial(numeroinicial, fil, col, veces);
            } while (existe == true);
        }

        //MOSTRAR NUMEROS INICIALES
        static int[,] Mostrariniciales(Random aleatorio, int numeromostrar)
        {
            int fil, col,veces,num;
            //CANTIDAD DE NUMEROS INICIALES A MOSTRAR
            //Le pongo +A Y -1, PORQUE ESE ULTIMO VALOR SE GUARDARA PARA PODER PEDIR AYUDA UNA VEZ
            num = numeromostrar;
            int[,] numeroinicial = new int[num+1, 2];
            fil = 0;
            col = 0;
            Console.ForegroundColor = ConsoleColor.Black;
            for (veces = 0; veces < num-1; veces++)
            {
                Controlposicion(ref  fil, ref col,aleatorio,numeroinicial,veces);
                Mostrarnumero(fil,col);
                //NOS METE EL NUMERO MOSTRADO EN LOS NUMEROS ACERTADOS
                shodokuvalores[fil, col] = shodokuresuelto[fil, col];
            }
            return (numeroinicial);
        }

        //LETRAS SALIR
        static void Letrassalir()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(75, 35);
            Console.Write("¿Estas seguro?");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        //ELECCION DE OPCION SALIR
        static char Eleccionsalir()
        {
            char salir;
            do
            {
                salir = Console.ReadKey(true).KeyChar;
                salir = char.ToLower(salir);
            } while (salir != 's' && salir != 'n');
            return (salir);
        }

        //BORRADO DE LETRAS SALIR
        static void Borradosalir()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(75, 35);
            Console.Write("               ");
            Console.BackgroundColor = ConsoleColor.White;
        }

        //PREGUNTAR SI ESTAS SEGURO DE SALIR
        static char Salirdetodo()
        {
            char salir;
            Letrassalir();
            salir=Eleccionsalir();
            Borradosalir();
            return (salir);
        }

        //MOSTRAR TOTAL MOVIMIENTOS
        static void Mostratotalmovi(ref int totlamovimientos)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(91, 15);
            totlamovimientos++;
            Console.Write("{0}", totlamovimientos);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        //MOSTRAR TODO EL SUDOKU RESUELTO
        static void Mostrartodo()
        {
            int fil,col;
            for(fil=0;fil<shodokuresuelto.GetLength(0);fil++)
            {
                for(col=0;col<shodokuresuelto.GetLength(0);col++)
                {
                    Mostrarnumero(fil,col);
                }
            }

        }

        //ELECCION DE AYUDA
        static void Ayudar(Random aleatorio, ref int vecesayudado, int[,] numerosiniciales)
        {
            Mostraruno(numerosiniciales, aleatorio);
            Console.SetCursorPosition(75, 30);
            Console.BackgroundColor = ConsoleColor.Black;
            vecesayudado++;
            Console.Write("Has sido ayudado: {0}", vecesayudado);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Beep(600, 200);
        }

        //CONTROL LINEA HORIZONTAL NO SE REPITA EL NUMERO
        static void Lineahori(ref  bool repetido,int numelegido,int fil)
        {
            int pos,dosveces;
            dosveces = 0;
            for (pos = 0; pos < shodokuvalores.GetLength(0); pos++)
            {
                if (numelegido == shodokuvalores[fil, pos])
                    dosveces++;
            }
            if (dosveces >1)
                repetido = true;
        }

        //CONTROL LINEA VERTICAL NO SE REPITA EL NUMERO
        static void Lineavertical(ref  bool repetido, int numelegido, int col)
        {
            int pos, dosveces;
            dosveces = 0;
            for (pos = 0; pos < shodokuvalores.GetLength(1); pos++)
            {
                if (numelegido == shodokuvalores[pos, col])
                    dosveces++;
            }
            if (dosveces > 1)
                repetido = true;
        }

        //CONTROL DEL CUADRADO NO SE REPITA NUMERO
        static void Controlcuadrado(ref  bool repetido, int numelegido, int col,int fil)
        {
            int pos1,pos2,repeti;
            repeti = 0;
            for(pos1=(fil/3)*3;pos1<=((fil/3)*3+2);pos1++)
            {
                for (pos2 = (col / 3)*3; pos2 <= ((col / 3)*3 + 2); pos2++)
                {
                    if (numelegido == shodokuvalores[pos1, pos2])
                        repeti++;
                }
            }
            if (repeti > 1)
                repetido = true;
        }

        //MOSTRAR NUMERO EN ROJO POR ESTAR REPETIDO
        static void Mostrarrojo(bool repetido, int col, int fil, int numelegido)
        {
            if (repetido == true)
            {
                Console.SetCursorPosition(col, fil);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0}", numelegido);
            }
        }

        //CONTROL SI EL NUMERO ES INVALIDO -  SOLO NIVEL FACIL
        static void Controlarnumero(int fil, int col, int numelegido)
        {
            bool repetido;
            int fil2, col2;
            repetido = false;
            fil2=(fil - 2) / 4;
            col2= (col - 4) / 8;
            //CONTROL LINEA HORIZONTAL
            Lineahori(ref repetido,numelegido,fil2);
            //CONTROL LINEA VERTICAL
            Lineavertical(ref repetido, numelegido, col2);
            //CONTROL CUADRADO PEQUEÑO
            Controlcuadrado(ref  repetido,  numelegido, col2, fil2);
            //MOSTRAR EL NUMERO EN ROJO si esta repetido
            Mostrarrojo(repetido, col, fil,numelegido);
        }

        //BUCLE MIENTRAS JUEGAS
        //SI GANAS SIN USAR AYUDA, SALDRÁ LA CANCION DE WE ARE THE CHAMPION
        // SI PULSAS SALIR TE SALE UNA CANCION
        static void Buclejugando(int[,] numerosiniciales, Random aleatorio, int numeromostrar)
        {
            int numelegido,col,fil,totlamovimientos,vecesayudado;
            bool esigual;
            char salir;
            ConsoleKeyInfo eleccion;
            salir = 'n';
            col = 4;
            fil = 2;
            totlamovimientos = 0;
            vecesayudado = 0;
            esigual = false;
            //LETRAS DERECHA INFERIOR
            Letrasderechainfe();
            Console.BackgroundColor = ConsoleColor.White;
            do
            {
                eleccion = Movercursor(ref col, ref fil);
                if (eleccion.Key == ConsoleKey.A)
                {
                    Ayudar(aleatorio, ref vecesayudado,numerosiniciales);
                }
                else
                {
                    if (eleccion.Key == ConsoleKey.R)
                    {
                        salir = Salirdetodo();
                        if (salir == 's')
                            Mostrartodo();
                    }
                    else
                    {
                        if (eleccion.Key != ConsoleKey.Escape)
                        {
                            numelegido = Control(fil, col);
                            shodokuvalores[(fil - 2) / 4, (col - 4) / 8] = numelegido;
                            //SI ESTA EN NIVEL FACIL, Y EL NUMERO NO ES VALIDO, LO PONDRA EN ROJO
                            if (numeromostrar == 33)
                                Controlarnumero(fil, col, numelegido);
                            esigual = Esigual();
                            Mostratotalmovi(ref totlamovimientos);
                        }
                        else
                        {
                            Musicasalir();
                            salir = Salirdetodo();
                            msalir.Stop();
                        }
                        
                    }
                }
                
            } while (esigual == false && salir == 'n');
            Console.Beep(1000, 300);
            Console.Beep(1300, 200);
            Console.Beep(1600, 150);
            Console.ReadKey();
            Creditos();
            if (esigual == true && vecesayudado == 0)
                Musicaganar();
        }

        //DECIR UN NUMERO QUE ESTE BIEN DE LA MATRIZ
        static void Mostraruno(int[,] numeroinicial, Random aleatorio)
        {
            int fil, col;
            fil = 0;
            col = 0;
            Controlposicion(ref  fil, ref col, aleatorio, numeroinicial, 0);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Mostrarnumero(fil, col);
            //NOS METE EL NUMERO MOSTRADO EN LOS NUMEROS ACERTADOS
            shodokuvalores[fil, col] = shodokuresuelto[fil, col];
        }

        //CONTROL PARA QUE EL NOMBRE NO TENGA MÁS DE 15 LETRAS O CUANDO PULSE ENTER
        //TAMBIÉN CONTROLA SI QUIERE BORRAR UN CARÁCTER
        static string Controlnombre()
        {
            int lugar;
            string nombre;
            ConsoleKey letra;
            char[] letrasnombre = new char[16];
            lugar = 75;
            Console.SetCursorPosition(75, 8);
            do
            {
                Console.SetCursorPosition(lugar, 8);
                letra = Console.ReadKey().Key;
                if (letra == ConsoleKey.Backspace)
                {
                    if (lugar != 75)
                    {
                        lugar--;
                        Console.SetCursorPosition(lugar, 8);
                        Console.Write(" ");
                    }
                }
                else
                {
                    letrasnombre[lugar-75] = Convert.ToChar(letra);
                    lugar++;
                }
            } while (lugar != 90 && letra != ConsoleKey.Enter);
            nombre = Convert.ToString(letrasnombre);
            return (nombre);
        }

        //NOS PIDE EL NOMBRE PARA EMPEZAR
        static void Pidenombre()
        {
            string nombre;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Green;
            nombre = Controlnombre();
                //Console.SetCursorPosition(75, 8);
                //nombre = Console.ReadLine();
        }

        //ELECCION DIFICULTAD
        static char Eleccion()
        {
            char opc;
            do
            {
                opc = Console.ReadKey(true).KeyChar;
                opc = char.ToLower(opc);
            } while (opc != 'f' && opc != 'n' && opc != 'd');
            return (opc);
        }

        //MOSTRAR POR PANTALLA LA ELECCION DE LA DIFICULTAD y NOS DICE EL NUMERO DE NUMROS A MOSTRAR
        static int Mostrardifi(char opc)
        {
            int numerosmostrar;
            switch (opc)
            {
                case 'f':
                    Console.SetCursorPosition(75, 12);
                    Console.Write("Facil       ");
                    numerosmostrar = 33;
                    break;
                case 'n':
                    Console.SetCursorPosition(75, 12);
                    Console.Write("Normal      ");
                    numerosmostrar = 28;
                    break;
                default:
                    Console.SetCursorPosition(75, 12);
                    Console.Write("Dificil     ");
                    numerosmostrar = 22;
                    break;
            }
            return (numerosmostrar);
        }

        //ELEGIR NIVEL DE DIFICULTAD
        static int Dificultad()
        {
            int nummostrar;
            char opc;
            Console.SetCursorPosition(75, 12);
            Console.Write("F - N - D");
            opc = Eleccion();
            nummostrar=Mostrardifi(opc);
            return (nummostrar);
        }

        //JUGAR
        static void Jugar(Random aleatorio)
        {
            int numeromostrar;
            int[,] numerosiniciales;
            //PARA LA MUSICA AL EMPEZAR A JUGAR
            musicapre.Stop();
            //NOS PIDE EL NOMBRE DEL JUGADOR
            Pidenombre();
            //ELEGIR NIVEL DE DIFICULTAD
            numeromostrar=Dificultad();
            //NOS CREA EL SODOKU RESUELTO
            Crearnumeros(aleatorio);
            //NOS MUESTRA NUMEROS AL COMIENZO
            Console.BackgroundColor = ConsoleColor.White;
            numerosiniciales=Mostrariniciales(aleatorio, numeromostrar);
            //BUCLE MIENTRAS NO ACIERTE O SALGA CON ESCAPE
            Console.BackgroundColor = ConsoleColor.White;
            Buclejugando(numerosiniciales, aleatorio, numeromostrar);
            Console.CursorVisible = false;
            Console.ReadKey();
        }

        //ANIMACION NUMEROS ALEATORIOS
        static void Aleatoriosnumeros(Random aleatorio)
        {
            int col, fil, num;
            num = aleatorio.Next(0, 9);
            col = aleatorio.Next(0, 100);
            fil = aleatorio.Next(0, 37);
            Console.SetCursorPosition(col, fil);
            Console.Write("{0}", num);
        }

        //VELOCIDAD ALEATORIOS Y MOSTRAR  NUMEROS
        static void Velocidad(Random aleatorio,int vecestotal,int velocidad)
        {
            int veces;
            for (veces = 0; veces < vecestotal; veces++)
            {
                Aleatoriosnumeros(aleatorio);
                Thread.Sleep(velocidad);
            }
        }

        //ANIMACION PRESENTACION
        static void Animacion(Random aleatorio)
        {
            Velocidad( aleatorio, 20,500);
            Velocidad(aleatorio, 30, 200);
            Velocidad(aleatorio, 200, 50);   
        }

        //HISTORIA
        static void Historia()
        {
            Musicapresentacion();
            Console.SetCursorPosition(23, 17);
            Console.Write("¿Alguna vez has pensado que la vida era un sueño?");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(25, 17);
            Console.Write("¿Que cada lágrima que has derramado no tenía sentido?");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(20, 14);
            Console.Write("Te daremos las respuestas");
            Thread.Sleep(4000);
            Console.SetCursorPosition(39, 18);
            Console.Write("La verdad comienza con la negación de uno mismo");
            Thread.Sleep(6000);
            Console.Clear();
            Console.SetCursorPosition(35, 17);
            Console.Write("Ahora...");
            Thread.Sleep(2000);
            Console.Write(" escucha");
            Thread.Sleep(5000);
            Console.Clear();
        }

        //ESCRIBE EN PANTALLA SUDOKU LETRA A LETRA
        static void Letraaletra()
        {
            Console.Write("S");
            Thread.Sleep(400);
            Console.Write("U");
            Thread.Sleep(400);
            Console.Write("D");
            Thread.Sleep(400);
            Console.Write("O");
            Thread.Sleep(400);
            Console.Write("K");
            Thread.Sleep(400);
            Console.Write("U");
        }

        //ESCRIBE SUDOKU Y JESUS CUESTA POR PANTALLA
        static void Titulos()
        {
            Console.SetCursorPosition(38, 16);
            Console.ForegroundColor = ConsoleColor.Red;
            Letraaletra();
            Thread.Sleep(400);
            Console.SetCursorPosition(38, 16);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Letraaletra();
            Thread.Sleep(1000);
            Console.SetCursorPosition(48, 18);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("por Jesus Cuesta");
        }

        //PRESENTACION()
        static void Presentacion()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            Historia();     
            Animacion(aleatorio);
            Titulos();
            Console.ReadKey();
        }

        static void Tecla()
        {
            Thread hilo = new Thread(Presentacion);
            Console.Title = "shodoku";
            hilo.Start();
            Console.ReadKey(true);
            hilo.Abort();
            
        }

        static void Main(string[] args)
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            Console.SetWindowSize(100, 37);
            Console.CursorVisible = false;

            // CARGA LA PRESENTACION Y NOS PERMITE CORTARLA
            Tecla();
            //NOS DIBUJA TODO
            Entornografico();
            Console.CursorVisible = true;
            //EMPIEZ EL JUEGO
            Jugar(aleatorio);
        }
    }
}
