using System;
class Program {
    
  static void Main() {
      Console.WriteLine("JOGO DE PEDRA, PAPEL E TESOURA");
      int jogador = jogadaDoJogador();
      if (jogador == 0)
        {
            return; 
        }
        
      string computador = jogadaDoComputador();
      Console.WriteLine("\nJogada do computador: " + computador);
      
      determinarVencedor(jogador, computador);
  }
  static int jogadaDoJogador(){
      
      Console.WriteLine("\nFaça sua jogada: ");
      Console.WriteLine("1- Pedra");
      Console.WriteLine("2- Papel");
      Console.WriteLine("3- Tesoura");
      
      int escolha = int.Parse(Console.ReadLine());
      if(escolha < 1 || escolha > 3){
          Console.WriteLine("Opção inválida!");
          return 0;
      }
      
      return escolha;
      
  }
  static string jogadaDoComputador(){
      
      string jogadaComp = "";
      Random random = new Random();

        int decisao = random.Next(1, 4);
        
        switch(decisao){
            
            case 1:
            jogadaComp = "Pedra";
            break;
            
            case 2:
            jogadaComp = "Papel";
            break;
            
            case 3:
            jogadaComp = "Tesoura";
            break;
            
            default:
            jogadaComp = "";
            break;
            
        }
        return jogadaComp;
  }
  static void determinarVencedor(int jogador, string computador){
      
      string jogadaJogador = "";
        switch (jogador)
        {
            case 1:
                jogadaJogador = "Pedra";
                break;
            case 2:
                jogadaJogador = "Papel";
                break;
            case 3:
                jogadaJogador = "Tesoura";
                break;
            default:
                jogadaJogador = "";
                break;   
                
        }
      Console.WriteLine("Jogada do jogador: " + jogadaJogador);
      
      if(jogadaJogador == computador){
          Console.WriteLine("\nEmpate!!");
      }
      else if((jogadaJogador == "Pedra" && computador == "Tesoura") || (jogadaJogador == "Papel" && computador == "Pedra") || (jogadaJogador == "Tesoura" && computador == "Papel"))
      {
          Console.WriteLine("\nVocê ganhou!!");
      }
      else {
          Console.WriteLine("\nVocê perdeu!!");
      }
  }
  
}