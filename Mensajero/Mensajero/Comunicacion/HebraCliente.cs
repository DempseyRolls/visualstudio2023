using MensajeroModel.DAL;
using MensajeroModel.DTO;
using ServidorSocketUtils;

namespace Mensajero.Comunicacion
{
    public class HebraCliente
    {
        private ClienteCom clienteCom;
        private IMensajesDAL mensajesDAL = MensajeDALArchivos.GetInstancia();

        public HebraCliente(ClienteCom clienteCom)
        {
            this.clienteCom = clienteCom;
        }

        public void Ejecutar()
        {
            //ahora traemos el codigo que atiende al cliente
            clienteCom.Escribir("ingrese Nombre: ");
            string nombre = clienteCom.Leer();
            clienteCom.Escribir("ingrese Texto: ");
            string texto = clienteCom.Leer();
            Mensaje mensaje = new Mensaje()
            {
                Nombre = nombre,
                Texto = texto,
                Tipo = "TCP"
            };

            lock (mensajesDAL)
            {
                mensajesDAL.AgregarMensaje(mensaje);
                clienteCom.Desconectar();
            }

        }
    }
}
