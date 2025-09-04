namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { } // O construtor sem parâmetros (Pessoa()) cria uma pessoa sem definir nome ou sobrenome.

    public Pessoa(string nome) // Define apenas o nome da pessoa
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}
