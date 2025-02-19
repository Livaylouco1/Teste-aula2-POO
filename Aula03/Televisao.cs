using System.IO.Pipes;

namespace Aula03;

class Televisao
{

public Televisao(float tamanho)
{
    if(tamanho < TAMANHO_MINIMO||tamanho > TAMANHO_MAXIMO)
    {
        throw new ArgumentOutOfRangeException($"O tamanho ({tamanho}) nao é suportado");
    }
    Tamanho = tamanho;
    Volume = 10;
}

private const float TAMANHO_MINIMO = 22;
private const float TAMANHO_MAXIMO = 80;
private int VOLUME_MAXIMO = 100;
private int VOLUME_MINIMO = 0;
private int VOLUME_PADRAO = 20;

    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

public void AumentarVolume()
{
    if(Volume < VOLUME_MAXIMO)
    {
    Volume++;
    }
    else
    {
     Console.WriteLine("A TV ja esta no volume maximo permitido");
    }
}

public void DiminuirVolume() => Volume--;

}