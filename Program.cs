// Criem uma Classe Celular
// - Cor, Modelo, Tamanho, Ligado ou Nao (bool)
// - Metodos - ligar,desligar, fazer ligacao, enviar mensagem
// - Os metodos so podem ser executados se o celular estiver ligado 

using ProjetoCelular;

Celular Caracter = new Celular();

Caracter.Cor = "Branco";
Caracter.Modelo = "iPhone";
Caracter.Tamanho = "11cm";
Caracter.Power = true;

Caracter.BotaoPower();