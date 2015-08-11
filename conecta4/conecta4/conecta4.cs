using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace conecta4
{
    //GRAFICOS DE LA PANTALLA EN GENERAL
    class Graficos
    {
        //COLOR DEL FONDO DE PANTALLA
        public ConsoleColor FondoPantalla { set; get; }
        ConsoleColor ColorPantallaDatos;

        //CONSTRUCTOR QUE LLAMA LOS MÉTODOS Y DIBUJA LA PANTALLA
        public Graficos(ConsoleColor fondoPantalla)
        {
            Console.SetWindowSize(120, 42);
            Console.CursorVisible = false;
            FondoPantalla = fondoPantalla;
            ColorFondoPantalla();
            BarrasHorizontales();
            BarrasVerticales();
            PantallaDatosColor();
            Letras();
            Console.BackgroundColor = ConsoleColor.Black;

        }

        //LETRAS DE LA PANTALLA
        void Letras()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(94, 4);
            Console.Write("CONECTA 4");
            Console.SetCursorPosition(90, 6);
            Console.Write("JESÚS CUESTA ARZA");
            Console.SetCursorPosition(78, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Jugador 1: ");
            Console.SetCursorPosition(78, 13);
            Console.Write("Jugador 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(78, 20);
            Console.Write("S - Parar música");
            Console.SetCursorPosition(78, 22);
            Console.Write("M - Poner música");
        }

        //BARRAS HORIZONTALES
        public void BarrasHorizontales()
        {
            int tam,fil;
            Console.BackgroundColor = ConsoleColor.White;
            for (fil = 6; fil < 39; fil += 4)
            {
                Console.SetCursorPosition(0, fil);
                for (tam = 0; tam < 75; tam++)
                {
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(0, fil-3);
            for (fil = 0; fil < 3; fil++)
            {
                for (tam = 0; tam < 75; tam++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        //BARRAS VERTICALES
        public void BarrasVerticales()
        {
            int tam, fil,col;
            Console.BackgroundColor = ConsoleColor.White;
            for (col = 0; col < 75; col+=9)
            {
                for (fil = 6; fil < 39; fil ++)
                {
                    Console.SetCursorPosition(col, fil);
                    for (tam = 0; tam < 3; tam++)
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        //PARA ELEGIR COLORES EN ESPAÑOL
        public void ColorFondoPantalla()
        {
            switch (FondoPantalla)
            {
                case ConsoleColor.DarkGreen:
                    Console.BackgroundColor=ConsoleColor.DarkGreen;
                    ColorPantallaDatos = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
                case ConsoleColor.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    ColorPantallaDatos = ConsoleColor.DarkRed;
                    Console.Clear();
                    break;
                case ConsoleColor.Red:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    ColorPantallaDatos = ConsoleColor.DarkYellow;
                    Console.Clear();
                    break;
                case ConsoleColor.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    ColorPantallaDatos = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
                case ConsoleColor.Cyan:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    ColorPantallaDatos = ConsoleColor.Black;
                    Console.Clear();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    ColorPantallaDatos = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
            }
        }

        //PANTALLA Color DE DATOS
        public void PantallaDatosColor()
        {
            int fil, col;
            Console.BackgroundColor = ColorPantallaDatos;
            for (fil = 0; fil < 42; fil++)
            {

                for (col = 0; col < 45; col++)
                {
                    Console.SetCursorPosition(75 + col, fil);
                    Console.Write(" ");
                }
            }
        }

    }

    //MUSICAS DEL JUEGO
    class Musicas
    {
        //MUSICAS DEL JUEGO
        System.Media.SoundPlayer musicapre;
        public bool MusicaON { get; set; }

        public void Musicapresentacion()
        {
            musicapre = new System.Media.SoundPlayer("musicaconecta4/jugarnormal.wav");
            musicapre.PlayLooping();
            MusicaON = true;
        }

        public void PararMusica()
        {
            musicapre.Stop();
            MusicaON = false;
        }

        public void MusicaGanar()
        {
            musicapre = new System.Media.SoundPlayer("musicaconecta4/ganar.wav");
            musicapre.PlayLooping();
        }
    }

    //POSICIONES DE LOS JUGADORES EN EL TABLERO
    class Tablero
    {
        public Jugadas [] jugadores=new Jugadas[2];
        string[,] Posiciones = new string[8, 8];
        public Musicas music = new Musicas();

        public Tablero()
        {
            jugadores[0] = new Jugadas(ConsoleColor.Red,1000,0);
            jugadores[1] = new Jugadas(ConsoleColor.Gray,500,3);
            music.Musicapresentacion();
        }

        // PASAMOS LA COLUMNA DONDE QUEREMOS MOVER, Y ESTE NOS LO PONE ENCIMA DE LA PIEZA QUE HAYA
        //SI NO ENCUENTRA NADA EN LA PRIMERA FILA, LA RELLENA, SINO PASA A LA SIGUIENTE
        public bool Mover(int jugador, int dondemueve)
        {
            int fil;
            //DEVUELVE TRUE O FALSE PARA SABER SI HA MOVIDO O NO, POR SI NO CABEN PIEZAS
            bool mover = false;
            for (fil = 0; fil < Posiciones.GetLength(0) && mover == false; fil++)
            {
                if (Posiciones[fil, dondemueve] == null)
                {
                    Posiciones[fil, dondemueve] = Convert.ToString(jugadores[jugador].Colorjugador);
                    PintarMovimiento(dondemueve, fil, jugadores[jugador].Colorjugador);
                    mover = true;
                }
            }
            return mover;
        }

        //PINTAMOS EN LA PANTALLA EL COLOR ELEGIDO Y EN LA POSICION INDICADA
        void PintarMovimiento(int x, int y, ConsoleColor colorjugador)
        {
            int fil;
            Console.BackgroundColor = colorjugador;
            for (fil = 0; fil < 3; fil++)
            {
                Console.SetCursorPosition((x * 9) + 3, (7 - y) * 4 + 7 + fil);
                Console.Write("      ");
            }
        }

        //CONTROLAR SI GANA POR HORIZONTALES, VERTICALES O DIAGONALES
        bool ControlarLinea(int x, int y, int aumver, int aumhor, string color,bool Yahaganado)
        {
            bool ganar = false;
            int cont = 0;
            int hor, ver;
            if (Yahaganado == true)
                PintarMovimiento(x-aumhor , y-aumver , ConsoleColor.Black);
            for (ver = 0, hor = 0;y+ver>=0&&hor+x>=0&& hor < Posiciones.GetLength(0) - x && ver < Posiciones.GetLength(0) - y && cont < 3; ver += aumver, hor += aumhor)
            {
                if (Posiciones[y + ver, x + hor] == color)
                {
                    cont++;
                    if (Yahaganado == true)
                        PintarMovimiento(x + hor, y+ver, ConsoleColor.Black);
                }

                else
                {
                    //ESTO LO HE PUESTO PARA QUE TERMINE EL BUCLE, ASI ME EVITO CREAR OTRA VARIABLE
                    hor = 10;
                    ver = 10;
                    cont = 0;
                }              
            }          
            if (cont > 2) ganar = true;
            return ganar;      
        }

        //SEÑALAR LAS CASILLAS DONDE HA CONSEGUIO 4 EN LINEA
        void SeñalarCuatroLinea(int x,int y)
        {
            PintarMovimiento(x, y, ConsoleColor.Black);
        }

        //CONTROLAR SI ALGUIEN HA GANADO
        public bool AlguienGana()
        {
            bool terminar = false;
            bool ganar = false; 
            int x,y;
            for (y = 0; y < Posiciones.GetLength(0)&&ganar==false; y++)
            {
                for (x = 0; x < Posiciones.GetLength(0)&&ganar==false; x++)
                {
                    if (Posiciones[y, x] != null)
                    {
                        //CONTROLA LAS HORIZONTALES
                        ganar = ControlarLinea(x + 1, y, 0, 1, Posiciones[y, x],false);
                        if (ganar == true)
                            ControlarLinea(x + 1, y, 0, 1, Posiciones[y, x], true);                        
                        if(ganar==false)
                        {
                            //CONTROLA LAS VERTICALES
                            ganar = ControlarLinea(x, y + 1, 1, 0, Posiciones[y, x], false);
                            if (ganar == true)
                                ganar = ControlarLinea(x, y + 1, 1, 0, Posiciones[y, x], true);
                        }
                        if (ganar == false)
                        {
                            //CONTROLA LAS DIAGONALES DERECHA
                            ganar = ControlarLinea(x + 1, y + 1, 1, 1, Posiciones[y, x], false);
                            if (ganar == true)
                                ganar = ControlarLinea(x + 1, y + 1, 1, 1, Posiciones[y, x], true);
                        }
                        //CONTROLA LAS DIAGONALES IZQUIERDA
                        if (ganar == false)
                        {
                            ganar = ControlarLinea(x + 1, y - 1, -1, +1, Posiciones[y, x], false);
                            if (ganar == true)
                                ControlarLinea(x + 1, y - 1, -1, +1, Posiciones[y, x], true);
                        }
                    }
                }
            }
            if (ganar == true) terminar = true;
            return terminar;
        }

        //INDIZADOR
        public string this[int indice, int indice2]
        {
            get
            {
                if (indice < Posiciones.Length && indice >= 0) return Posiciones[indice, indice2];
                else throw new Exception("Indice fuera de rango");
            }
            set
            {
                if (indice < Posiciones.Length && indice >= 0) Posiciones[indice, indice2] = value;
                else throw new Exception("Indice fuera de rango");
            }
        }
    }

    //DATOS Y COLORES DE LOS JUGADORES
    class Jugadas
    {
        public ConsoleColor Colorjugador { set; get; }
        public int Pitido { get; set; }
        string Nombrejugador;
        public Jugadas(ConsoleColor colorjugador,int pitido,int lineavertical)
        {
            Colorjugador = colorjugador;
            Pitido = pitido;
            Console.SetCursorPosition(90, 10+lineavertical);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Nombrejugador = Controlnombre(lineavertical);
        }

        //CONTROL PARA QUE EL NOMBRE NO TENGA MÁS DE 15 LETRAS O CUANDO PULSE ENTER
        //TAMBIÉN CONTROLA SI QUIERE BORRAR UN CARÁCTER
        string Controlnombre(int lineavertical)
        {
            int lugar;
            string nombre;
            ConsoleKey letra;
            char[] letrasnombre = new char[16];
            lugar = 90;
            Console.SetCursorPosition(90, 10+lineavertical);
            do
            {
                Console.SetCursorPosition(lugar, 10 + lineavertical);
                letra = Console.ReadKey().Key;
                if (letra == ConsoleKey.Backspace)
                {
                    if (lugar != 90)
                    {
                        lugar--;
                        Console.SetCursorPosition(lugar, 10 + lineavertical);
                        Console.Write(" ");
                    }
                }
                else
                {
                    letrasnombre[lugar - 90] = Convert.ToChar(letra);
                    lugar++;
                }
            } while (lugar != 105 && letra != ConsoleKey.Enter);
            nombre = Convert.ToString(letrasnombre);
            return (nombre);
        }
    }

    //PROGRAMA PRINCIPAL
    class conecta4
    {              
        //MOSTRAR DONDE ESTA LA FICHA PARA MOVER
        static void PintarMovimiento(Tablero partida,int jugador,int x, Graficos g)
        {
            int fil;
            //LIMPIA LA ANTERIOR POSICION
            Console.BackgroundColor=g.FondoPantalla;
            for (fil = 0; fil < 3; fil++)
            {
                Console.SetCursorPosition(0, 0 * 4 + 2 + fil);
                Console.Write("\t\t\t\t\t\t\t\t\t   ");
            }

            //NOS LA PINTA EN PANTALLA
            Console.BackgroundColor =partida.jugadores[jugador].Colorjugador;
            for (fil = 0; fil < 3; fil++)
            {
                Console.SetCursorPosition((x * 9) + 3, 0 * 4 + 2 + fil);
                Console.Write("      ");
            }
        }

        // ELEGIR DONDE SE MUEVE
        static int DondeMover(Tablero partida, Graficos g,int jugadormueve)
        {
            int pos=3;
            ConsoleKey tecla;
            do
            {
                PintarMovimiento(partida, jugadormueve, pos, g);
                tecla = Console.ReadKey(true).Key;
                if (tecla == ConsoleKey.RightArrow)
                    pos++;
                if (tecla == ConsoleKey.LeftArrow)
                    pos--;
                if (pos<0)
                    pos=0;
                if (pos >7)
                    pos = 7;
                if (tecla == ConsoleKey.S)
                    partida.music.PararMusica();
                if (tecla == ConsoleKey.M&&partida.music.MusicaON==false)
                    partida.music.Musicapresentacion();
            } while (tecla != ConsoleKey.Enter);
            return pos;
        }

        //PONER FINAL
        static void Final(Tablero partida,int jugador)
        {
            Console.BackgroundColor = partida.jugadores[jugador].Colorjugador;
            Console.SetCursorPosition(25, 20);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\t\t ENHORABUENA HAS GANADO\t\t\t");
            Musicas music = new Musicas();
            music.MusicaGanar();
        }

        //BUCLE DE PARTIDA NORMAL
        static void PartidaJugar(Graficos grafic, Tablero partida)
        {
            bool terminar=false;
            int jugadormueve,pos;
            for (jugadormueve = 0; jugadormueve < 2&&terminar!=true; jugadormueve++)
            {
                do
                {
                    pos = DondeMover(partida, grafic, jugadormueve);
                    Console.Beep(partida.jugadores[jugadormueve].Pitido, 200);
                } while (partida.Mover(jugadormueve, pos) == false);
                if (jugadormueve == 1)
                    jugadormueve = -1;
                terminar=partida.AlguienGana();
            }
            //PARA QUE NOS MUESTRE EL COLOR DEL JUGADOR GANADOR
            if (jugadormueve == 1)
                jugadormueve = 0;
            else
                jugadormueve = 1;
            Final(partida,jugadormueve);
        }

        static void Main(string[] args)
        {
            Graficos grafic=new Graficos(ConsoleColor.DarkGreen);
            Tablero partida = new Tablero();
            Console.SetCursorPosition(0, 0);
            PartidaJugar(grafic, partida);

            Console.ReadKey();
        }
    }
}
