/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial 
• Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque 
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for 
alto o bastante. 
• Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O 
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em 
porcentagem e o nível do jogador. As condições para realizar o ataque especial são: 
• Mana maior que 30. 
• Vida do inimigo menor que 50%. 
• Nível do jogador maior que 5. 
@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        int mana, vida_inimigo, nivel_jogador;

        System.Console.WriteLine("Quanto de mana você possui?");
        int.TryParse(Console.ReadLine(), out mana);
        System.Console.WriteLine("Quanto de vida possui o inimigo?(coloque porcentagem)");
        int.TryParse(Console.ReadLine(), out vida_inimigo);
        System.Console.WriteLine("Qual seu nivel?");
        int.TryParse(Console.ReadLine(), out nivel_jogador);

        if (mana > 30 && vida_inimigo < 50 && nivel_jogador > 5)
        {
            System.Console.WriteLine("Ataque especial realizado");
        }
        else if (mana <= 30 && vida_inimigo < 50 && nivel_jogador > 5)
        {
            System.Console.WriteLine("Mana insuficiente");
        }
        else if (mana > 30 && vida_inimigo >= 50 && nivel_jogador > 5)
        {
            System.Console.WriteLine("Vida do inimigo muito alta");
        }
        else if (mana > 30 && vida_inimigo < 50 && nivel_jogador <= 5)
        {
            System.Console.WriteLine("Nivel insuficiente");
        }
        else
        {
            System.Console.WriteLine("Falha geral");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}