using System;
class Program {
    
  static void Main() {
      Console.WriteLine("JOGO DE PEDRA, PAPEL E TESOURA");
      string jogador = jogadaDoJogador();
      
      if (jogador == "")
        {
            return; 
        }
        
      Console.WriteLine("\nJogada do jogador: " + jogador);
      string computador = jogadaDoComputador();
      Console.WriteLine("Jogada do computador: " + computador);
      
      determinarVencedor(jogador, computador);
  }
  static string jogadaDoJogador(){
      
      Console.WriteLine("\nFaça sua jogada: ");
      Console.WriteLine("1- Pedra");
      Console.WriteLine("2- Papel");
      Console.WriteLine("3- Tesoura");
      int escolha = int.Parse(Console.ReadLine());
      
      if(escolha < 1 || escolha > 3){
          Console.WriteLine("Opção inválida!");
          return "";
      }
      
      string[] opcoes = {"","Pedra","Papel","Tesoura"};
      string jogada_Jogador = opcoes[escolha];
      
      return jogada_Jogador;
      
  }
  static string jogadaDoComputador(){
      
      Random random = new Random();

        int decisao = random.Next(0, 3);
        string[] opcoes = {"Pedra","Papel","Tesoura"};
        string jogada_Computador = opcoes[decisao];
        
        return jogada_Computador;
  }
  static void determinarVencedor(string jogador, string computador){
     
      
      if(jogador == computador){  
          Console.WriteLine("\nEmpate!!");
      }
      else if((jogador == "Pedra" && computador == "Tesoura") || (jogador == "Papel" && computador == "Pedra") || (jogador == "Tesoura" && computador == "Papel"))
      {
          Console.WriteLine("\nVocê ganhou!!");
      }
      else {
          Console.WriteLine("\nVocê perdeu!!");
      }
  }
  
}