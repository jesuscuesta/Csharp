using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace serpiente
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////// VARIABLES GLOBALES /////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////
        //1º HORIZONTAL IZQUIERDA //2º HORIZONTAL DERECHA // 2º VERTICAL
        static int[] Serpiente = new int[2];
        //FORMA DE LA FIGURA
        static string formafigura;
        //COLOR FONDO FIGURA
        static ConsoleColor colorFondoFigura;
        //COLOR LETRAS FIGURA
        static ConsoleColor colorLetrasFigura;
        //TECLA QUE NOS DIRÁ DONDE SE MUEVE LA FIGURA
        static ConsoleKey teclaparamover;

        //PELOTA DONDE ESTA
        static int[] loc_Bola = new int[2];
        //FORMA DE LA PELOTA
        static char forma_Pelota;
        //COLOR DE LA PELOTA
        static ConsoleColor color_Pelota;
        //VELOCIDAD PELOTA
        static int velocidad_Pelota;
        //DIVISOR PARA VELOCIDAD PELOTA
        static int velocidad_divisor;
        // MOVIMIENTO PELOTA
        static ConsoleKey movimiento_pelota;
        //DIRECCION PELOTA - 1º X 2º y
        static int[] direccion_pelota = new int[2];
        //PARA CONTROLAR CUANTAS VECES SE MUEVE LA PELOTA
        static int controlpelota;
        //VECES GOLPEADA PELOTA
        static int pelota_golpeada;

        //OBSTACULOS
        //1.- X// Izquierda // 2.- X - Derecha // 3.- Y //4.- CANTIDAD DE GOLPES QUE AGUANTA
        static int[,] obstaculos;
        static ConsoleColor[] obstaculos_color;
        //CUANDO SE REDUCE A 0 OSTACULOS, PASAS FASE
        static int pasarfase;

        //ANCHO Y ALTO PANTALLA
        static int[] pantalla = new int[2];
        //COLOR PANTALLA GRANDE
        static ConsoleColor fondoPantallaColor;

        //BORDES SUB TABLA
        //[0,*] - BORDES IZQUIERDO Y DERECHO
        //[1,*] - BORDES DE ARRIBA Y ABAJO
        static int[,] subtabla=new int [2,2];
        //COLOR FONDO TABLA
        static ConsoleColor fondoTablaColor;
        //EFECTO LINEA ELECTRICA DE LA LINEA DE PARTIDA
        static int controlefecto;

        //NUMERO ALEATORIO
        static Random aleatorio = new Random(DateTime.Now.Millisecond);

        //VIDAS DEL JUGADOR
        static int vidasjugador = 3;

        /////////////////////////////////////////////////////////////////////////////////////7
        /////////////////////////////////////////////////////////////////////////////////////7
        /////////////////////////////////////////////////////////////////////////////////////7

        //GRAFICOS GENERALES- TAMAÑO PANTAÑA
        static void Generales(int x, int y,ConsoleColor colorfondo)
        {
            pantalla[0] = x;
            pantalla[1] = y;
            Console.SetWindowSize(x, y);
            fondoPantallaColor = colorfondo;
            Console.BackgroundColor = colorfondo;
            Console.Clear();
        }

        //DIBUJAR SUBTABLERO
        static void Dibujarsubtablero(int anchoIzq, int anchoDer, int altoIzq, int altoDer)
        {
            int pos, pos2;
            for (pos = altoIzq; pos < altoDer; pos++)
            {
                for (pos2 = anchoIzq; pos2 < anchoDer; pos2++)
                {
                    Console.SetCursorPosition(pos2, pos);
                    Console.Write(" ");
                }
            }
        }

        //ASIGNAR DATOS SUBTABLA A VARIABLES GLOBALES
        static void Setsubtabla(int anchoIzq, int anchoDer, int altoIzq, int altoDer)
        {
            subtabla[0, 0] = anchoIzq;
            subtabla[0, 1] = anchoDer;
            subtabla[1, 0] = altoIzq;
            subtabla[1, 1] = altoDer;
        }

        //NOS DIBUJA EL BORDE DE ABAJO PARA PERDER
        static void Dibujar_electrico(ConsoleColor color)
        {
            int pos;
            Console.ForegroundColor = color;
            Console.BackgroundColor = fondoTablaColor;
            Console.SetCursorPosition(subtabla[0, 0], subtabla[1, 1]-2);
            for (pos = 0; pos < (subtabla[0, 1] - subtabla[0, 0])/2; pos++)
            {
                if(controlefecto%3==0)
                    Console.Write(@"/\");
                else
                    Console.Write(@"\/");
            }
            controlefecto++;
            if (controlefecto>9)
                controlefecto=0;
        }

        //GRAFICOS DEL TABLERO
        static void Tablero(int anchoIzq, int anchoDer, int altoIzq, int altoDer,ConsoleColor colorsubtabla)
        {
            //ASIGNAR VALORES A VARIABLES GLOBALES
            Setsubtabla( anchoIzq,  anchoDer, altoIzq, altoDer);
            //COLOR DE LA SUBTABLA
            Console.BackgroundColor = colorsubtabla;
            fondoTablaColor = colorsubtabla;
            //NOS DIBUJA LA SUBTABLA
            Dibujarsubtablero(anchoIzq,  anchoDer, altoIzq, altoDer);
        }

        //GRAFICOS DEL JUEGO
        static void Graficos(int x, int y, ConsoleColor colorfondo, int anchoIzq, int anchoDer, int altoIzq, int altoDer,ConsoleColor colorsubtabla)
        {
            //GRAFICOS PANTALLA
            Generales(x,y,colorfondo);
            //GRAFICOS DEL TABLERO
            Tablero( anchoIzq, anchoDer, altoIzq, altoDer,colorsubtabla);
        }

        //BORRADO DE VIDAS CUANDO PIERDES
        static void Borradovidas()
        {
            int pos, linea,espaciodibujo;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            for (pos = 0, linea = 0; pos < 5; pos++, linea += 2)
            {
                Console.SetCursorPosition(pantalla[0] - 19, pantalla[1] - 25 + linea);
                for (espaciodibujo = 0; espaciodibujo < formafigura.Length; espaciodibujo++)
                {
                    Console.Write(" ", formafigura.Length);
                }
            }
        }

        //MOSTRAR EL NUMERO DE VIDAS
        static void Mostrarvidas()
        {
            int pos,linea;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            for (pos = 0,linea=0; pos < vidasjugador; pos++,linea+=2)
            {
                Console.SetCursorPosition(pantalla[0] - 19, pantalla[1] - 25+linea);
                Console.Write("{0}", formafigura);
            }
        }

        //ASIGNAR A VARIABLES GLOBALES LA POSICION DE LA FIGURA
        static void Setfigura(int xfig, int yfig, string formafigurajugar, ConsoleColor colorfigura, ConsoleColor colorletras)
        {
            Serpiente[0] = xfig;
            Serpiente[1] = yfig;
            formafigura=formafigurajugar;
            colorFondoFigura = colorfigura;
            colorLetrasFigura = colorletras;
        }

        //CONTROL REBOTE CONTRA la figura
        static void Rebote_Figura(int[] objeto)
        {
            if (objeto[0] >= Serpiente[0] && objeto[0] < Serpiente[0] + formafigura.Length)
            {
                if (objeto[1] == Serpiente[1] || objeto[1] == Serpiente[1]-1)
                {
                    if (Serpiente[0] + formafigura.Length - objeto[0] > 5)
                        movimiento_pelota = ConsoleKey.I;
                    else
                    {
                        if (Serpiente[0] + formafigura.Length - objeto[0] >3)
                        {
                            movimiento_pelota = ConsoleKey.UpArrow;
                            
                        }
                        else
                            movimiento_pelota = ConsoleKey.D;
                    }
                    
                }

            }
            
        }

        //BORRAR OBJETO SI REBOTA
        static void Borrarobejto(int obs)
        {
            int pos;
            Console.SetCursorPosition(obstaculos[obs, 0], obstaculos[obs, 2]);
            for (pos = 0; pos < obstaculos[obs, 1] - obstaculos[obs, 0]; pos++)
            {
                Console.Write(" ");
            }
        }

        //MUESTRA EL ULTIMO OBJETO ELIMINADO A LA DERECHA
        static void Mostrar_objeto_borrado(int obs,int x, int y)
        {
            obstaculos[obs, 0] = x;
            obstaculos[obs, 1] = obstaculos[obs, 0] + 8;
            obstaculos[obs, 2] = y;
            Mostrarunobstaculo(obs);
        }

        //CONTROLAR SI EL OBJETO HA RECIBIDO TODOS LOS TOQUES NECESARIOS
        static void Controltoques(int obs)
        {
            if (obstaculos[obs, 3] == 0)
            {
                pasarfase--;
                Borrarobejto(obs);
                Mostrar_objeto_borrado(obs,105,40);
            }
        }

        //REBOTE CONTRA UN OBJETO
        static void Rebote_Objeto()
        {
            int obs;
            for (obs = 0; obs < obstaculos_color.Length; obs++)
            {
                if (loc_Bola[0] <= obstaculos[obs, 1] && loc_Bola[0] >= obstaculos[obs, 0] && ((loc_Bola[1] == obstaculos[obs, 2]) || (loc_Bola[1] == obstaculos[obs, 2]-1)))
                {
                    pelota_golpeada++;
                    //Console.Beep(1000, 10);
                    obstaculos[obs, 3] = obstaculos[obs, 3]-1;
                    Controltoques(obs);
                    if (movimiento_pelota == ConsoleKey.UpArrow)
                    {
                        movimiento_pelota = ConsoleKey.DownArrow;
                    }
                    else
                    {
                        if (movimiento_pelota == ConsoleKey.DownArrow)
                        {
                            movimiento_pelota = ConsoleKey.UpArrow;
                        }
                        else
                        {
                            if (movimiento_pelota == ConsoleKey.I)
                            {
                                movimiento_pelota = ConsoleKey.A;
                            }
                            else
                            {
                                if (movimiento_pelota == ConsoleKey.A)
                                {
                                    movimiento_pelota = ConsoleKey.I;
                                }

                                else
                                {
                                    if (movimiento_pelota == ConsoleKey.D)
                                        movimiento_pelota = ConsoleKey.Z;
                                    else
                                        movimiento_pelota = ConsoleKey.D;
                                }
                            }
                        }
                    }
                }
            }
        }

        //REBOTE CONTRA LA PARED
        static void Rebote_Pared(int[] objeto,int tam)
        {
            //REBOTE PARED IZQUIERDA
            if (objeto[0] < subtabla[0, 0]+tam)
            {                
                if (movimiento_pelota == ConsoleKey.I)
                {
                    movimiento_pelota = ConsoleKey.D;
                }
                else
                {
                    movimiento_pelota=ConsoleKey.Z;
                }
            
            }
            //REBOTE PARED DERECHA
            if (objeto[0] > subtabla[0, 1]- tam*2 )
            {
                if (movimiento_pelota == ConsoleKey.D)
                {
                    movimiento_pelota = ConsoleKey.I;
                }
                else
                {
                    movimiento_pelota = ConsoleKey.A;
                }
            }

            //REBOTE PARED ARRIBA
            if (objeto[1] < subtabla[1, 0] + tam)
            {
                if (movimiento_pelota == ConsoleKey.UpArrow)
                {
                    movimiento_pelota = ConsoleKey.DownArrow;
                }
                else
                {
                    if (movimiento_pelota == ConsoleKey.I)
                    {
                        movimiento_pelota = ConsoleKey.A;
                    }
                    else
                    {
                        if (movimiento_pelota == ConsoleKey.D)
                            movimiento_pelota = ConsoleKey.Z;
                    }
                }

            }
            //REBOTE PARED ABAJO
            if (objeto[1] > subtabla[1, 1]- tam*2)
            {
                if (movimiento_pelota == ConsoleKey.DownArrow)
                {
                    movimiento_pelota = ConsoleKey.UpArrow;
                }
                else
                {
                    if (movimiento_pelota == ConsoleKey.A)
                    {
                        movimiento_pelota = ConsoleKey.I;
                    }
                    else
                    {
                        if (movimiento_pelota == ConsoleKey.Z)
                            movimiento_pelota = ConsoleKey.D;
                    }
                }
            }
        }

        //REINICIAR VALORES NORMALES
        static void Reiniciarvalores()
        {
            loc_Bola[0] = 50;
            loc_Bola[1] = 20;
            movimiento_pelota = ConsoleKey.DownArrow;
            Console.SetCursorPosition(Serpiente[0], Serpiente[1]);
            Borradofigura(formafigura.Length);
            Serpiente[0] = 48;
            Serpiente[1] = 39;
            pelota_golpeada = 0;
            velocidad_divisor = 4;
        }

        //PASE LA LINEA AZUL DE ABAJo
        static void Pasarlineaazul()
        {
            if (loc_Bola[1] == subtabla[1, 1] - 2)
            {
                vidasjugador--;
                Reiniciarvalores();
                Thread.Sleep(2000);
                //INCIALIZADO BORRADO VIDAS
                Borradovidas();

            }
        }

        //CONTROLAMOS QUE EL MUÑECO NO SE SALGA DE LA PANTALLA
        static void Control(int[] objeto,int tam)
        {
            if (objeto[0] < subtabla[0, 0])
                objeto[0] = subtabla[0,0];
            if (objeto[0] > subtabla[0, 1]-tam)
                objeto[0] = subtabla[0, 1] - tam;
            if (objeto[1] < subtabla[1, 0])
                objeto[1] = subtabla[1, 0];                 
            if (objeto[1] > subtabla[1, 1] - 1)
                objeto[1] = subtabla[1, 1] - 1;
        }

        //BORRADO DONDE ESTABA ANTES LA FIGURA
        static void Borradofigura(int tam)
        {
            int pos;
            Console.BackgroundColor = fondoTablaColor;
            for (pos = 0; pos < tam; pos++)
            {
                Console.Write(" ");
            }
        }

        //LE ENVIAMOS EL CURSOR PULSADO Y MODIFICA VALORES
        static void Movimiento(int [] objeto,int tam,ConsoleKey dondemueve)
        {

            switch (dondemueve)
            {
                case (ConsoleKey.DownArrow):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[1] = objeto[1] + 1;
                    break;
                case (ConsoleKey.UpArrow):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[1] = objeto[1] - 1;
                    break;
                case (ConsoleKey.RightArrow):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] + 1;
                    break;
                case (ConsoleKey.LeftArrow):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] - 1;
                    break;

                case (ConsoleKey.I):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] - 1;
                    objeto[1] = objeto[1] - 1;
                    break;
                case (ConsoleKey.A):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] - 1;
                    objeto[1] = objeto[1] + 1;
                    break;
                case (ConsoleKey.D):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] + 1;
                    objeto[1] = objeto[1] - 1;
                    break;
                case (ConsoleKey.Z):
                    Console.SetCursorPosition(objeto[0], objeto[1]);
                    Borradofigura(tam);
                    objeto[0] = objeto[0] + 1;
                    objeto[1] = objeto[1] + 1;
                    break;
                default:
                    break;
            }
        }

        //MOVIMIENTO DE LA FIGURA
        static void Mov_Figura()
        {
            Movimiento(Serpiente, formafigura.Length,teclaparamover);
            Control(Serpiente, formafigura.Length);
            Mostrarfigura(Serpiente[0], Serpiente[1], colorFondoFigura, colorLetrasFigura);
            Console.Write("{0}", formafigura);
            teclaparamover = ConsoleKey.T; ;
        }

        //REBOTE Y MOSTRAR MOVIMIENTO PELOTA
        static void ReboteMostrar()
        {
            Movimiento(loc_Bola, 1, movimiento_pelota);
            Rebote_Pared(loc_Bola, 1);
            Rebote_Figura(loc_Bola);
            Mostrarfigura(loc_Bola[0], loc_Bola[1], fondoTablaColor, color_Pelota);
            Console.Write("{0}", forma_Pelota);
        }

        //ACELERAR LA PELOTA POR LOS GOLPES
        static void Acelerar()
        {
            if (pelota_golpeada == 5)
                velocidad_divisor = 3;
            if (pelota_golpeada == 30)
                velocidad_divisor = 2;
            if (pelota_golpeada == 70)
                velocidad_divisor = 1;
        }

        //MOVIMIENTO DE LA PELOTA
        static void Mov_Pelota()
        {
            //REBOTE Y MOSTRAR MOVIMIENTO PELOTA
            if (controlpelota % velocidad_divisor == 0)
                ReboteMostrar();

            //ACELERAR PELOTA CUANDO RECIBA MUCHOS GOLPES
            Acelerar();

            //CONTROLAR SI SE CHOCA CONTRA UN ONJETO
            Rebote_Objeto();

            //CONTROLAR LA VELOCIDAD DE LA PELOTA
            controlpelota++;
            if (controlpelota > 9)
                controlpelota = 0;
        }

        //MOSTRAR DONDE ESTA FIGURA DESPUES DEL MOVIMIENTO
        static void Mostrarfigura(int x,int y,ConsoleColor fondo,ConsoleColor letras)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = fondo;
            Console.ForegroundColor = letras;
        }

        //MODULO CENTRAL DEL JUEGO
        //SE REPITE TODO EL RATO Y NOS PIDE TECLA PARA MOVER
        static void JuegoMoviendose()
        {
            while (pasarfase != 0 && vidasjugador != 0)
            {                
                //MOSTRAR VIDAS
                Mostrarvidas();
                Thread.Sleep(velocidad_Pelota);
                //MOVIMIENTO FIGURA
                Mov_Figura();
                //MOVIMIENTO PELOTA
                Mov_Pelota();
                //EFECTO ELÉCTRICO DEL FONDO
                Dibujar_electrico(ConsoleColor.Blue);
                //POR SI ATRAVIESA LA LINEA AZUL
                Pasarlineaazul();
            }
            pelota_golpeada = 0;
        }

        //MOSTRAR UN OBSTACULOS
        static void Mostrarunobstaculo(int pos)
        {
            int veces;
            Console.BackgroundColor = obstaculos_color[pos];
            Console.SetCursorPosition(obstaculos[pos, 0], obstaculos[pos, 2]);
            for (veces = 0; veces < obstaculos[pos, 1] - obstaculos[pos, 0]; veces++)
            {
                Console.Write(" ");
            }
        }

        //MOSTRAS OBSTACULOS
        static void Mostrarobstaculos()
        {            
            int pos, veces;
            for (pos = 0; pos < obstaculos_color.Length; pos++)
            {
                Console.BackgroundColor = obstaculos_color[pos];
                Console.SetCursorPosition(obstaculos[pos, 0], obstaculos[pos, 2]);
                for (veces = 0; veces < obstaculos[pos, 1] - obstaculos[pos, 0]; veces++)
                {
                    Console.Write(" ");
                }
            }
        }

        //NOS CREA UN HILO PARA JUGAR AL JUEGO Y NOS PIDE TECLA
        static void Inicio()
        {
            controlpelota = 0;
            controlefecto = 0;
            Mostrarobstaculos();
            ConsoleKey movimiento;
            Thread hilo = new Thread(JuegoMoviendose);
            Console.Title = "serpiente";
            hilo.Start();
            while (pasarfase!=0&&vidasjugador!=0)
            {
                do
                {
                    movimiento= Console.ReadKey(true).Key;
                }while(movimiento!=ConsoleKey.LeftArrow && movimiento!=ConsoleKey.RightArrow);
                teclaparamover = movimiento;
            }
            hilo.Abort();
            if (pasarfase == 0)
            {
                Fase2();
                pasarfase = 80;
                Inicio();
            }
        }

        //CARGAR GRAFICOS
        static void CargarGraficos(int x, int y, ConsoleColor colorfondo, int anchoIzq, int anchoDer, int altoIzq, int altoDer, ConsoleColor colorsubtabla)
        {
            //GRAFICOS DE LA PANTALLA Y EL TABLERO
            Graficos(x,y,colorfondo,anchoIzq, anchoDer, altoIzq, altoDer,colorsubtabla);
        }

        //CARGAR JUEGO
        static void CargarFigura(int xfig, int yfig,string formafigurajugar,ConsoleColor colorfigura,ConsoleColor colorletras)
        {
            //ASIGNAR A VARIABLES GLOBALES
            Setfigura(xfig, yfig, formafigurajugar,colorfigura,colorletras);
            //COLOCAR EN PANTALLA
            Console.SetCursorPosition(Serpiente[0], Serpiente[1]);
        }

        //CARGAR PELOTA - LE ASIGNA ESOS VALORES A LAS VARIABLES GLOBALES
        static void CargarPelota(int x,int y,char forma,ConsoleColor color,ConsoleKey direccion,int velod,int divisor_pelota,int veces_golpeada)
        {
            loc_Bola[0] = x;
            loc_Bola[1] = y;
            forma_Pelota = forma;
            color_Pelota = color;
            velocidad_Pelota = velod;
            movimiento_pelota = direccion;
            velocidad_divisor = divisor_pelota;
            pelota_golpeada = veces_golpeada;
        }

        //OTROS DATOS INICIALES
        static void Datosiniciales(int numero_obstaculos)
        {
            obstaculos = new int[numero_obstaculos, 4];
            obstaculos_color = new ConsoleColor[numero_obstaculos];
            pasarfase = numero_obstaculos;
        }

        ////OBSTACULOS CARACTERISTICAS GENERICO
        //static void SetObstaculos(int numobs, int xi, int xd, int y,ConsoleColor color)
        //{
        //    obstaculos[numobs,0]=xi;
        //    obstaculos[numobs, 1] = xd;
        //    obstaculos[numobs,2]=y;
        //    obstaculos_color[numobs] = color;
        //}

        //DIBUJA OBSTACULOS POR FASE
        static void Setobstaculosporfilas(int desdecual,ConsoleColor color1,ConsoleColor color2,int y,int total,int x,int separcionx,int cuantaaguanta)
        {
            int pos;
            for (pos = desdecual; pos < total+desdecual; pos++,x+= separcionx)
            {
                obstaculos[pos, 0] = x;
                obstaculos[pos, 1] = x + 8;
                obstaculos[pos, 2] = y;
                obstaculos[pos, 3] = cuantaaguanta;
                if (pos % 2 == 0)
                    obstaculos_color[pos] = color1;
                else
                    obstaculos_color[pos] = color2;
            }
        }

        //DIBUJAR FASE 1
        static void Fase1()
        {
            int num, fil;
            for (num = 0, fil = 4; num < 80; num += 10, fil += 2)
            {
                Setobstaculosporfilas(num, ConsoleColor.White, ConsoleColor.Red, fil, 10, 7, 9,1);
            }
        }

        //DIBUJAR FASE 2
        static void Fase2()
        {
            int fil,num;
            for (fil = 4, num = 0; num < obstaculos_color.Length; num+=8,fil=fil+2)
            {
                Setobstaculosporfilas(num, ConsoleColor.Blue, ConsoleColor.Blue, fil, 4, 8, 9,1);
                Setobstaculosporfilas(num+4, ConsoleColor.Yellow, ConsoleColor.Yellow, fil, 4, 59, 9,1);
            }
        }

        static void Main(string[] args)
        {
            /* CARGAR GRAFICOS
             * 1.- Ancho de la pantalla
             * 2.- Alto de la pantalla
             * 3.- Color pantalla
             * 3.- Ancho borde izquierdo de subtablero
             * 4.- Ancho borde derecho de subtablero
             * 5.- Alto borde izquierdo de subtablero
             * 6.- Alto borde derecho de subtablero
             * 7.- Color del subtablero
             * 
             * CARGAR FIGURA
             * 1.- Posición horizontal figura
             * 2.- Posicion vertical figura
             * 3.- Cantidad obstaculos
             * 4.- Forma Figura
             * 5.- Color fondo figura
             * 6.- Color letras figura
             *   
             * CARGAR PELOTA
             * 1.- Horizontal posicion pelota
             * 2.- Vertical posicion Pêlota
             * 3.- Letra que forma la pelota
             * 4.- Color de la Pelota
             * 5.- Movimiento de la pelota
             * 6.- Velocidad Pelota
             * 7.- Divisor de velocidad pelota
             * 8.- Veces golpeada la pelota
             * 
             * OTROS DATOS INICIALES
             * 1.- Numero de obstáculos
             * 
             * SET OBSTACULOS GENERICO
             * 1.- Nº Obstáculo
             * 2.- X I
             * 3.- X D
             * 4.- Y
             * 
             * SETOBSTACULOSPORFILAS - NOS LOS INDICA POR FILAS
             * 1.- DESDE QUE OBSTACULO DIBUJA
             * 2.- COLOR DE UN OBSTACULO
             * 3.- COLOR DE OTRO OBSTACULO
             * 4.- ALTURA
             * 5.- CANTIDAD MAX DE OBSTACULOS A SEÑALAR
             * 6.- DESDE QUE COLUMNA EMPIEZA
             * 7.- SEPARACION CON DIBUJAR LA SIGUIENTE FICHA
             * 8.- CANTIDAD DE GOLPES QUE AGUANTAN
             */
            
            CargarGraficos(120, 44, ConsoleColor.Black, 5, 99, 2, 44, ConsoleColor.DarkGreen);
            CargarFigura(46, 39,"     |  |     ",ConsoleColor.White,ConsoleColor.Red);
            CargarPelota(50,25,'o',ConsoleColor.Yellow,ConsoleKey.DownArrow,20,4,0);
            Datosiniciales(80);
            //SetObstaculos(0,5, 13,4,ConsoleColor.White); GENERICO
            Fase1();
            Console.CursorVisible = false;
            Inicio();
        }
    }
}
