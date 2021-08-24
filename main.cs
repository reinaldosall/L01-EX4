using System;

class MainClass {
  public static void Main (string[] args) {
    /*
    4 - Elabore um programa em Csharp que leia o tempo de duração 
    de um evento em um show e expressa 
    em segundos e mostre-o expresso em horas, minutos e segundos.
    */

    Console.WriteLine ("Digite a duração do evento em Segundos");

    int segundosTotal = int.Parse(Console.ReadLine());

    int minutosTotal = segundosTotal /60;
    int horas = minutosTotal /60;
    int minutos = minutosTotal % 60;
    int segundos = segundosTotal % 60;

    Console.WriteLine($"O evento de {segundosTotal} segundos, durou {horas}:{minutos}:{segundos}");
    
  }
}