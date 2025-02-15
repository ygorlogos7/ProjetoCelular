using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        public void Ligar()
        {
            Console.WriteLine("Ligando o Celular...");
            Ligado= true;
        }
        public void Desligar()
        {
            Console.WriteLine("Celular Desligado");
            Ligado= false; 
        }
   
        public void BotaoFazerLigacao()
        {
            if (Ligado)
            {
                Console.WriteLine("Chamando...");
            }
            else
            {
                Console.WriteLine("Celular Desligado");
            }
        }
        public void BotaoEnviarMensagem()
        {
            Console.WriteLine("Enviando SMS...");
        }
    }
}
