using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Retangulo
    {
    public double altura { get; set; }
    public double largura { get; set; }

    public Retangulo()
    {
        largura = 0;
        altura = 0;
    }
    public Retangulo(double valor)
    {
        altura = valor;
        largura = valor;
    }
    public Retangulo(double Largura, double Altura)
    {
        altura = Altura;
        largura = Largura;
    }

    public double CalcularArea()
    { 
        return largura * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (largura + altura);
    }

    public void Redimensionar()
    {

    }
    public void Redimensionar(double fator)
    {
      largura *= fator; 
      altura *= fator;
    }

    public void Redimensionar(double novaLargura, double novaAltura)
    {
        largura = novaLargura;
        altura = novaAltura;
    }
}
