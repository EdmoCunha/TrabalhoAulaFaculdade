using System.Formats.Asn1;

public class Retangulo{
    double largura;
    double altura;

    public Retangulo(){

        largura = 0;
        altura = 0;
    }
    public Retangulo(double valor){
        altura = valor;
        largura = valor;
    }
    public Retangulo(double largura, double altura){
        this.altura = altura;
        this.largura = largura;
    }
    public double CalcularArea(){
        return altura * largura;

    }
    public double CalcularPerimetro(){
        return (largura + altura) * 2;
    }
    public void Redimensionar(){

    }
    public void Redimensionar(double fator){
        altura *= fator;
        largura *= fator;
    }

    public void Redimensionar(double altura, double largura){
        this.altura = altura;
        this.largura = largura;

    }
    

}
