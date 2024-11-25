﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/* COMANDO LOOCK, MONITORES, SEMAFOROS*/
namespace DemoConcurrencia
{
    public partial class FrmBloqueos : Form
    {
        private int contador = 0;
        private object bloqueo = new object();
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public FrmBloqueos()
        {
            InitializeComponent();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                semaforo.Wait();

                lock (bloqueo)
                {
                    contador++;
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)delegate
                    {
                        lblContador.Text = contador.ToString();
                    });

                    Monitor.Pulse(bloqueo);

                }
                semaforo.Release(); 

            });
        }

        private void BtnDisminuir_Click_1(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (bloqueo)
                {
                    while (contador <= 0)
                    {
                        ActualizarResultado("Esperando Fondos..."); 
                        Monitor.Wait(bloqueo);
                    }
                
                    if (contador > 0)
                    {
                        contador--;
                        Thread.Sleep(1000);

                        this.Invoke((MethodInvoker)delegate
                        {
                            lblContador.Text = contador.ToString();
                        });

                    }

                    ActualizarResultado("Procesando...");
                }
            });
        }
        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }

            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }
    }
}
