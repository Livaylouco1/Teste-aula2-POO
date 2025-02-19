namespace Aula03;

class Televisao
{

public Televisao(float tamanho)
{
    Tamanho = tamanho;
}




    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
}