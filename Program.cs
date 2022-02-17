﻿using DigitalInnovationOne.Models;

int baseId = 428199;

Dictionary<int, Aluno> banco = new Dictionary<int, Aluno>();
// See https://aka.ms/new-console-template for more information
string optionSelected = selectOptionMainMenu();

try
{ 
  switch (optionSelected)
  {
    case "1":
      while (true){
        Console.Clear();
        Console.WriteLine("Informe o nome do aluno:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe a idade do aluno:");
        string idade = Console.ReadLine();

        Console.WriteLine("Informe a serie do aluno:");
        string serie = Console.ReadLine();

        Console.WriteLine("Informe a data de nascimento do aluno:");
        string datanasc = Console.ReadLine();

        baseId++;

        int matricula = baseId;
        Aluno alunoCriado = new Aluno(matricula, nome, idade, serie, datanasc);
        banco.Add(matricula, alunoCriado);

        Console.WriteLine("\nAluno criado com sucesso! Dados inseridos no banco:");
        System.Console.WriteLine(alunoCriado.ToString()+"\n");
        Console.WriteLine("Cadastrar outro Aluno?");
        Console.WriteLine("Para sim - Digite s/S");
        Console.WriteLine("Para não - Digite n/N");
        char escolha = Char.Parse(Console.ReadLine());

        if((char.ToLower(escolha) == 's')){
          continue;
        };
        break;
      };
      break;
      case "2":
        foreach (KeyValuePair<int, Aluno> Aluno in banco){
          System.Console.WriteLine(Aluno.ToString());
        }
      break;
    default:
      throw new ArgumentException("Opção não selecionada");
  }
}catch (ArgumentException error)
{   
  Console.Write(error);
}finally{
  Console.Clear();
  optionSelected = selectOptionMainMenu();
};

string selectOptionMainMenu(){
  Console.WriteLine("Informe a opção desejada");
  Console.WriteLine("1 - Inserir novo aluno");
  Console.WriteLine("2 - Listar alunos");
  Console.WriteLine("3 - Calcular média geral");
  Console.WriteLine("");

  string optionSelected = Console.ReadLine();

  return optionSelected;
}