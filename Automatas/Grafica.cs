using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace Automatas
{
    public partial class Grafica : Form
    {
        public Conexiones[] ceonex;
        public string[] lenguaje = new string[10];
        LetrasyCoordenadas[] listaDeLetras;
        int z;
        int y;
        int cantidad,b;
        public Grafica(int c,int a,int q)
        {
            cantidad = c;
            
            listaDeLetras = new LetrasyCoordenadas[c];
            for (int i = 0; i < c; i++)
            {
                listaDeLetras[i] = new LetrasyCoordenadas();
            }
            ceonex = new Conexiones[a];
            for (int i = 0; i < a; i++)
            {
                ceonex[i] = new Conexiones();
            }
            
        }

        private void Grafica_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Graphics grafica = base.CreateGraphics();
            string lenguaje = "lenguaje= {";
            string k = "k= {";
            Pen lapiz = new Pen(Color.Black);
            Pen lapizlinea = new Pen(Color.Red);
            Pen lapizline2 = new Pen(Color.Blue);
            SolidBrush pincelsolido = new SolidBrush(Color.Black);
            SolidBrush pincelsolido1 = new SolidBrush(Color.Blue);
            SolidBrush pincelsolido2 = new SolidBrush(Color.Red);
            FontStyle estilo = FontStyle.Bold;
            Font arial = new Font("Arial", 12, estilo);
            Font arial2 = new Font("Arial", 18, estilo);
            grafica.Clear(Color.White);
            float sizew = 60;
            float sizeh = 40;
            float posx = 25;
            float posy = 30;
            float espaciado = 50;
            float posxl;
            float posx2;
            float posy1;
            
            for (int i = 0; i < cantidad; i++)
            {
                //Circulos
                grafica.DrawEllipse(lapiz, posx, posy, sizew, sizeh);
                //Letras Negras
                grafica.DrawString((Convert.ToString(letras[i])), arial2, pincelsolido, (posx + 15), (posy + 5));
                k = k + "\"" + Convert.ToString(letras[i]) + "\"" + ",";
                //
                listaDeLetras[i].letra = letras[i];
                listaDeLetras[i].cooX = posx;
                listaDeLetras[i].cooY = posy;
                if (i == 0)
                {
                    z = 2;
                    y = 1;
                }
                else
                {

                    z = z + 2;
                    y = y + 2;
                }
                //
                if (posx >= 600)
                {
                    b++;
                    posx2 = posx + 25 + (sizew / 2);
                    posy1 = posy + 10;
                    
                    if ((b == 1))
                    {
                        posy = posy + sizeh + espaciado;
                        posx = 45;
                    }
                    else
                    {
                        if ((b % 2) == 0)
                        {
                            posy = posy + sizeh + espaciado;
                            posx = 65;
                        }
                    }
                }
                else
                {
                    if (i < (cantidad - 1))
                    {
                        posxl = posx + sizew + (sizew / 2);
                        posx2 = posx + 25 + (sizew / 2);
                        posy1 = posy + 20;
                        
                    }
                    posx = posx + sizew + 25;
                    posy++;


                }
            }
            grafica.Dispose();
            k = k + "}";
            lenguaje = lenguaje + "}";
            
            
        }

    
} 

        }
    
