using System.Text.RegularExpressions;

Console.WriteLine("Orientação a Objetos".ToUrl());

//Classe estática que possui funções de extensões para o tipo String. Por ser estática e possuir o "this" no parâmetro, poderia ser acessada de qualquer lugar do projeto
public static class StringExtension
{
    public static string ToUrl(this string texto) => Regex.Replace(texto, @"\s+", "-").ToLower();
}