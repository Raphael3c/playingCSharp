// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe a opção desejada");
Console.WriteLine("1 - Inserir novo aluno");
Console.WriteLine("2 - Listar novo aluno");
Console.WriteLine("3 - Calcular média geral");
Console.WriteLine("");

string optionSelected = Console.ReadLine();

try
{
    if (String.IsNullOrEmpty(optionSelected))
    {
        throw new ArgumentException("Opção não selecionada");
    };
}catch(ArgumentException error){
  Console.Write(error);
}

