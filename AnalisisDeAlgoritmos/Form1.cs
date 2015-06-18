using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AnalisisDeAlgoritmos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbDatos.SelectedIndex = 0;
            cbalgoritmo.SelectedIndex = 0;
            cborden.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Stopwatch tiempo = new Stopwatch();
        int[] ListaDesordenada;
        int[] ListaOrdenada;
        int cant;

        private void btgenerar_Click(object sender, EventArgs e)
        {
            if (cbDatos.SelectedIndex != 0 && cborden.SelectedIndex != 0)
            {
                int.TryParse(cbDatos.Text, out cant);
                Random r = new Random();

                if (cborden.Text == "Con Repetición")
                {
                    int[] numeros = new int[cant];

                    for (int i = 0; i < cant; i++)
                    {
                        numeros[i] = r.Next(1000000000);

                    }
                    ListaDesordenada = numeros;
                    mostrarGenerados.Enabled = true;
                    metodo.Enabled = true;
                }
                if (cborden.Text == "Sin Repetición")
                {
                    int[] numeros = new int[cant];
                    int auxiliar = 0;
                    int contador = 0;

                    for (int i = 0; i < cant; i++)
                    {
                        auxiliar = r.Next(1000000000);
                        bool continuar = false;

                        while (!continuar)
                        {
                            for (int j = 0; j <= contador; j++)
                            {
                                if (auxiliar == numeros[j])
                                {
                                    continuar = true;
                                    j = contador;
                                }
                            }

                            if (continuar)
                            {
                                auxiliar = r.Next(1000000000);
                                continuar = false;
                            }
                            else
                            {
                                continuar = true;
                                numeros[contador] = auxiliar;
                                contador++;
                            }
                        }
                    }
                    ListaDesordenada = numeros;
                    mostrarGenerados.Enabled = true;
                    metodo.Enabled = true;
                }
                if (cborden.Text == "Ascendiente")
                {
                    int[] numeros = new int[cant];
                    int n = cant;
                    for (int i = cant - 1; i >= 0; i--)
                    {
                        n = n - 1;
                        numeros[i] = n;
                    }

                    ListaDesordenada = numeros;
                    mostrarGenerados.Enabled = true;
                    metodo.Enabled = true;
                }
                if (cborden.Text == "Descendiente")
                {
                    int[] numeros = new int[cant];
                    int n = cant;
                    for (int i = 0; i < cant; i++)
                    {
                        n = n - 1;
                        numeros[i] = n;
                    }

                    ListaDesordenada = numeros;
                    mostrarGenerados.Enabled = true;
                    metodo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Debes Completar Ambos Campos");
            }
        }

        private void mostrarGenerados_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaDesordenada.Length; i++)
            {
                Generados.Items.Add(ListaDesordenada[i]);
            }
            mostrarGenerados.Enabled = false;
        }

        private void btordenar_Click(object sender, EventArgs e)
        {
                            if (cbalgoritmo.Text == "Burbuja")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new Burbuja().Burbuja1(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "Burbuja 2")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new Burbuja_2().Burbuja2(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "InsertSort")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new Insercion().Insercionn(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "Seleccion")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new Seleccion().Seleccionn(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "ShellSort")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new ShellSort().shellSort(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "QuickSort")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    tiempo.Start();
                    ListaOrdenada = new QuickSort().Quicksort(ListaDesordenada, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
                if (cbalgoritmo.Text == "MergeSort")
                {
                    int prim = 0;
                    int ult = cant - 1;
                    int[] b = new int[cant];
                    tiempo.Start();
                    ListaOrdenada = new Mezcla().Mezclar(ListaDesordenada, b, prim, ult);
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                    tiempo.Stop();
                    TimeSpan ts = tiempo.Elapsed;
                    ejecucion.Text = tiempo.ElapsedMilliseconds.ToString();
                }
            
            mostrarOrdenados.Enabled = true;

        }

        private void mostrarOrdenados_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaOrdenada.Length; i++)
            {
                Ordenados.Items.Add(ListaOrdenada[i].ToString());
            }
            mostrarOrdenados.Enabled = false;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cborden.SelectedIndex = 0;
            cbDatos.SelectedIndex = 0;
            cbalgoritmo.SelectedIndex = 0;
            Ordenados.Items.Clear();
            Generados.Items.Clear();
            ejecucion.Text = "";
            mostrarGenerados.Enabled = true;
            mostrarOrdenados.Enabled = true;
        }

        private void Solo_Click(object sender, EventArgs e)
        {
            int[] a = new int[] { 10, 50, 100, 500, 1000, 5000, 10000, 25000, 50000, 75000, 100000};
        }



    }
}
