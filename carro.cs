namespace megaSena;

class Carro
{
    public string cor{get;set;}
    public string marca{get;set;}
    public string modelo{get;set;}
    public int anoFabricação{get;set;}
    
    private string getNome(){
        return this.nome;
    }

  public void Acelerar()
  {
    System.Console.WriteLine($" o {modelo} está acelerando ");
  }

  public void Freiar()
  {
    System.Console.WriteLine($" o {modelo} está freiando ");
  }

  public void Ligar()
  {
    System.Console.WriteLine($" o {modelo} está ligado ");
  }
}