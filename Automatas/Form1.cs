using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automatas
{
    public partial class Form1 : Form
    {
        int q;
        int n;
        protected Conexiones[] con;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(TxtAutomata.Text);
                q = 0;
                string[] lenguaje= new string[10];
                string lenguaje1 = Convert.ToString(TxtLenguaje.Text);
                string conex = Convert.ToString(txtConexiones.Text);
                //Colocar el lenguaje
                foreach (char caracter in lenguaje1)
                {
                    if (String.Compare(caracter.ToString(), ",") == 0)
                    {
                        q++;
                    }
                    else
                    {
                        lenguaje[q] =lenguaje[q]+ caracter.ToString();
                    }
                }

                foreach (char aa in conex)
                {
                    if (String.Compare(aa.ToString(),">")==0)
                    {
                        n++;
                    }
                }
                con = new Conexiones[n];
                for (int i = 0; i < n; i++)
                {
                    con[i] = new Conexiones();
                }
                bool banderacoma=true;
                bool banderamayor = true;
                n = 0;
                foreach (char bb in conex)
                {
                    if (String.Compare(bb.ToString(),";")==0)
                    {
                        n++;
                    }
                    else
                    {
                        if (String.Compare(bb.ToString(), ">") != 0)
                        {
                            if (banderamayor)
                            {
                                if (String.Compare(bb.ToString(), ",") != 0)
                                {
                                    if (banderacoma)
                                    {
                                        con[n].Base = con[n].Base + Convert.ToString(bb);
                                    }
                                    else
                                    {
                                        con[n].Len = con[n].Len + Convert.ToString(bb);
                                    }
                                }
                                else
                                {
                                    banderacoma = false;
                                }
                            }
                            else
                            {
                                con[n].Base2 = con[n].Base2 + Convert.ToString(bb);
                            }
                        }
                        else
                        {
                            banderamayor = false; 
                        }
                    }
                }
                Prueba.Text = Convert.ToString(con[0].Base2);
                Grafica grafica = new Grafica(c,n);
                grafica.lenguaje = lenguaje;
                for (int i = 0; i < c; i++)
                {
                    grafica.ceonex[i].Base = con[i].Base;
                    grafica.ceonex[i].Base2 = con[i].Base2;
                    grafica.ceonex[i].Len = con[i].Len;
                }
                grafica.Show();
            }
            catch (Exception )
            {
                MessageBox.Show("valor incorrecto", "error");
            }
        }
    }
}
