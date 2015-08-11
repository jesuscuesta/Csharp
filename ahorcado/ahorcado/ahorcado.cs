using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace ahorcado
{
    class ahorcado
    {
        /*------------------------------------------
         * PARA EL SONIDO DE FONDO
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        delegate string DType(string input);

        /*------------------------------------------
         * VARIABLES GLOBALES
        * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static char[][] cine = { new char[] { 'b', 'l', 'a', 'd', 'e' }, new char[] { 's', 'u', 'p', 'e', 'r', 'm', 'a', 'n' }, new char[] { 'p', 'i', 'n', 'o', 'c', 'h', 'o' }, new char[] { 'd', 'r', 'a', 'c', 'u', 'l', 'a' }, new char[] { 's', 't', 'a', 'r', 't', 'r', 'e', 'c', 'k' }, new char[] { 's', 't', 'a', 'r', ' ', 'g', 'a', 't', 'e' } };
        static char[][] musica = { new char[] { 'm', 'e', 't', 'a', 'l', 'l', 'i', 'c', 'a' }, new char[] { 'b', 'i', 's', 'b', 'a', 'l' }, new char[] { 'w', 'a', 'r', 'c', 'r', 'y' }, new char[] { 'm', 'i', 'c', 'h', 'a', 'e', 'l', ' ', 'j', 'a', 'c', 'k', 's', 'o', 'n' }, new char[] { 'l', 'u', 'i', 's', ' ', 'f', 'o', 'n', 's', 'i' }, new char[] { 'r', 'i', 'c', 'a', 'r', 'd', 'o', ' ', 'a', 'r','j','o','n','a' } };
        static char[][] deportes = { new char[] { 'f', 'u', 't', 'b', 'o', 'l' }, new char[] { 't', 'e', 'n', 'i', 's' }, new char[] { 'b', 'a', 'l', 'o', 'n', 'm', 'a', 'n', 'o' }, new char[] { 'h', 'o', 'c', 'k', 'e', 'y' }, new char[] { 'b', 'o', 'x', 'e','o' } };
        static char[][] profesores = { new char[] { 'x', 'u', 's', 'a' }, new char[] { 'n', 'a', 'x', 'o' }, new char[] { 'e', 'd', 'u' }, new char[] { 's', 'i', 'm', 'o', 'n' }, new char[] { 'j', 'o', 's', 'e', ' ', 'a', 'n', 't', 'o', 'n', 'i', 'o' }, new char[] { 'e', 'i', 'n', 's', 't', 'e', 'i', 'n'} };
       
        // NOMBRE DEL JUGADOR QUE ESTA JUGANDO
        static string jugador1grabar;
        // NUMERO DE PRESOS SALVADOS POR ESE JUGADOR
        static int totalsalvados;
        // TABLA DE PUNTUACIONES
        static string[,] clasificacion = new string[10, 2] { { "Jesus Cuesta", "30" }, { "Messi", "23" }, { "Carlos Camello", "25" }, { "Sacha", "1" }, { "Adry el Mago", "22" }, { "Estevan", "9" }, { "Manu", "2" }, { "El amigo", "14" }, { "Gel antigripe", "18" }, { "Swich", "2" } };
        //PARA SI PUEDE CONTINUAR JUGANDO O NO HA JUGADO NUNCA
        static bool hajugado = false;
        //DONDE ESTA LA MUSICA DEL JUEGO
        static string ubicacion;
        //MUSICAS DEL JUEGO
        static System.Media.SoundPlayer musicapre, musicamenu, musicajugar, musicajugar1vs1, musicaganador, musicaperder,musicaspider,musicasuper,musicarocky;



        /*------------------------------------------
         * CREDITOS SI GANA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Creditosganador()
        {
            Console.SetWindowSize(72, 30);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(@" .-¨-._,-'_`-._,-'_`-._,-'_`-._,-'_`-,_,-'_`-,_,-'_`-,_,-'_`-,_,-'_`-,.
(  ,-'_,-<.>-'_,-<.>-'_,-<.>-'_,-<.>-'_,-<.>-'_,-<.>-'_,-<.>-'_,-~-} ;.
 \ \.'_>-._`-<_>-._`-<_>-._`-<_>-._`-<_>-._`-<_>-._`-<_>-._`-._~--. \ .
 /\ \/ ,-' `-._,-' `-._,-' `-._,-' `-._,-' `-._,-' `-._,-' `-._`./ \ \ .
( (`/ /                                                        `/ /.) ) .
 \ \ / \                                                       / / \ / .
  \ \') )                                                     ( (,\ \ .
 / \ / /                                                       \ / \ \ .
 \(`/ /                                                         / /.) ) .
 \ \ / \                                                       / / \ / .
  \ \') )                                                     ( (,\ \ .
 / \ / /                                                       \ / \ \ .
( (`/ /                                                         / /.) ) .
 \ \ / \                                                       / / \ / .
  \ \') )                                                     ( (,\ \ .
 / \ / /                                                       \ / \ \ .
( ( / /                                                         / /.) ) .
 \ \ / \                                                       / / \ /.
  \ \') )                                                     ( (,\ \ .
 / \ / /                                                       \ / \ \ .
( ( / /                                                         / /.) ) .
 \ \ / \                                                       / / \ / .
  \ \') )                                                     ( (,\ \ .
 / \ / /                                                       \ / \ \ .
( ( / /                                                         / /.) ) .
 \ \ / \       _       _       _       _       _       _       / / \ /.
  \ `.\ `-._,-'_`-._,-'_`-._,-'_`-._,-'_`-._,-'_`-._,-'_`-._,-'_/,\ \ .
 ( `. `,~-._`-<,>-._`-<,>-._`-<,>-._`-<,>-._`-<,>-._`-<,>-._`-=,' ,\ \ .
  `. `'_,-<_>-'_,-<_>-'_,-<_>-'_,-<_>-'_,-<_>-'_,-<_>-'_,-<_>-'_,¨-' ; .
    `-' `-._,-' `-._,-' `-._,-' `-._,-' `-._,-' `-._,-' `-._,-' `-.-' .");
            Console.SetCursorPosition(29, 12);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Diseñado por");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(27, 14);
            Console.Write("Jesus Cuesta Arza");
            Console.SetCursorPosition(27, 18);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("GRACIAS POR JUGAR");
        }

        /*------------------------------------------
         * DIBUJO monigotes de BORDE
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dibujodentromonigotes()
        {
            Console.WriteLine(@".......................................................................................................................");
            Console.WriteLine(@".   o   \ o /  _ o        __|    \ /     |__         o _    \ o /    _ o        __|    \ /     |__         o _  \ o / .");
            Console.WriteLine(@".  /|\    |     /\   __\o   \o    |    o/     o/__   /\       |       /\   __\o   \o    |    o/     o/__   /\     |   .");
            Console.WriteLine(@".  / \   / \   | \  /) |    ( \  /o\  / )    |   (\  / |     / \     | \  /) |    ( \  /o\  / )    |   (\  / |   / \  .");
            Console.WriteLine(@".       ......................................................................................................        .");
            Console.WriteLine(@". \ o / .                                                                                                     . \ o / .");
            Console.WriteLine(@".   |   .                                                                                                     .   |   .");
            Console.WriteLine(@".  / \  .                                                                                                     .  / \  .");
            Console.WriteLine(@".  _ o  .                                                                                                     .  _ o  .");
            Console.WriteLine(@".   /\  .                                                                                                     .   /\  .");
            Console.WriteLine(@".  | \  .                                                                                                     .  | \  .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".  __\o .                                                                                                     .  __\o .");
            Console.WriteLine(@". /) |  .                                                                                                     . /) |  .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@". __|   .                                                                                                     . __|   .");
            Console.WriteLine(@".   \o  .                                                                                                     .    \o .");
            Console.WriteLine(@".   ( \ .                                                                                                     .   ( \ .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".  \ /  .                                                                                                     .  \ /  .");
            Console.WriteLine(@".   |   .                                                                                                     .   |   .");
            Console.WriteLine(@".  /o\  .                                                                                                     .  /o\  .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".   |__ .                                                                                                     .   |__ .");
            Console.WriteLine(@". o/    .                                                                                                     . o/    .");
            Console.WriteLine(@"./ )    .                                                                                                     ./ )    .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@". o/__  .                                                                                                     . o/__  .");
            Console.WriteLine(@".  | (\ .                                                                                                     . |  (\ .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@".  o _  .                                                                                                     .  o _  .");
            Console.WriteLine(@".  /\   .                                                                                                     .  /\   .");
            Console.WriteLine(@".  / |  .                                                                                                     .  / |  .");
            Console.WriteLine(@".       .                                                                                                     .       .");
            Console.WriteLine(@". \ o / .                                                                                                     . \ o / .");
            Console.WriteLine(@".   |   .                                                                                                     .   |   .");
            Console.WriteLine(@".  / \  .                                                                                                     .  / \  .");
            Console.WriteLine(@".       ......................................................................................................        .");
            Console.WriteLine(@".   o   \ o /  _ o        __|    \ /     |__         o _  \ o /         __|      \ /     |__         o _  \ o /   o   .");
            Console.WriteLine(@".  /|\    |     /\   __\o   \o    |    o/     o/__   /\     |      __\o   \o      |    o/     o/__   /\     |    /|\  .");
            Console.WriteLine(@".  / \   / \   | \  /) |    ( \  /o\  / )    |   (\  / |   / \    /) |    ( \    /o\  / )    |   (\  / |   / \   / \  .");
            Console.WriteLine(@".......................................................................................................................");
        }


        /*------------------------------------------
         * DIBUJO TOTAL DE MONIGOTES
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dibujototalmonigotes()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Dibujodentromonigotes();
        }


        /*------------------------------------------
         * ORDENAR CLASIFICACION DE MAYOR A MENOR
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void OrdenarClasificacion()
        {
            int i, j, aux;
            string auxiliar;
            for (i = 1; i<clasificacion.GetLength(0); i++)
            {
                if (clasificacion[i, 1] != "")
                {
                    aux = Convert.ToInt16(clasificacion[i, 1]);
                    auxiliar = (clasificacion[i, 0]);
                    j = i - 1;
                    for (; j != -1 && aux > Convert.ToInt16(clasificacion[j, 1]); j--)
                    {
                        clasificacion[j + 1, 0] = clasificacion[j, 0];
                        clasificacion[j + 1, 1] = clasificacion[j, 1];
                    }
                    clasificacion[j + 1, 1] = Convert.ToString(aux);
                    clasificacion[j + 1, 0] = auxiliar;

                }
            }
        }

        /*------------------------------------------
         * MUSICA SPIDERMAN
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicaspider()
        {
            musicaspider = new System.Media.SoundPlayer(ubicacion + "spider.wav");
            musicaspider.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA SUPERMAN
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicasuper()
        {
            musicasuper = new System.Media.SoundPlayer(ubicacion + "superman.wav");
            musicasuper.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA ROCKY
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicarocky()
        {
            musicarocky = new System.Media.SoundPlayer(ubicacion + "rock2.wav");
            musicarocky.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA FINAL
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicaganador()
        {
            musicaganador = new System.Media.SoundPlayer(ubicacion + "ganar_1.wav");
            musicaganador.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA MENU
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicamenu()
        {
            musicamenu = new System.Media.SoundPlayer(ubicacion + "menu.wav");
            musicamenu.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA QUE SALE CUANDO JUEGAS, ALEATORIA ENTRE 6 CANCIONES
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicajugar(Random elegir)
        {
            int musica;
            musica = elegir.Next(0, 6);
            switch (musica)
            {
                case 1:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarnormal2.wav");
                    break;
                case 2:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarnormal.wav");
                    break;
                case 3:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarbond.wav");
                    break;
                case 4:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarkarate.wav");
                    break;
                case 5:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarryu.wav");
                    break;
                default:
                    musicajugar = new System.Media.SoundPlayer(ubicacion + "jugarnormal3.wav");
                    break;
            }
            musicajugar.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA QUE SALE CUANDO JUEGAS 1VS1, ALEATORIA ENTRE 3 CANCIONES
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musica1vs1(Random elegir)
        {
            int musica;
            musica = elegir.Next(1, 4);
            switch (musica)
            {
                case 1:
                    musicajugar1vs1 = new System.Media.SoundPlayer(ubicacion + "1vs1wars.wav");
                    break;
                case 2:
                    musicajugar1vs1 = new System.Media.SoundPlayer(ubicacion + "1vs1exc.wav");
                    break;
                default:
                    musicajugar1vs1 = new System.Media.SoundPlayer(ubicacion + "1vs1ev.wav");
                    break;
            }
            musicajugar1vs1.PlayLooping();
        }


        /*------------------------------------------
         * MUSICA PRESENTACION
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicapresentacion()
        {
            musicapre = new System.Media.SoundPlayer(ubicacion + "pre.wav");
            musicapre.Play();
        }


        /*------------------------------------------
         * MUSICA SI PIERDES
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Musicafinal()
        {
            musicaperder = new System.Media.SoundPlayer(ubicacion + "ENDS.wav");
            musicaperder.Play();
        }


        /*------------------------------------------
         * MUESTRA LAS LETRAS YA SELECCIONADAS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Mostrarletras(char letra, char[]abecedario)
        {
            int pos;
            int colum;
            colum = 3;
            Console.ForegroundColor = ConsoleColor.Red;
            for (pos = 0; pos < abecedario.Length; pos++)
            {
                if (pos < 15)
                {
                    if (letra == abecedario[pos])
                    {
                        Console.SetCursorPosition(7 + colum * pos, 23);
                        Console.Write("{0}", letra);
                    }
                }
                else
                {
                    if (letra == abecedario[pos])
                    {
                        Console.SetCursorPosition(7 + colum * (pos-15), 25);
                        Console.Write("{0}", letra);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        /*------------------------------------------
         * MOSTRAR PALABRA COMPLETA SI LA HAS ACERTADO
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Mostrartodo(char[]pelegida,char[]pacertadas)
        {
            int pos;
            Console.ForegroundColor = ConsoleColor.White;
            for (pos = 0; pos < pelegida.Length; pos++)
            {
                Console.SetCursorPosition(7 + pos * 2, 20);
                if (pelegida[pos] == ' ')
                    Console.Write(" ");
                else
                {
                    if (pelegida[pos] == pacertadas[pos])
                    {
                        Console.SetCursorPosition(7 + pos * 2, 20);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0}", pelegida[pos]);
                    }
                }
            }
        }


        /*------------------------------------------
         * GRAFICOS MENU TEMATICA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Graficosmenutematica()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (pos = 10; pos < 24; pos++)
            {
                Console.SetCursorPosition(10, pos);
                Console.Write("                     ");
            }
        }


        /*------------------------------------------
         * LETRAS DE LA SECCION TEMATICA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static int Letrastematica()
        {
            int valor;
            valor = 1;
            ConsoleKeyInfo sombreado;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(13, 29);
                Console.WriteLine(" - TEMATICA -");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Cambiarcolor(valor, 1);
                Console.SetCursorPosition(13, 32);
                Console.WriteLine("     Cine     ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(13, 34);
                Cambiarcolor(valor, 2);
                Console.WriteLine("    Musica    ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(13, 36);
                Cambiarcolor(valor, 3);
                Console.WriteLine("   Deportes   ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(13, 38);
                Cambiarcolor(valor, 4);
                Console.WriteLine("   Sorpresa   ");
                Console.BackgroundColor = ConsoleColor.Black;
                sombreado = Console.ReadKey();
                Actualizarvalor(ref valor, sombreado, 4, 1);
            } while (sombreado.Key != ConsoleKey.Enter);
            return (valor);
        }


        /*------------------------------------------
         * DIBUJO DE CALAVERA CON ESPADA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Espadacalavera()
        {
            int col, fil;
            col = 52;
            fil = 23;
            Console.SetCursorPosition(col,fil);
            Console.Write(@"                      ______");
            Console.SetCursorPosition(col, fil+1);
            Console.Write(@"                   .-¨      ¨-.");
            Console.SetCursorPosition(col, fil+2);
            Console.Write(@"                  /            \");
            Console.SetCursorPosition(col, fil+3);
            Console.Write(@"                 |              |");
            Console.SetCursorPosition(col, fil+4);
            Console.Write(@"                 |,  .-.  .-.  ,|");
            Console.SetCursorPosition(col, fil+5);
            Console.Write(@"                 | )(__/  \__)( |");
            Console.SetCursorPosition(col, fil+6);
            Console.Write(@"                 |/     /\     \|");
            Console.SetCursorPosition(col, fil+7);
            Console.Write(@"       (@_       (_     ^^     _)");
            Console.SetCursorPosition(col, fil+8);
            Console.Write(@"  _     ) \_______\__|IIIIII|__/__________________________");
            Console.SetCursorPosition(col, fil+9);
            Console.Write(@" (_)@8@8{}<________|-\IIIIII/-|___________________________>");
            Console.SetCursorPosition(col, fil+10);
            Console.Write(@"        )_/        \          /");
            Console.SetCursorPosition(col, fil+11);
            Console.Write(@"       (@           `--------` ");

        }


        /*------------------------------------------
         * MENU TEMATICA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static int Menutematica()
        {
            int elegirtematica;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Graficosmenu();
            Console.ForegroundColor = ConsoleColor.White;
            Espadacalavera();
            elegirtematica=Letrastematica();
            return (elegirtematica);
        }


        /*------------------------------------------
         * ELIGE LA PALABAR ALEATORIA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static char[] Elegirpalabra(Random palabra,char[][] tematica)
        {
            int eleccion,pos;
            char[] pelegida;
            eleccion=palabra.Next(0, 5);
            pelegida = new char[tematica[eleccion].Length];
            for(pos=0;pos<tematica[eleccion].Length;pos++)
            {
                pelegida[pos] = tematica[eleccion][pos];
            }
            return (pelegida);
        }


        /*------------------------------------------
         * SELECCIONAMOS TEMATICA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static char[] Selectematica(Random palabra,int elec)
        {
            char[] pelegida;
            switch (elec)
            {
                case 1:
                    //ELEGIR LA PALABRA DE LA TEMÁTICA
                    pelegida = Elegirpalabra(palabra, cine);
                    break;
                case 2:
                    //ELEGIR LA PALABRA DE LA TEMÁTICA
                    pelegida = Elegirpalabra(palabra, musica);
                    break;
                case 3:
                    //ELEGIR LA PALABRA DE LA TEMÁTICA
                    pelegida = Elegirpalabra(palabra, deportes);
                    break;
                case 4:
                    //ELEGIR LA PALABRA DE LA TEMÁTICA
                    pelegida = Elegirpalabra(palabra, profesores);
                    break;
                default:
                    pelegida = Elegirpalabra(palabra, deportes);
                    break;
            }
            return (pelegida);
        }


        /*------------------------------------------
         * PARA ELEGIR TEMATICA CON LOS METODOS ENLAZADOS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Elegirtematica(Random palabra,ref int elec)
        {
            elec=Menutematica();
        }


        /*------------------------------------------
         * MUESTRA POR PANTALLA LAS _ Y LAS LETRAS ACERTADAS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Mostrarguiones(char[] pelegida,char[] pacertadas)
        {
            int pos;
            Console.ForegroundColor = ConsoleColor.White;
            for (pos = 0; pos < pelegida.Length; pos++)
            {
                Console.SetCursorPosition(7 + pos * 2,20);
                if (pelegida[pos] == ' ')
                    Console.Write(" ");
                else
                {
                    if (pelegida[pos] == pacertadas[pos])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("_");
                    }
                    else
                    {
                        Console.SetCursorPosition(7 + pos * 2, 20);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0}", pelegida[pos]);
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        /*------------------------------------------
         * PARA QUE UN JUGADOR NO PUEDA REPETIR LAS LETRAS PUESTAS NI PONER SIGNOS RAROS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static bool Norepetir(ref char[] controlletras,char letra)
        {
            int pos;
            bool repetida;
            repetida=true;
            for (pos = 0; pos < controlletras.Length; pos++)
            {
                if (letra == controlletras[pos])
                {
                    controlletras[pos] = '9';
                    repetida = false;
                }

            }
            return(repetida);
        }


        /*------------------------------------------
         * EL JUGADOR SELECCIONA UNA LETRA
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static char Seleccionletra(ref char[] controlletras)
        {
            char letra;
            bool repetida;
            do
            {
                Console.SetCursorPosition(6, 13);
                Console.Write("- Qué Letra deseas elegir:       ");
                Console.SetCursorPosition(34, 13);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.CursorVisible = true;
                letra = Console.ReadKey().KeyChar;
                Console.CursorVisible = false;
                letra = char.ToLower(letra);
                repetida = Norepetir(ref controlletras, letra);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Beep(800, 200);
                if (repetida == true)
                {
                    Console.SetCursorPosition(6, 35);
                    Console.Write(" Letra ya dicha");
                    Console.Beep(300, 200);
                    Thread.Sleep(600);
                    Console.SetCursorPosition(6, 35);
                    Console.Write("                     ");
                }
                    Thread.Sleep(200);
            } while (repetida == true);
            return (letra);
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 1
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib1()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.Black;
            for (pos=19; pos < 37; pos++)
            {
                Console.SetCursorPosition(62, pos);
                Console.Write("                                ");
            }
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 2
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib2()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 36; pos > 22; pos--)
            {
                Console.SetCursorPosition(85, pos);
                Console.Write("    ");
                Thread.Sleep(300);
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }


        /*------------------------------------------
         * DIBUJO AHORCADO 3
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib3()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 85; pos > 70; pos--)
            {
                Console.SetCursorPosition(pos, 23);
                Console.Write(" ");
                Thread.Sleep(300);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 4
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib4()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(71, 24);
            Console.Write("|");
            Thread.Sleep(300);
            Console.SetCursorPosition(71, 25);
            Console.Write("|");
            Thread.Sleep(300);
            Console.SetCursorPosition(71, 26);
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Black;
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 5
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib5()
        {
            int cara;
            cara = 1;
            char cabeza;
            cabeza = Convert.ToChar(cara);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(71, 27);
            Console.Write("{0}",cabeza);
            Console.ForegroundColor = ConsoleColor.Red;
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 6
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib6()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(71, 28);
            Console.Write("|");
            Thread.Sleep(300);
            Console.SetCursorPosition(71, 29);
            Console.Write("|");
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 7
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib7()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(70, 28);
            Console.Write("/");
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 8
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib8()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(72, 28);
            Console.Write(@"\");
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 9
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib9()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(72, 30);
            Console.Write(@"\");
        }


        /*------------------------------------------
         * DIBUJO AHORCADO 10
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dib10()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(70, 30);
            Console.Write("/");
        }


        /*------------------------------------------
         * NOS DIBUJA TANTOS PASOS DE AHORCADO SEGUN EL NIVEL DE DIFICULTAD ELEGIDO
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dibahorcado(int num)
        {
            int pos;
            for (pos = 0; pos <= num; pos++)
            {
                if (pos == 1)
                    Dib1();
                if (pos == 2)
                    Dib2();
                if (pos == 3)
                    Dib3();
                if (pos == 4)
                    Dib4();
                if (pos == 5)
                    Dib5();
                if (pos == 6)
                    Dib6();
                if (pos == 7)
                    Dib7();
                if (pos == 8)
                    Dib8();
            }
        }


        /*------------------------------------------
         * NOS REMITE A LOS METODOS DE DIBUJAR EL AHORCADO SEGUN LOS FALLOS QUE TENGAMOS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dibujoahorcado(int num)
        {
            if(num==1)
                Dib1();
            if(num==2)
                Dib2();
            if(num==3)
                Dib3();
            if(num==4)
                Dib4();
            if (num == 5)
                Dib5();
            if (num == 6)
                Dib6();
            if (num == 7)
                Dib7();
            if (num == 8)
                Dib8();
            if (num == 9)
                Dib9();
            if (num == 10)
                Dib10();
        }


        /*------------------------------------------
         * Comparar con las letras de la array
         * si está la iguala a 0 y la muestra por pantalla, sino cont++
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static int Comparar(char[] pacertadas, char letra, int dif)
        {
            int pos;
            bool acierto;
            acierto = false;
            for (pos = 0; pos < pacertadas.Length; pos++)
            {
                if (pacertadas[pos] == letra)
                {
                    pacertadas[pos] ='5';
                    acierto = true;
                }
            }
            if (acierto == false)
                dif--;
            return (dif);
        }

        /*------------------------------------------
         * CREA UNA ARRAY DE CONTROL PARA LETRAS ACERTADAS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Control(char[] pelegida,char[] pacertadas)
        {
            int pos;
            for (pos = 0; pos < pelegida.Length; pos++)
            {
                pacertadas[pos] = pelegida[pos];
                if (pacertadas[pos] == ' ')
                    pacertadas[pos] = '5';
            }
        }

        /*------------------------------------------
         * COMPRUEBA SI SE HAN ACERTADO TODAS LAS LETRAS
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static bool Comprobarletras(char []pacertadas)
        {
            bool quedanletras;
            int pos;
            quedanletras = false;
            for (pos = 0; pos < pacertadas.Length; pos++)
            {
                if (pacertadas[pos] != '5')
                    quedanletras = true;
            }
            return (quedanletras);
        }

        /*------------------------------------------
         * CUANDO GANAS CAMBIO DE DIBUJO DEL PRESO
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Ganar()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (pos = 3; pos < 40; pos++)
            {
                Console.SetCursorPosition(60, pos);
                Console.Write("\t\t\t\t\t");
                if (pos % 2 == 0)
                {
                    Console.SetCursorPosition(60, pos);
                    Console.Write("____________________________________");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;          
            for (pos = 10; pos < 17; pos++)
            {
                Console.SetCursorPosition(62, pos);
                Console.Write(@"                                ");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 10; pos < 17; pos++)
            {
                Console.SetCursorPosition(63, pos);
                Console.Write("  ");
                Console.SetCursorPosition(91, pos);
                Console.Write("  ");
            }
            Console.SetCursorPosition(62, 16);
            Console.Write("                                ");
            Console.SetCursorPosition(62, 9);
            Console.Write("                                ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for (pos = 10; pos < 16; pos++)
            {
                Console.SetCursorPosition(71, pos);
                Console.Write("              ");
            }

            Console.SetCursorPosition(77, 13);
            Console.Write(@"\/");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(73, 14);
            Console.Write(")________(");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(72, 10);
            Console.Write(@"<(.)>  <(.)>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(74, 10);
            Console.Write(@"o");
            Console.SetCursorPosition(81, 10);
            Console.Write(@"o");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(76, 7);
            Console.Write("¡¡ AL FIN LIBRE!!");
            Console.BackgroundColor = ConsoleColor.Black;
        }

         /*------------------------------------------
         * DIBUJO TUMBA AL PERDER
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Dibujotumba()
        {
            int col, fil;
            col = 6;
            fil = 24;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(col, fil);
            Console.Write("                                        ");
            Console.SetCursorPosition(col, fil+1);
            Console.Write("                                        ");
            Console.SetCursorPosition(col, fil + 2);
            Console.Write("      Este preso murio ahorcado         ");
            Console.SetCursorPosition(col, fil + 3);
            Console.Write("                                        ");
            Console.SetCursorPosition(col, fil + 4);
            Console.Write("                                        ");
            Console.BackgroundColor = ConsoleColor.White;
            for (fil = 3; fil < 24; fil++)
            {
                Console.SetCursorPosition(23, fil);
                Console.Write("      ");
            }
            Console.SetCursorPosition(11, 7);
            Console.Write("                              ");
            Console.SetCursorPosition(11, 8);
            Console.Write("                              ");
        }

         /*------------------------------------------
         * GRAFICOS CUANDO PIERDES
         * Fecha inicio: 18/11/2010
         * Última modificación: 01/12/2010
         * ---------------------------------------*/
        static void Graficosperder()
        {
            Console.Clear();
            Console.SetWindowSize(52, 28);
            Console.SetCursorPosition(24, 12);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 2);
            Dibujotumba();
        }


        /*------------------------------------------
        * NOS DICE SI HAS GANADO O PERDIDO SEGUN EL CONTADOR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Terminar(int cont,char[] pelegida,char[]pacertada)
        {
            Console.SetCursorPosition(6, 35);
            if (cont < 1)
            {
                Graficosperder();
                Musicafinal();
                Console.ReadKey();
            }
            else
            {
                Console.Write("Enhorabuena, has salvado al preso    ");
                totalsalvados++;
                pacertada = pelegida;
                Mostrartodo(pelegida, pelegida);
                Ganar();
                Musicaganador();
                //NOS MUESTRA CUANTOS PRESOS HA SALVADO ESE JUGADOR EN TOTAL
                Mostrarpuntosjugador();
                Creditosganador();
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(0, 0);
        }


        /*------------------------------------------
        * BUCLE CENTRAL PARTIDA
        * ELEGIMOS LETRA, AUMENTA SI FALLAMOS EL CONT, Y MUESTRA POR PANTALLA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Buclecentral(char[]pelegida,char[]pacertadas,int dif,ref char[] controlletras)
        {
            char[] abecedario = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char letra;
            //Jugador seleccion una letra
            letra = Seleccionletra(ref controlletras);
            //MOSTRAR LETRAS QUE SE HAN SELECCIONADO
            Mostrarletras(letra, abecedario);
            //Comparar con las letras de la array
            // si está la iguala a 0 y la muestra por pantalla, sino cont++
            dif = Comparar(pacertadas, letra, dif);
            return (dif);
        }

        /*------------------------------------------
        * INTENTO DEL JUGADOR DE ACERTAR LA PALABRA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Acertarpalabra(char[] pelegida, char[] pacertadas,ref bool quedanletras,int dif)
        {
            int pos;
            char[] intento = new char[pelegida.Length];
            bool falloalguna;

            string palabraelegida;

            falloalguna = true;

            Console.SetCursorPosition(6, 35);
            Console.Write("Palabra:                               ");
            // NOS PIDE LAS LETRAS DE LA PALABRA Y COMPARA DIRECTAMENTE
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(15, 35);
            Console.CursorVisible = true;
            palabraelegida = Console.ReadLine();
            palabraelegida = palabraelegida.ToLower();
            Console.CursorVisible = false;
            intento = palabraelegida.ToCharArray();
            if (intento.Length < pelegida.Length)
                falloalguna = false;
            else
            {
                for (pos = 0; pos < pelegida.Length; pos++)
                {
                    //intento[pos] = Console.ReadKey().KeyChar;
                    if (intento[pos] != pelegida[pos])
                        falloalguna = false;
                }
            }
            if (falloalguna == false)
                dif--;
            else
                quedanletras = false;
            Console.ForegroundColor = ConsoleColor.White;
            return (dif);
        }


        /*------------------------------------------
        * DIBUJO DE LA CARCEL
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Carcel()
        {
            int pos;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            for (pos = 3; pos < 40; pos++)
            {
                Console.SetCursorPosition(60, pos);
                Console.Write("\t\t\t\t\t");
                if (pos % 2 == 0)
                {
                    Console.SetCursorPosition(60, pos);
                    Console.Write("____________________________________");

                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(62, 10);
            Console.Write(@" ||     ||<(.)>||<(.)>||     || ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(74, 10);
            Console.Write(@".");
            Console.SetCursorPosition(81, 10);
            Console.Write(@".");
            for (pos = 11; pos < 17; pos++)
            {
                Console.SetCursorPosition(62, pos);
                Console.Write(@"                                ");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 10; pos < 17; pos++)
            {
                Console.SetCursorPosition(63, pos);
                Console.Write("  ");
                Console.SetCursorPosition(70, pos);
                Console.Write("  ");
                Console.SetCursorPosition(77, pos);
                Console.Write("  ");
                Console.SetCursorPosition(84, pos);
                Console.Write("  ");
                Console.SetCursorPosition(91, pos);
                Console.Write("  ");
            }
            Console.SetCursorPosition(62, 16);
            Console.Write("                                ");
            Console.SetCursorPosition(62, 9);
            Console.Write("                                ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for (pos = 12; pos < 16; pos++)
            {
                Console.SetCursorPosition(68, pos);
                Console.Write(@"(__D");
            }

            for (pos = 12; pos < 16; pos++)
            {
                Console.SetCursorPosition(84, pos);
                Console.Write(@"C__)");
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }


        /*------------------------------------------
        * GRAFICOS DE LA PANTALLA MIENTRAS JUGAMOS
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosjugando(string nombrejugador)
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            //CUADRO NOMBRE
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (pos = 4; pos < 8; pos++)
            {
                Console.SetCursorPosition(3, pos);
                Console.Write("                                                    ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (pos = 5; pos < 7; pos++)
            {
                Console.SetCursorPosition(5, pos);
                Console.Write("                                                ");
            }
            Console.SetCursorPosition(6, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Heroe: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", nombrejugador);

            //PRIMER CUADRADO
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (pos = 9; pos < 16; pos++)
            {
                Console.SetCursorPosition(3, pos);
                Console.Write("                                                    ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (pos = 10; pos < 15; pos++)
            {
                Console.SetCursorPosition(5, pos);
                Console.Write("                                                ");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(6, 11);
            Console.Write("- ¿Deseas intentar acertar la palabra?       ");
            //SEGUNDO CUADRADO
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (pos = 18; pos < 31; pos++)
            {
                Console.SetCursorPosition(3, pos);
                Console.Write("                                                    ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (pos = 19; pos < 30; pos++)
            {
                Console.SetCursorPosition(5, pos);
                Console.Write("                                                ");
            }
            
            //TERCER CUADRADO
            Console.BackgroundColor = ConsoleColor.DarkGray;
            for (pos = 33; pos < 38; pos++)
            {
                Console.SetCursorPosition(3, pos);
                Console.Write("                                                    ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            for (pos = 34; pos < 37; pos++)
            {
                Console.SetCursorPosition(5, pos);
                Console.Write("                                                ");
            }
            //DIBUJO DE LA CARCEL
            Carcel();
        }


        /*------------------------------------------
        * PARA SABER EL NOMBRE DE LA TEMÁTICA ELEGIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static string Nombretematica(int elec)
        {
            //NOS PREGUNTA EN LA OPCION DEFAULT, QUE ES PARA DOS JUGADORES, SI QUEREMOS DAR UNA PISTA
            char pista;
            string tematica;
            switch (elec)
            {
                case 1:
                    tematica = "Cine";
                    break;
                case 2:
                    tematica = "Musica";
                    break;
                case 3:
                    tematica = "Deportes";
                    break;
                case 4:
                    tematica = "Sorpresa";
                    break;
                default:
                    do
                    {
                        Console.SetCursorPosition(75, 2);
                        Console.Write("¿Pista?");
                        pista = Console.ReadKey(true).KeyChar;
                        pista = char.ToLower(pista);
                        Console.SetCursorPosition(75, 2);
                        Console.Write("       ");

                        if (pista == 's')
                        {
                            Console.SetCursorPosition(75, 2);
                            tematica = Console.ReadLine();
                        }
                        else
                            tematica = " ";
                    } while (pista != 's' && pista != 'n');

                    break;
            }

            return (tematica);
        }


        /*------------------------------------------
        * MUESTRA TEMATICA ELEGIDA CUANDO EL JUGADOR ESTA JUGANDO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Mostrartematica(int elec)
        {
            string tematica;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            tematica=Nombretematica(elec);
            Console.SetCursorPosition(75, 2);
            Console.Write("{0}",tematica);
            Console.BackgroundColor = ConsoleColor.Black;
        }


        /*------------------------------------------
        * EL JUGADOR ELIGE INTENTAR HACER PALABRA O DECIR LETRA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Quehacejugador(char[] pelegida, char[] pacertadas,string nombrejugador,int elec,int dif,Random palabra)
        {
            bool quedanletras;
            char[] controlletras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            quedanletras = true;
            ConsoleKeyInfo resp;
            Graficosjugando(nombrejugador);
            //MUESTRA POR PANTALLA LAS LINEAS DE LA PALABRA
            Mostrartematica(elec);
            // DIBUJA EL AHORCADO EN RELACIÓN AL NIVEL DE DIFICULTAD
            Dibahorcado(10-dif);
            do
            {
                do
                {
                    Console.SetCursorPosition(15, 35);
                    Console.Write("                                      ");
                    Console.SetCursorPosition(6, 13);
                    Console.Write("                                 ");
                    Mostrarguiones(pelegida, pacertadas);
                    Console.SetCursorPosition(45, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.CursorVisible = true;
                    resp = Console.ReadKey(true);
                    Console.CursorVisible = false;
                    Console.ForegroundColor = ConsoleColor.White;
                } while (resp.Key != ConsoleKey.S && resp.Key != ConsoleKey.N && (resp.Modifiers != ConsoleModifiers.Control || resp.Key != ConsoleKey.Z));
                if (resp.Key == ConsoleKey.N)
                {
                    dif = Buclecentral(pelegida, pacertadas, dif,ref controlletras);
                    // LAS QUE SE ACIERTAN, DA POR VERDADERO
                    quedanletras = Comprobarletras(pacertadas);
                }
                else
                {
                    if(resp.Modifiers == ConsoleModifiers.Control || resp.Key == ConsoleKey.Z)
                    {
                        Menu(palabra);
                    }
                    dif = Acertarpalabra(pelegida, pacertadas, ref quedanletras,dif);
                }
                //COMPRUEBA SI QUEDAN LETRAS, SI TODAS SON 5, QUE ES EL VALOR CON LAS QUE SUSTITUYE
                //MUESTA GUIONES O LETRAS O LA PALABRA ACERTADA COMPLETA
                Mostrarguiones(pelegida, pacertadas);
                //NOS DIBUJA AHORCADO SI FALLAMOS
                Dibujoahorcado(10-dif);
                //Control por si se pasa de fallos
                // si cont =3, pierde y DA VERDADERO COMO SI NO QUEDARAN PALABRAS
            }while (dif > 0 && quedanletras==true);
            return (dif);
        }


        /*------------------------------------------
        * DIBUJO DE BATMAN CUANDO NOS PIDE EL NOMBRE
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Dibujoheroe()
        {
            int fil, col;
            fil = 21;
            col = 25;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(col, fil);
            Console.Write(@"MMMMMMMMMMMMMMMMMMMMM.                             MMMMMMMMMMMMMMMMMMMMM");
            Console.SetCursorPosition(col, fil+1);
            Console.Write(@" `MMMMMMMMMMMMMMMMMMMM           M\  /M           MMMMMMMMMMMMMMMMMMMM'");
            Console.SetCursorPosition(col, fil+2);
            Console.Write(@"   `MMMMMMMMMMMMMMMMMMM          MMMMMM          MMMMMMMMMMMMMMMMMMM'  ");
            Console.SetCursorPosition(col, fil+3);
            Console.Write(@"     MMMMMMMMMMMMMMMMMMM-_______MMMMMMMM_______-MMMMMMMMMMMMMMMMMMM    ");
            Console.SetCursorPosition(col, fil+4);
            Console.Write(@"      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM    ");
            Console.SetCursorPosition(col, fil+5);
            Console.Write(@"      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM    ");
            Console.SetCursorPosition(col, fil+6);
            Console.Write(@"      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM    ");
            Console.SetCursorPosition(col, fil+7);
            Console.Write(@"     .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.    ");
            Console.SetCursorPosition(col, fil+8);
            Console.Write(@"    MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM  ");
            Console.SetCursorPosition(col, fil+9);
            Console.Write(@"                   `MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM'                ");
            Console.SetCursorPosition(col, fil+10);
            Console.Write(@"                          `MMMMMMMMMMMMMMMMMM'                    ");
            Console.SetCursorPosition(col, fil+11);
            Console.Write(@"                              `MMMMMMMMMM'                             ");
            Console.SetCursorPosition(col, fil+12);
            Console.Write(@"                                 MMMMMM                           ");
            Console.SetCursorPosition(col, fil+13);
            Console.Write(@"                                  MMMM                               ");
            Console.SetCursorPosition(col, fil+14);
            Console.Write(@"                                   MM    ");
        }


        /*------------------------------------------
        * GRAFICOS CUANDO ELEGIMOS NOMBRE
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficoselegir()
        {
            Console.SetCursorPosition(0, 0);
            Dibujototalmonigotes();
            Console.SetCursorPosition(0, 0);
            Dibujoheroe();
        }


        /*------------------------------------------
        * NOS PIDE EL NOMBRE DEL JUGADOR, tiene que ser menos que 12 y mayor que 0
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static string Nombrejugador()
        {
            string nombre;
            do
            {
                Graficoselegir();
                Console.SetCursorPosition(12, 7);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Nombre del Heroe: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.CursorVisible = true;
                nombre = Console.ReadLine();
                Console.CursorVisible = false;
                if (nombre.Length > 12)
                {
                    Console.SetCursorPosition(10, 8);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("    - Nombre demasiado largo");
                    Thread.Sleep(1000);
                }

            } while (nombre.Length > 12||nombre.Length==0);
            return (nombre);
        }


        /*------------------------------------------
        * NOS GRABA LOS DATOS EN LAS VARIABLES GLOBALES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Grabartodo(string nombrejugador)
        {
            //NOS GRABA LOS DATOS DEL JUGADOR EN LA VARIABLE GLOBAL
            jugador1grabar = nombrejugador;
        }


        /*------------------------------------------
        * MOSTRAR PUNTUACION DEL JUGADOR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Mostrarpuntosjugador()
        {
            Console.BackgroundColor=ConsoleColor.DarkGreen;
            Console.ForegroundColor=ConsoleColor.White;
            Console.SetCursorPosition(20, 13);
            Console.Write("--------------------------------------------------");
            Console.SetCursorPosition(20, 14);
            Console.Write("                                                  ");
            Console.SetCursorPosition(20, 15);
            Console.Write("                                                  ");
            Console.SetCursorPosition(20, 15);
            Console.Write("       {0} has salvado {1} presos en total", jugador1grabar, totalsalvados);
            Console.SetCursorPosition(20, 16);
            Console.Write("                                                  ");
            Console.SetCursorPosition(20, 17);
            Console.Write("--------------------------------------------------");
            Console.ReadKey();
        }


        /*------------------------------------------
        // NOS GUARDA LOS PUNTOS DEL JUGADOR EN LA CLASIFICACION CON SU NOMBRE
        //NOS MIRA EN QUE POSICIÓN DE LA CLASIFICACIÓN GUARDAR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Guardaclasificacion()
        {
            bool escrito;
            escrito = false;
            string salvados;
            salvados = totalsalvados+"";
            int fil;
            for (fil = 0; fil < clasificacion.GetLength(0); fil++)
            {
                if (escrito == false)
                    //POR SI YA HUBIERA MARCADO, PARA ACTUALIZAR MARCA
                    if (clasificacion[fil, 0] == jugador1grabar)
                    {
                        escrito = true;
                        clasificacion[fil, 1] = salvados;
                    }
                if (escrito == false)
                {
                    if (clasificacion[fil, 0] == "")
                    {
                        escrito = true;
                        clasificacion[fil, 0] = jugador1grabar;
                        clasificacion[fil, 1] = salvados;
                    }
                }
            }
            //SI HAY DIEZ JUGADORES, SE CREA EL JUGADOR 11, ESTE BORRA EL QUE TENGA MENOS PUNTOS Y 
            //ENTRA A MARCAR
            if (escrito == false)
            {
                escrito = true;
                clasificacion[9, 0] = jugador1grabar;
                clasificacion[9, 1] = salvados;
            }
        }


        /*------------------------------------------
        * PARA CONTINUAR JUGANDO CON EL NOMBRE DEL JUGADOR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Mismonombre(string nombrejugador)
        {
            char respuesta;
            int fil;
            Console.ForegroundColor = ConsoleColor.Blue;
            for (fil = 0; fil < clasificacion.GetLength(0); fil++)
            {
                if (nombrejugador == clasificacion[fil, 0])
                {
                    Console.SetCursorPosition(9, 9);
                    Console.Write("   Heroe ya conocido, ¿Seguir jugando con él o empezar de 0?");
                    do
                    {
                        Console.CursorVisible = true;
                        respuesta = Console.ReadKey(true).KeyChar;
                        Console.CursorVisible = false;
                        respuesta = char.ToLower(respuesta);
                        if (respuesta == 's')
                        {
                            nombrejugador = jugador1grabar;
                            totalsalvados =Convert.ToInt16( clasificacion[fil, 1]);
                        }
                        if (respuesta == 'n')
                            totalsalvados = 0;
                    } while (respuesta != 's' && respuesta != 'n');
                }
            }
        }


        /*------------------------------------------
        * COMPROBAR NOMBRE SECRETO PARA MUSICA SECRETA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Secreto(string nombrejugador)
        {
            if (nombrejugador == "Spiderman")
                Musicaspider();
            if (nombrejugador == "Superman")
                Musicasuper();
            if (nombrejugador == "Rocky")
                Musicarocky();
        }


        /*------------------------------------------
        * JUGAR AL AHORCADO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Jugar(char[] pelegida, int elec, int dif, Random palabra, bool continuando)
        {
            Console.SetCursorPosition(0, 0);
            Dibujototalmonigotes();
            string nombrejugador;
            char[] pacertadas=new char[pelegida.Length];
            hajugado = true;
            //CREA UNA ARRAY DE CONTROL PARA LETRAS ACERTADAS
            Control(pelegida,pacertadas);
            if (continuando == false)
            {
                totalsalvados = 0;
                //NOS PIDE EL NOMBRE DEL JUGADOR
                nombrejugador = Nombrejugador();
                //SI CON ESE NOMBRE YA SE HA JUGADO
                Mismonombre(nombrejugador);
                Secreto(nombrejugador);
            }
            else
            {
                nombrejugador = jugador1grabar;
                Secreto(nombrejugador);
            }
            Console.Write("{0}", totalsalvados);
            //BUCLE CENTRAL DE LA PARTIDA
            //ELEGIMOS LETRA, AUMENTA SI FALLAMOS EL CONT, Y MUESTRA POR PANTALLA
            dif= Quehacejugador(pelegida, pacertadas,nombrejugador,elec,dif,palabra);           
            //NOS DICE SI HAS GANADO O HAS PERDIDO
            Terminar(dif,pelegida,pacertadas);
            //NOS GRABA LOS DATOS DEL JUGADOR EN LA VARIABLE GLOBAL
            Grabartodo(nombrejugador); 
            //NOS GUARDA EL NOMBRE Y LOS PUNTOS EN LA CLASIFICACION
            Guardaclasificacion();
            Musicamenu();
        }


        /*------------------------------------------
        * GRAFICOS DE LOS BARROTES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosbarrotes()
        {
            int pos;
            Console.BackgroundColor = ConsoleColor.White;
            for (pos = 0; pos < 43; pos++)
            {
                Console.SetCursorPosition(4, pos);
                Console.Write("    ");
            }
            for (pos = 0; pos < 43; pos++)
            {
                Console.SetCursorPosition(112, pos);
                Console.Write("    ");
            }
        }


        /*------------------------------------------
        * LETRAS DE AHORCADO DEL TITULO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficostitulototal()
        {
            int fil;
            fil = 7;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(27, fil);
            Console.Write(@"     ___   _   _   _____   _____    _____       ___   _____   _____ ");
            Console.SetCursorPosition(27, fil+1);
            Console.Write(@"    /   | | | | | /  _  \ |  _  \  /  ___|     /   | |  _  \ /  _  \ ");
            Console.SetCursorPosition(27, fil+2);
            Console.Write(@"   / /| | | |_| | | | | | | |_| |  | |        / /| | | | | | | | | |");
            Console.SetCursorPosition(27, fil+3);
            Console.Write(@"  / / | | |  _  | | | | | |  _  /  | |       / / | | | | | | | | | | ");
            Console.SetCursorPosition(27, fil+4);
            Console.Write(@" / /  | | | | | | | |_| | | | \ \  | |___   / /  | | | |_| | | |_| | ");
            Console.SetCursorPosition(27, fil+5);
            Console.Write(@"/_/   |_| |_| |_| \_____/ |_|  \_\ \_____| /_/   |_| |_____/ \_____/ ");
        }


        /*------------------------------------------
        * GRAFICOS CREDITOS JESUS CUESTA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficoscreditos()
        {
            int fil, col;
            fil = 35;
            col = 72;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(col, fil);
            Console.Write(@"                     \ \|/ /");
            Console.SetCursorPosition(col, fil+1);
            Console.Write(@"                      (O O)");
            Console.SetCursorPosition(col, fil+2);
            Console.Write(@"        +--------oOO--(_)-------------+");
            Console.SetCursorPosition(col, fil+3);
            Console.Write(@"        |  Diseñado:   Jesus Cuesta   |");
            Console.SetCursorPosition(col, fil+4);
            Console.Write(@"        +-----------------oOO---------+");
            Console.SetCursorPosition(col, fil+5);
            Console.Write(@"                     |__|__|");
            Console.SetCursorPosition(col, fil+6);
            Console.Write(@"                      | | |");
            Console.SetCursorPosition(col, fil+7);
            Console.Write(@"                     ooO Ooo");
        }


        /*------------------------------------------
        * GRAFICOS MENU PRINCIPAL2
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosmenu()
        {
            Console.SetWindowSize(120, 43);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Graficosbarrotes();
            Console.ForegroundColor = ConsoleColor.Red;
            Graficostitulototal();
        }


        /*------------------------------------------
        * NOS COMPRUEBA DONDE ESTA EL CURSOR PARA CAMBIAR EL COLOR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Cambiarcolor(int valor,int num)
        {
            if (valor == num)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        /*------------------------------------------
        * ACTUALIZA LOS VALORES DE VALOR SEGUN FLECHA ARRIBA O ABAJO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Actualizarvalor(ref int valor, ConsoleKeyInfo sombreado,int sup,int inf)
        {
            if (sombreado.Key == ConsoleKey.DownArrow)
                valor++;
            if (sombreado.Key == ConsoleKey.UpArrow)
                valor--;
            if (valor > sup)
                valor = inf;
            if (valor < inf)
                valor = sup;
        }

        /*------------------------------------------
        * LETRAS DEL MENU PRINCIPAL
         * SE COLOREA Y SE MUEVE CON LOS CURSORES
         * DEVUELVE EL MENU SELECCIONADO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Letrasmenu()
        {
            int fil,col,valor;
            fil = 25;
            col = 13;
            valor = 1;
            ConsoleKeyInfo sombreado;
            do
            {
                Cambiarcolor(valor, 1);
                Console.SetCursorPosition(col, fil);
                Console.Write("   Configurar Juego    ");
                Console.BackgroundColor = ConsoleColor.Black;

                Cambiarcolor(valor, 2);
                Console.SetCursorPosition(col, fil + 2);
                Console.Write("     Partida Nueva     ");
                Console.BackgroundColor = ConsoleColor.Black;

                Cambiarcolor(valor, 3);
                Console.SetCursorPosition(col, fil + 4);
                Console.Write("    Guardar Partida    ");

                Cambiarcolor(valor, 4);
                Console.SetCursorPosition(col, fil + 6);
                Console.Write("    Cargar Partida     ");

                Cambiarcolor(valor, 5);
                Console.SetCursorPosition(col, fil + 8);
                Console.Write("      Clasficación     ");

                Cambiarcolor(valor, 6);
                Console.SetCursorPosition(col, fil + 10);
                Console.Write("     Instrucciones     ");

                Cambiarcolor(valor, 7);
                Console.SetCursorPosition(col, fil + 12);
                Console.Write("   Continuar Jugando   ");
                Console.BackgroundColor = ConsoleColor.Black;

                Cambiarcolor(valor, 8);
                Console.SetCursorPosition(col, fil + 14);
                Console.Write("         Salir         ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                sombreado = Console.ReadKey();
                Actualizarvalor(ref valor, sombreado,8,1);
            } while (sombreado.Key != ConsoleKey.Enter);
            return (valor);
        }


        /*------------------------------------------
        * GRAFICOS Y LETRAS DEL MENU 2 DONDE SE ELIGE TEMATICA Y NIVEL
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Graficosopcionesmenu2()
        {
            int valor;
            valor = 1;
            Console.ForegroundColor = ConsoleColor.Green;
            Graficosmenu();
            Calavera();
            ConsoleKeyInfo sombreado;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(13, 29);
                Console.Write(" - CONFIGURACIÓN -");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Cambiarcolor(valor, 1);
                Console.SetCursorPosition(13, 32);
                Console.Write("   Elegir temática   ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Cambiarcolor(valor, 2);
                Console.SetCursorPosition(13, 34);
                Console.Write("    Elegir nivel     ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Cambiarcolor(valor, 3);
                Console.SetCursorPosition(13, 36);
                Console.Write("    Volver Atras     ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                sombreado = Console.ReadKey();
                Actualizarvalor(ref valor, sombreado, 3, 1);
            } while (sombreado.Key != ConsoleKey.Enter);
            return (valor);
        }


        /*------------------------------------------
        * LETRAS NIVEL PARTIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Letrasnivel()
        {
            int fil, col;
            col = 56;
            fil = 18;
            int valor;
            valor = 1;
            ConsoleKeyInfo sombreado;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(col, fil);
                Console.WriteLine(" - NIVEL -");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(col, fil + 3);
                Cambiarcolor(valor, 1);
                Console.WriteLine("   Facil   ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(col, fil + 5);
                Cambiarcolor(valor, 2);
                Console.WriteLine("   Normal  ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(col, fil + 7);
                Cambiarcolor(valor, 3);
                Console.WriteLine("  Dificil  ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
                sombreado = Console.ReadKey();
                Actualizarvalor(ref valor, sombreado, 3, 1);
            } while (sombreado.Key != ConsoleKey.Enter);
            return (valor);
        }

        /*------------------------------------------
        * PARA PONER CUANTOS ERROreS PODRAN TENER SEGUN EL NIVEL DE DIFCULTAD
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Actualizarnivel(ref int dif)
        {
            switch (dif)
            {
                case 1:
                    dif = 10;
                    break;
                case 2:
                    dif = 5;
                    break;
                default:
                    dif = 3;
                    break;
            }
        }


        /*------------------------------------------
        * DIBUJO MONIGOTE QUE SALE EN ELEGIR NIVEL
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Monigote()
        {
            int fil, col;
            fil=14;
            col=35;
            Console.SetCursorPosition(col, fil-1);
            Console.Write(@"       _________________________________________");
            Console.SetCursorPosition(col, fil);
            Console.Write(@"   .'`                                           `'.");
            Console.SetCursorPosition(col, fil+1);
            Console.Write(@"   |   _________________________________________   |");
            Console.SetCursorPosition(col, fil+2);
            Console.Write(@"   | '\.---------------------------------------./' |");
            Console.SetCursorPosition(col, fil+3);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+4);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+5);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+6);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+7);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+8);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+9);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+10);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+11);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+12);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+13);
            Console.Write(@"   | ||                                         || |");
            Console.SetCursorPosition(col, fil+14);
            Console.Write(@"   | '/\_______________________________________/\' |");
            Console.SetCursorPosition(col, fil+15);
            Console.Write(@"   '  `-----------------------------------------'  '");
            Console.SetCursorPosition(col, fil+16);
            Console.Write(@"    \                                     .-.     /");
            Console.SetCursorPosition(col, fil+17);
            Console.Write(@"     '.__~~~ ____()__()_()()() __________((_))__.'");
            Console.SetCursorPosition(col, fil+18);
            Console.Write(@"    _________________';========;'__________________");
            Console.SetCursorPosition(col, fil+19);
            Console.Write(@"   /  _/__/_//_//   _/_/    /_//_//   __/__/_//    \");
            Console.SetCursorPosition(col, fil+20);
            Console.Write(@"  /_/__/_/_/   __/ _/.-'''''-.   /_//       _/ _//_/\");
            Console.SetCursorPosition(col, fil+21);
            Console.Write(@" / _.-..-..-.     .'           `.     .-..-..-./_//_||");
            Console.SetCursorPosition(col, fil+22);
            Console.Write(@"/ /_| || || |-. .'               `. .-| || || | /_/ //");
            Console.SetCursorPosition(col, fil+23);
            Console.Write(@"----\ '  '   ' /                   \ `   '  ' /----((");
            Console.SetCursorPosition(col, fil+24);
            Console.Write(@" ~~~~\      / /                     \ \      /~~~~~ ))");
            Console.SetCursorPosition(col, fil+25);
            Console.Write(@"      `'--'`-:                       :-`'--'`   __,</");
            Console.SetCursorPosition(col, fil+26);
            Console.Write(@"         \   |                       |   /   .'`  `\)");
            Console.SetCursorPosition(col, fil+27);
            Console.Write(@"          `'-:                       :-'`   | `-../|");
            Console.SetCursorPosition(col, fil+28);
            Console.Write(@"             '                       '      \`-'`|/");
        }


        /*------------------------------------------
        * SELECCIONAR EL NIVEL DE LA PARTIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Nivelpartida(ref int dif)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Graficosmenu();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Monigote();
            dif = Letrasnivel();
            //PARA PONER CUANTOS ERROS PODRAN TENER SEGUN EL NIVEL DE DIFCULTAD
            Actualizarnivel(ref dif);
        }


        /*------------------------------------------
        * DIBUJO DE LA CALAVERA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Calavera()
        {
            int fil, col;
            fil = 17;
            col = 40;
            Console.SetCursorPosition(col, fil);
            Console.Write(@"                           _,..__,");
            Console.SetCursorPosition(col, fil + 1);
            Console.Write(@"                       ,.'''      `¨-,_");
            Console.SetCursorPosition(col, fil + 2);
            Console.Write(@"                     ,'                '.");
            Console.SetCursorPosition(col, fil + 3);
            Console.Write(@"                   ,'                    '");
            Console.SetCursorPosition(col, fil + 4);
            Console.Write(@"                  /                       \_");
            Console.SetCursorPosition(col, fil + 5);
            Console.Write(@"                 ;     -.                   `\");
            Console.SetCursorPosition(col, fil + 6);
            Console.Write(@"                 |       |     _         _    .");
            Console.SetCursorPosition(col, fil + 7);
            Console.Write(@"                ;       ,'  ,-' `.     /' `.  |");
            Console.SetCursorPosition(col, fil + 8);
            Console.Write(@"                |       '  /  o   |   t  o  \.'    .,-.");
            Console.SetCursorPosition(col, fil + 9);
            Console.Write(@"                 |         |:    .'   |:    .|    /    \");
            Console.SetCursorPosition(col, fil + 10);
            Console.Write(@"                 ;         \:.._./    ':_..:/ `. |      L");
            Console.SetCursorPosition(col, fil + 11);
            Console.Write(@"                  \  ,-'           |\_         `\-     ¨¨-.");
            Console.SetCursorPosition(col, fil + 12);
            Console.Write(@"      ,-¨'``'-,    `f              '/`>                    `.");
            Console.SetCursorPosition(col, fil + 13);
            Console.Write(@"    ,'        `L___.|              '  `     . _,/            \");
            Console.SetCursorPosition(col, fil + 14);
            Console.Write(@"    |                \_          _   _    .-.]____,,r        ");
            Console.SetCursorPosition(col, fil + 15);
            Console.Write(@"    \             ,. ___¨¨----./` \,' ',`\'  \      \       .'");
            Console.SetCursorPosition(col, fil + 16);
            Console.Write(@"      `'-'|        '`         `|   |   |  |  |       `'--¨'`");
            Console.SetCursorPosition(col, fil + 17);
            Console.Write(@"          ,         |           L_.'.__:__.-'");
            Console.SetCursorPosition(col, fil + 18);
            Console.Write(@"           \        /");
            Console.SetCursorPosition(col, fil + 19);
            Console.Write(@"            `'-- ¨ '`");


        }


        /*------------------------------------------
        * MENU 2 CON TEMATICA Y ELECCION DE NIVEL DE DIFICULTAD
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Opcionesmenu2(int eleccion,Random palabra,ref int elec,ref int dif)
        {
            switch (eleccion)
            {
                case 1:
                    // ELEGIR TEMÁTICA
                    Elegirtematica(palabra,ref elec);
                    break;
                case 2:
                    // ELEGIR Nivel Partida
                    Nivelpartida(ref dif);
                    break;
                default:
                    break;
            }
        }


        /*------------------------------------------
        * CONFIGURACION PARTIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Configuracion(Random palabra,ref int elec,ref int dif)
        {
            int eleccion;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            eleccion = Graficosopcionesmenu2();
            Opcionesmenu2(eleccion,palabra,ref elec,ref dif);
        }


        /*------------------------------------------
        * LETRAS DEL MENU JUGADORES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static int Letrasjugadores()
        {
            int valor;
            valor = 1;
            ConsoleKeyInfo sombreado;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(50, 21);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Cambiarcolor(valor, 1);
                Console.Write("   1 vs Ordenador   ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(50, 24);
                Cambiarcolor(valor, 2);
                Console.Write("       1 vs 1       ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Black;
                sombreado = Console.ReadKey();
                Actualizarvalor(ref valor, sombreado, 2, 1);
            } while (sombreado.Key != ConsoleKey.Enter);
            return (valor);
        }


        /*------------------------------------------
        * DIBUJO DEL DEMONIO GUARDIAN DE 1VS1
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Dibujodemonio()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"           _.'          .
           |P`            ?\
          .¨h              ¨B
          (¨¨h             ¨P
          ?¨¨¨,          .¨¨P
          {¨``¨¨oo____oo¨¨¨¨P
           '¨¨888888888888,;
            `?88P^\,?88^\,Y
              88?\__d88\_/'
              `8o8888/\88P
               ,?oo88oo8P
     ___  __===~88~\\\\\|~====__ __       ___
 .-==ooo~odoooob ?8/////'oooood88888ooo?P88888?ooo?888PooooOoooooooo=~--
d,d8888obo8,oo8b,``~~~,o?8oo,8888**8P88?8`oo,o888?898o8P888P~8b
8o88888oP?.,,ooood8b,.oo.,oo88?o8888P^^^?8888P^^^^==+=~~~?8bo?P
?8.=~=.8do.,oo88888ooo,o,oo88888o,;                      `6
.?*o88ob`8.,o88888888oo,o,o88888o,'                       `\
|*o8888o`8,oo88888888oo,o,o?8888o'
`?o8888P`88,,oo88888oo,,.,oo88oo;
.8`o888'**888oo,,,,oood88oo,,d8'
doo,,oP  ?888o,,o8o,o8o,,,o8oo'
8od8bo'  `?88o,,o8o,o88o,.,o,o'
8o888o    `88o,,o8o,o8o,.,o,o'
?o888P     ===========<666>==
`?88P     ********************
 ?ooPb   ',odoo,************,b
d{{{{b\,(,oo88ooo,,********,oob
OOOOO \\,oo8888ooo,,******,o888,
(\\\\ ||,o8888888oo,,*****,o88o)
  \\\\/`,o8888888oo',*****,888o|
        `oo8888888o',*****,888o|
        `,o888888oo,,*****,o8oo'
        `,o88888oo,, *****,o8oP
        `?,o888oP,,  *****,ooP
         `8-==-P,    |****,,-='
          ?o88oP     |*'d*,o88
         .dboodb.     *;8*,o88
         ,od88boo     *,o*,o88'
         do8888ob     *`o*,o8P
         ?o8888oP     |`,|,oo'
         `o8888o'     `?o8oP
          `o88o'      ,o88o'
           ?ooP       `?88o'
          dooo'b      'o88oo,.
         '?o===o   ~-=8oo888888oo.__
         8888888     `~~~' `==~~~=-,' 
         ?8P?88P 
          V''V'     
          '  '");
        }


        /*------------------------------------------
        * GRAFICOS 1VS1, EL DEL DEMONIO Y NOS PIDE LA PALABRA SECRETA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosdosjugadores()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Dibujodemonio();
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(16, 16);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("JUGADOR 1");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(38, 18);
            Console.Write("Palabra Secreta: ");
        }


        /*------------------------------------------
        * PARA JUGAR 1VS1
         * No nos deja poner una palabra mayor de 12 letras o menor de 2
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Dosjugadores(ref int elec,ref int dif,Random palabra,bool continuando)
        {
            char[] pelegida;
            string palabrass;
            elec = 5;
            do
            {
                Graficosdosjugadores();
                //CREAR GRAFICOS DE ESTO, EXPLICAR QUE JUGADOR 1 ES EL CARCELERO QUE ELIJE LA PALABRA SECRETA
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Blue;
                palabrass = Console.ReadLine();
                palabrass = palabrass.ToLower();
                Console.CursorVisible = false;
                pelegida = palabrass.ToCharArray();
                if (palabrass.Length > 12)
                {
                    Console.SetCursorPosition(70, 10);
                    Console.Write(" - Palabra demasiado grande");
                    Thread.Sleep(1000);
                }
            } while (palabrass.Length > 12 || palabrass.Length<2);
            Jugar(pelegida, elec, dif, palabra, continuando);
        }


        /*------------------------------------------
        * ELEGIR EL NUMERO DE JUGADORES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Ejecutarjugadores(int eleccion, Random palabra, ref int elec, ref int dif)
        {
            bool continuando;
            continuando = false;
            char[] pelegida;
            switch (eleccion)
            {
                case 1:
                    pelegida = Selectematica(palabra, elec);
                    musicamenu.Stop();
                    Musicajugar(palabra);
                    Jugar(pelegida,elec,dif,palabra,continuando);
                    break;
                default:
                    musicamenu.Stop();
                    Musica1vs1(palabra);
                    Dosjugadores(ref elec,ref dif,palabra,continuando);
                    break;
            }
        }


        /*------------------------------------------
        * JUGAR 1 O 2 JUGADORES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Jugadores(int eleccion, Random palabra, ref int elec, ref int dif)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Graficosmenu();
            eleccion = Letrasjugadores();
            Ejecutarjugadores(eleccion,palabra,ref elec,ref dif);
        }


        /*------------------------------------------
        * CONFIRMAR SI SE QUIERE GRABAR
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static bool Confirmar()
        {
            bool grabando;
            char letra;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 25);
            Console.Write("¿Estas seguro?");
            do
            {
                letra = Console.ReadKey(true).KeyChar;
                letra = char.ToLower(letra);
                if (letra == 's')
                    grabando = true;
                else
                    grabando = false;
            } while (letra != 's' && letra != 'n');
            return (grabando);
        }


        /*------------------------------------------
        * PARA GRABAR PARTIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Ejecutargrabar()
        {
            int fil;
            Console.CursorVisible = true;
            Console.CursorVisible = false;
            //SI EXISTE EL ARCHIVO DE CLASIFICACION,LO BORRRA Y LO CREA CON LA NUEVA ACTUALIZADA
            FileInfo borrado = new FileInfo(@"clasificacion\clasificacion.txt");
            if (borrado.Exists)
                borrado.Delete();
            StreamWriter contenido = new StreamWriter(@"clasificacion\clasificacion.txt", true, Encoding.UTF8);
            for (fil = 0; fil < clasificacion.GetLength(0); fil++)
            {
                contenido.WriteLine(clasificacion[fil, 0]);
                contenido.WriteLine(clasificacion[fil, 1]);
            }
            contenido.Close();
        }

        /*------------------------------------------
        * PARA GRABAR PARTIDA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Grabar()
        {
            bool afirmando;
            afirmando=Confirmar();
            if (afirmando == true)
                Ejecutargrabar();   
        }


        /*------------------------------------------
        * CONTINUAR JUGANDO CON EL MISMO JUGADOR Y PUNTUACIÓN
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Continuar(Random palabra, ref int elec, ref int dif)
        {
            bool continuando;
            continuando = true;
            char[] pelegida; 
            //POR SI QUIERE CONTINUAR JUGANDO Y ANTES HABIA JUGADO A DOS JUGADORES, PARA QUE SE
            // LE PONGA aleatorio
            if (elec > 3)
                elec = palabra.Next(1,3);
            pelegida = Selectematica(palabra, elec);
            musicamenu.Stop();
            Musicajugar(palabra);
            Jugar(pelegida, elec, dif, palabra,continuando);
        }


        /*------------------------------------------
        * GRAFICOS DE LA CLASIFICACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosclasi()
        {
            Graficosmenu();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(55, 16);
            Console.Write("CLASIFICACION");
            Console.SetCursorPosition(35, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nombre del Jugador                    Presos Salvados");
        }


        /*------------------------------------------
        * MUESTRA LA CLASIFICACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Mostrarclasificacion()
        {
            Graficosclasi();
            int fil,col,pos;
            pos = 21;
            Console.ForegroundColor = ConsoleColor.White;
            for (fil = 0; fil < clasificacion.GetLength(0); fil++)
            {
                Console.SetCursorPosition(37, pos);
                for (col = 0; col < clasificacion.GetLength(1); col++)
                {
                    if(col==1)
                        Console.SetCursorPosition(78, pos);
                    Console.Write("{0,3} ", clasificacion[fil,col]);
                }
                if (clasificacion[fil, 1] != "")
                {
                    Thread.Sleep(400);
                }
                pos += 2;
            }
            Console.ReadKey();
        }


        /*------------------------------------------
        * BORRA LA ANTIGUA CLASIFICACIÓN PARA PODER GUARDAR BIEN LA OTRA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Borradorantigua()
        {
            int fil, col;
            for (fil = 2; fil < clasificacion.GetLength(0); fil++)
            {
                for (col = 0; col < clasificacion.GetLength(1); col++)
                {
                    clasificacion[fil, col] = "";
                }
            }
        }


        /*------------------------------------------
        * EJECUTAR CARGAR CLASIFICACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Ejecutarcargar()
        {
            int fil, col;
            string frase;
            //SI NO EXISTE EL FICHERO PARA CARGAR, NO LO CARGA, Y ASI NO SE BLOQUEA
            FileInfo comprobar = new FileInfo(@"clasificacion\clasificacion.txt");
            if (comprobar.Exists)
            {
                StreamReader contenido2 = new StreamReader(@"clasificacion\clasificacion.txt");
                Borradorantigua();
                for (fil = 0; contenido2.Peek() != -1; fil++)
                {
                    for (col = 0; col < 2; col++)
                    {
                        Console.CursorVisible = true;
                        frase = (string)contenido2.ReadLine();
                        clasificacion[fil, col] = frase;
                        Console.CursorVisible = false;

                    }
                }
                contenido2.Close();
            } 
        }


        /*------------------------------------------
        * CARGAR CLASIFICACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Cargarclasificacion()
        {
            bool afirmando;
            afirmando = Confirmar();
            if (afirmando == true)
                Ejecutarcargar();                      
        }


        /*------------------------------------------
        * GRAFICOS DE INSTRUCCIONES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Graficosinstruc()
        {
            Graficosmenu();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(55, 16);
            Console.Write("INSTRUCCIONES");
        }


        /*------------------------------------------
        * LETRAS DE INSTRUCCIONES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Letrasinstruc()
        {
            int pos,fil;
            pos = 19;
            fil = 19;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(fil, pos);
            Console.Write("Objetivo: Salva a los presos antes de que sean ahorcados");
            Console.SetCursorPosition(fil, pos + 2);
            Console.Write("Nivel de dificultad: Máximo número de errores");
            Console.SetCursorPosition(fil, pos + 4);
            Console.Write("Ganar: Acertar todas las letras o la palabra");
            Console.SetCursorPosition(fil, pos + 6);
            Console.Write("Puedes grabar y cargar la clasificación para continuar otro día jugando");
            Console.SetCursorPosition(fil, pos + 8);
            Console.Write("Pulsando Crt+Z durante el juego, saldrás al menu");
            Console.SetCursorPosition(fil, pos + 10);
            Console.Write("Puedes continuar jugando con tus puntos: ");
            Console.SetCursorPosition(fil, pos + 11);
            Console.Write("      - Seleccionando continuar jugando");
            Console.SetCursorPosition(fil, pos + 13);
            Console.Write("      - Nueva partida y escribiendo tu nombre que este en clasficación");
            Console.SetCursorPosition(fil, pos + 15);
            Console.Write("Temática: Elegir tipo de palabras. Por defecto Cine");
            Console.SetCursorPosition(fil, pos + 17);
            Console.Write("Dos Jugadores: Uno será el carcerlero y otro el héroe");
            Console.SetCursorPosition(fil, pos + 18);
            Console.Write("      - Uno pondrá la palabra secreta y una pista opcional, y el otro tendrá que acertar");
            Console.SetCursorPosition(fil, pos + 20);
            Console.Write("Descubre los héroes secretos con sus canciones");
        }


        /*------------------------------------------
        * MENU INSTRUCCIONES
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Instrucciones()
        {
            Graficosinstruc();
            Letrasinstruc();
            Console.ReadKey();
        }


        /*------------------------------------------
        * OPCIONES DEL MENU CONFIGURACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Opciones(int eleccion, Random palabra, ref int elec, ref int dif)
        {
            // DENTADA CON TODAS LAS PALABRAS Y CATEGORIAS
            switch (eleccion)
            {
                case 1:
                    Configuracion(palabra,ref elec,ref dif);
                    break;
                case 2:
                    Jugadores(eleccion, palabra, ref elec, ref dif);
                    break;
                case 3:
                    Grabar();
                    break;
                case 4:
                    Cargarclasificacion();
                    break;
                case 5:
                    Mostrarclasificacion();
                    break;
                case 6:
                    Instrucciones();
                    break;
                case 7:
                    if (hajugado == true)
                        Continuar(palabra, ref elec, ref dif);
                    break;
                default:
                    break;
            }
        }


        /*------------------------------------------
        * MENU PRINCIPAL
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Menu(Random palabra)
        {
            int eleccion,elec, dif;
            //PALABRA AL AZAR DEL GRUPO 4 POR DEFECTO, POR SI NO ELIGE NINGUNA
            elec = 1;
            dif = 10;
            musicapre.Stop();
            Musicamenu();
            Console.SetCursorPosition(0, 0);
            do
            {
                OrdenarClasificacion();
                Console.ForegroundColor = ConsoleColor.Red;
                Graficosmenu();
                Graficoscreditos();
                eleccion = Letrasmenu();
                Opciones(eleccion,palabra,ref elec,ref dif);
            } while (eleccion < 8);
        }


        /*------------------------------------------
        * LETRAS DE LA PRESENTACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Letraspre()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 18);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1º de DAI");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(33, 22);
            Console.Write("Dirigido y producido por Jesús Cuesta");
            Thread.Sleep(2250);
            Console.SetCursorPosition(33, 22);
            Console.Write("   Con colaboración del Visual Studio         ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(14, 18);
            Console.Write("Donde termina la esperanza");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(41, 18);
            Console.Write(" y comienza la agonia");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(19, 18);
            Console.Write("donde no hay lugar para la bondad");
            Thread.Sleep(2000);
            Console.Clear();
            Console.SetCursorPosition(12, 18);
            Console.Write("Existe una fortaleza");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(39, 18);
            Console.Write("oculta tras los sueños,");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(17, 18);
            Console.Write("donde se encierra lo que una vez fue bueno,");
            Thread.Sleep(2000);
            Console.Clear();
            Console.SetCursorPosition(18, 18);
            Console.Write("a los que una vez salvaron el mundo...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(26, 18);
            Console.Write("Fortaleza NothingGood");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(29, 20);
            Console.Write("muchos peligros");
            Thread.Sleep(2000);
            Console.SetCursorPosition(25, 20);
            Console.Write(" contraseñas olvidadas");
            Thread.Sleep(2000);
            Console.SetCursorPosition(24, 20);
            Console.Write("combate contra tus miedos");
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(31, 18);
            Console.Write("Ahorcado");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(27, 20);
            Console.Write("por Jesus Cuesta");

        }


        /*------------------------------------------
        * TAMAÑO DE LA VENTANA Y NOS CARGA LA PRESENTACION
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Presentacion()
        {
            Musicapresentacion();
            Console.SetWindowSize(75, 44);
            Letraspre();
            Console.ReadKey();
        }


        /*------------------------------------------
        * NOS PIDE LA UBICACION DE LOS FICHEROS DE SONIDOS, AHI ES DONDE TENEMOS LA MUSICA
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Ubicacion()
        {
            //Console.Write("Direccion donde esta el juego: ");
            //ubicacion = Console.ReadLine();
            ubicacion=@"sonidos\";
        }


        /*------------------------------------------
         * Carga la presentacion y nos permite cortarla a mitad
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Tecla()
        {
            Thread hilo = new Thread(Presentacion);
            Console.Title = "ahorcado";
            hilo.Start();
            Console.ReadKey(true);
            hilo.Abort();
            //PRESENTACION
           // Presentacion();
        }

        /*------------------------------------------
        * HACE INSIBLE EL CURSOR
        * DA TAMAÑO 100 AL CURSOR, PARA QUE CUANOD LO HAGMAOS VISIBLE, SE VEA MAS GRANDE
         * NOS PIDE LA UBICACION DE LOS FICHEROS DE SONIDOS, AHI ES DONDE TENEMOS LA MUSICA
         * CARGA LA PRESENTACION
         * COMIENZA EL JUEGO
        * Fecha inicio: 18/11/2010
        * Última modificación: 01/12/2010
        * ---------------------------------------*/
        static void Main(string[] args)
        {
            //RANDOM QUE SE USARÁ PARA ELEGIR LA PALABRA ALEATORIA
            Random palabra = new Random(DateTime.Now.Millisecond);
            //OCULTA EL CURSOR
            Console.CursorVisible = false;
            //AUMENTA EL TAMAÑO VISIBLE DEL CURSOR
            Console.CursorSize = 100;
          
            //PARA QUE SUENE LA MUSICA WAV
            Ubicacion();

            // CARGA LA PRESENTACION Y NOS PERMITE CORTARLA
            Tecla();

            //MENU
            Menu(palabra);
        }
    }
}
