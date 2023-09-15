using System;

public abstract class Veiculo
{
    private int assentos;
    public int Assentos { 
        get { return assentos; } 
        set
            {
                if(this is Carro && (value < 2 || value > 5) || 
                this is Onibus && (value < 10 || value > 44) ||
                this is Caminhao && (value < 2 || value > 5))
                {
                    throw new ArgumentException ("Número de Assentos inválido", nameof(Assentos));
                }
                assentos = value;
            } 
        }
    public string Placa  { get; set; }
    public int Ano { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(int assentos, string placa, int ano, string marca, string modelo)
    {
        Assentos = assentos;
        Placa = placa;
        Ano = ano;
        Marca = marca;
        Modelo = modelo;
    }

    public override string ToString()
    {
        return $"Assentos: {Assentos}\nPlaca: {Placa}\nAno: {Ano}\nMarca: {Marca}\nModelo: {Modelo}.";
    }

}

public class Carro : Veiculo
{
    public Carro(int assentos, string placa, int ano, string marca, string modelo) : base (assentos, placa, ano, marca, modelo){}
}

public class Onibus : Veiculo
{
    public Onibus(int assentos, string placa, int ano, string marca, string modelo) : base (assentos, placa, ano, marca, modelo){}
}

public class Caminhao : Veiculo
{
    private int eixos;
    public int Eixos { 
        get {return eixos; }
        private set
            {
                if (value < 2 || value > 10)
                {
                    throw new ArgumentException("O número de eixos não pode ser menor do que dois e maior do que 10", nameof(Eixos));
                }
                eixos = value;
            }
        }

    public Caminhao(int assentos, string placa, int ano, string marca, string modelo, int eixos) : base (assentos, placa, ano, marca, modelo)
    {
        Eixos = eixos;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nEixos: {Eixos}";
    }
}

class Program
{
    public static void Main (string[] args)
    {
        Veiculo carro = new Carro(12, "ABC123", 2020, "Ford", "Focus");
        Veiculo onibus = new Onibus(20, "XYZ456", 2018, "Mercedes-Benz", "Tourismo");
        Veiculo caminhao = new Caminhao(2, "DEF789", 2019, "Volvo", "FH16", 8);

        Console.WriteLine("Dados do Carro:");
        Console.WriteLine(carro);

        Console.WriteLine("\nDados do Ônibus:");
        Console.WriteLine(onibus);

        Console.WriteLine("\nDados do Caminhão:");
        Console.WriteLine(caminhao);
    }
}