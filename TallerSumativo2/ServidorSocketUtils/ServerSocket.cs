﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TallerSumativo2.ServidorSocketUtils
{
    public class ServerSocket
    {
        private int puerto;
        private Socket servidor;

        public ServerSocket(int puerto)
        {
            this.puerto = puerto;
        }

        //iniciar la coneccion del servidor, tomando posesion del puerto
        //True en caso de coneccion exitosa, false en caso contrario

        public bool Iniciar()
        {
            try
            {
                this.servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.servidor.Bind(new IPEndPoint(IPAddress.Any, this.puerto));
                this.servidor.Listen(10);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public void Cerrar()
        {
            try
            {
                this.servidor.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public Socket ObtenerCliente()
        {
            return this.servidor.Accept();
        }
    }
}
