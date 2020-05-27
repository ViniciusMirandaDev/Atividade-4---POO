using System;

namespace Aula3___Sprint4___POOLicçao
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado;
        public string  LigarCelular(){
            ligado= true;
            return "Celular Ligado";
        }
        public string DesligarCelular(){
            ligado=false;
            return "Celular desligado";
        }
        public void EnviarMensagem(){
            if(ligado == true){
                Console.WriteLine("Digite sua mensagem:");
                Console.ReadLine();
            }else{
                Console.WriteLine("Ligue o celular!");
            }
        }
    }
}