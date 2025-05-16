public class Pessoa
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public char Genero { get; set; }

    public Pessoa(double peso, double altura, char genero)
    {
        Peso = peso;
        Altura = altura;
        Genero = char.ToUpper(genero);
    }

    public double CalcularIMC()
    {
        return Peso / (Altura * Altura);
    }

    public string ClassificarIMC()
    {
        double imc = CalcularIMC();
        string classificacao;
            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 24.9)
                classificacao = "Peso ideal";
            else if (imc < 24.9)
                classificacao = "Peso ideal";
            else if (imc < 29.9)
                classificacao = "Levemente acima do peso";
            else if (imc < 34.9)
                classificacao = "Obesidade I";
            else if (imc < 39.9)
                classificacao = "Obesidade II";
            else
                classificacao = "Obesidade III";
        return classificacao;
    }
}