/*-------------------------------------------------------------------
Questão 5: Resgate no Labirinto 
•   Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua 
    em frente para resgatar um aliado ou recua, considerando a vida restante, o número de 
    armadilhas conhecidas no caminho e a distância do aliado. 
•   Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de 
    armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir 
    se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes 
    condições: 
•   Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente. 
•   Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for 
    menor que 10m, tentar resgate rápido. 
•   Caso contrário, recuar.

@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int vida, armadilhas_conhecidas, distancia_aliado;

        System.Console.WriteLine("Quanto de vida você possui?(coloque em porcentagem)");
        int.TryParse(Console.ReadLine(), out vida);
        System.Console.WriteLine("Quantas armadilhas você conhece?");
        int.TryParse(Console.ReadLine(), out armadilhas_conhecidas);
        System.Console.WriteLine("Qual a distância que você está do aliado?(coloque em metros)" );
        int.TryParse(Console.ReadLine(), out distancia_aliado);

        if(vida > 50 && armadilhas_conhecidas < 3){
            System.Console.WriteLine("Seguir em frente");
        }
        else if(vida < 50 && armadilhas_conhecidas < 2 && distancia_aliado < 10){
            System.Console.WriteLine("Resgate Rapido");
        }
        else{
            System.Console.WriteLine("Recuar");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}