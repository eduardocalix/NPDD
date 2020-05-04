using System;


namespace Restaurante.Clases
{
    class Excepcion : Exception
    {
        //Se encarga de reedireccionar las Excepciones producidas en el sistema y muestra donde fueron causadas
        public Excepcion(string msgError, Exception e, string lugar)
       : base(msgError, e)
        {
            this.Source = lugar;
        }
        public Excepcion(string msgError, Exception e)
            : base(msgError, e)
        {
        }
    }
}
