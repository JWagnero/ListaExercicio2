/*-------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
• Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma 
  batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos 
  derrotados, a duração da batalha e se o jogador sofreu danos crítico.
• Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve 
  receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador 
  sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma:
• 10 pontos para cada inimigo derrotado;
• Subtraia 10 pontos se a batalha durar mais de 5 minutos;
• Subtraia 10 pontos se o jogador sofreu dano crítico;

@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int inimigos_derrotados = 0 , duracao, pontuacao;
        bool danocritico, recebeuDano = false;

        System.Console.WriteLine("Quantos inimigos derrotados?");
        int.TryParse(Console.ReadLine() , out inimigos_derrotados);

        pontuacao = inimigos_derrotados * 10;

        System.Console.WriteLine("Qual foi a duração da batalha?");
        int.TryParse(Console.ReadLine() , out duracao);

        if(duracao>5)
        {
            duracao =- 10 ;
        }

        System.Console.WriteLine("Sofreu danos criticos? 1- SIM 2-NAO");
        bool.TryParse(Console.ReadLine() , out danocritico);

      
        if(danocritico == true){
            pontuacao =- 10;
        }

        if(recebeuDano == true)
        {
            pontuacao =- 10;
        }
        if(pontuacao > 100)
        {
            pontuacao = 100;
        }

        System.Console.WriteLine($"Sua pontuação total é de: {pontuacao}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}