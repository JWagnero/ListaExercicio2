/*-------------------------------------------------------------------
Questão 3: Loja de Poções
•   Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que 
    aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas, 
    Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há 
    um desconto aplicável.
•   Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo 
    de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total 
    das poções, aplicando o desconto correspondente:
•   Guerreiro recebe 10% de desconto na compra de poções de Vida.
•   Mago recebe 15% de desconto na compra de poções de Mana.
•   Paladino recebe 20% de desconto na compra de poções de Resistência.
•   Exiba o preço total com e sem desconto.

@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) 
    {   
        int classe, pocao, qtnd_compra;
        double desconto;

        System.Console.WriteLine("ESCOLHA UMA CLASSE");

        System.Console.WriteLine("1-Guerriro  2-Arqueiro 3-Mago");
        int.TryParse(Console.ReadLine(), out classe);

        switch (classe)
        {
            case 1:
                desconto = 0.1;
                break;
            default:
                break;
        }
        

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}