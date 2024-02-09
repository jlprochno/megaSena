namespace megaSena;


class Program
    {
        static int[] generatorDrawnNumbers(){
            Random geradorAleatorio = new Random();
            int[] drawnNumbers = new int[6];

            int i = 0;
            while( i < 6 ){
                int valorAleatorio = geradorAleatorio.Next(1,61);
                bool existe = false;
                foreach(int valorAdicionado in drawnNumbers ){
                    if( valorAdicionado == valorAleatorio ){
                        existe = true;
                    }
                }
                if(!existe){
                    drawnNumbers[i] = valorAleatorio;
                    i++;
                }
            }       

            return drawnNumbers;
        }

        static int[] generatorBetNumbers(){
            //Request for bet numbers
            int [] betNumbers = new int[6];
            int i = 0;
            while( i < 6 ){            
                Console.WriteLine($"Por gentileza, digite um número para apostar: ");
                int valorDigitado = Convert.ToInt32(Console.ReadLine());
                bool valido = true;

                if( valorDigitado >= 1 && valorDigitado <= 60){
                    foreach(int valor in betNumbers ){
                        if( valor == valorDigitado ){
                            valido = false;
                        }
                    }
                }
                else{
                    valido = false;
                }

                if(valido){
                    betNumbers[i] = valorDigitado;
                    i++;
                }
            }       

            return betNumbers;
        }
        
        static public void Main(string[] args)
        {
  
            int [] drawnNumbers = generatorDrawnNumbers();        
            
            int [] betNumbers = generatorBetNumbers();
            
            int correctNumbers = betAnalysis(betNumbers, drawnNumbers);    
                

            //Printout of results
            Console.WriteLine("\nNúmeros vencedores: ");
            for( int i = 0; i < drawnNumbers.Length; i++){
                Console.WriteLine($"{drawnNumbers[i]}");
            }

            Console.WriteLine("\nNúmeros apostados:");
            for(int i = 0; i < betNumbers.Length; i++){
                Console.WriteLine($"{betNumbers[i]}");
            }

            System.Console.WriteLine("Qtd acertos " + correctNumbers);
            if(correctNumbers == drawnNumbers.Length){
                Console.WriteLine("\nParabéns! Você ganhou!");
            }
            else{
                Console.WriteLine("\nQue pena! Tente novamente!");
            }
        }

        static int betAnalysis(int[]betNumbers, int[]drawnNumbers){
            int hits = 0;
            foreach (int sorteado in drawnNumbers){
                foreach (int apostado in betNumbers){
                    if( sorteado == apostado ){
                        hits++;
                    }
                }
            }
            return hits;
        }
    }