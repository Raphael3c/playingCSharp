using DigitalInnovationOne.Models;
// See https://aka.ms/new-console-template for more information
string optionSelected = selectOptionMainMenu();
string selectOptionMainMenu(){
  Console.WriteLine("Informe a opção desejada");
  Console.WriteLine("1 - Inserir novo aluno");
  Console.WriteLine("2 - Listar alunos");
  Console.WriteLine("3 - Calcular média geral");
  Console.WriteLine("");

  string optionSelected = Console.ReadLine();

  return optionSelected;
}

while (true)
{
  try
  { 
    switch (optionSelected)
    {
      case "1":
        while (true){
          Console.WriteLine("Informe o nome do aluno:");
          string nome = Console.ReadLine();

          Console.WriteLine("Informe a idade do aluno:");
          string idade = Console.ReadLine();

          Console.WriteLine("Informe a serie do aluno:");
          string serie = Console.ReadLine();

          Console.WriteLine("Informe a data de nascimento do aluno:");
          string datanasc = Console.ReadLine();
          Aluno alunoCriado = new Aluno(nome, idade, serie, datanasc);
          Console.WriteLine(alunoCriado.ToString());
          optionSelected = selectOptionMainMenu();
          break;
        };
        break;
      default:
        throw new ArgumentException("Opção não selecionada");
    }
  }catch (ArgumentException error)
  {   
    Console.Write(error);
  }finally{
    optionSelected = selectOptionMainMenu();
  };
}

