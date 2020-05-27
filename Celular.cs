using System;

namespace Aula3___Sprint4___POOLicçao
{
    public class Celular
    {
        //Atributos
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;

        //Métodos

        /// <summary>
        /// Ligar o celular
        /// </summary>
        /// <returns>Texto de celular ligado</returns>
        public string Ligar(){
            ligado = true;
            return "Celular ligando";
        }

        /// <summary>
        /// Desligar o celular
        /// </summary>
        /// <returns>Texto de celular desligado</returns>
        public string Desligar(){
            ligado=false;
            return "Celular desligado";
        }

        /// <summary>
        /// Realiza a ligação pelo celular
        /// </summary>
        /// <returns>Texto de ligação efetuada</returns>
        public string FazerLigacao(){
            return "Realizando ligação";
        }

        
        public string EnviarMensagem(){
            return "Enviando mensagem";
        }

    }


    
}