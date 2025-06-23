using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

public class Veiculo 
{
    public string Placa {  get; set; }
    private double velocidadeAtual;

    public Veiculo(string placa) {
        Placa = placa;
    }

    public void AtualizarVelocidade (double novaVelocidade) {

        velocidadeAtual = novaVelocidade;
    }

    public double VelocidadeAtual {
        get {
            return velocidadeAtual;
        }
    }

    public void ExibirSaida() {

        Console.WriteLine($"Veiculo: {Placa}");
        Console.WriteLine($"Velocidade: {velocidadeAtual} KM/H");
    }
}