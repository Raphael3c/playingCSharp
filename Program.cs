using DigitalInnovationOne.Models;

int baseId = 428199;

Dictionary<int, Aluno> banco = new Dictionary<int, Aluno>();
// See https://aka.ms/new-console-template for more information

while (true)
{
  try
  {
    Console.WriteLine("Informe a opção desejada");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Editar aluno");
    Console.WriteLine("4 - Calcular média geral");
    string optionSelected = Console.ReadLine();
    Console.WriteLine("");
    switch (optionSelected)
    {
      case "1":
        while (true)
        {
          Console.Clear();
          criarAluno();
          Console.WriteLine("Cadastrar outro Aluno?");
          Console.WriteLine("Para sim - Digite s/S");
          Console.WriteLine("Para não - Digite n/N");
          char escolha = Char.Parse(Console.ReadLine());
          if ((char.ToLower(escolha) == 's'))
          {
            continue;
          };
          break;
        };
      break;

      case "2":
        checkBd();
        System.Console.WriteLine("1 - Listar todos alunos");
        System.Console.WriteLine("2 - Listar somente um aluno");
        optionSelected = Console.ReadLine(); 

        switch(optionSelected){
          case "1":
            listarTodosAlunos();
          break;
          case "2":
            listarUmAluno();
            break;
          default:
            throw new ArgumentException("Opção não selecionada");
        };

      break;

      case "3":
        checkBd();
        editarAluno();
      break;

      default:
        throw new ArgumentException("Opção não selecionada");
    }
  }
  catch (Exception error)
  {
    Console.Write(error);
  }
  finally
  {
    Console.ReadLine();
    Console.Clear();
  };
}

void checkBd(){
  if(banco.Count == 0){
    throw new ApplicationException("Não há usuários no banco");
  };
};

void listarTodosAlunos(){
   foreach(KeyValuePair<int, Aluno> AlunoX in banco)
  {
    System.Console.WriteLine("===========================================");
    System.Console.WriteLine(AlunoX.Value.ToString());
    System.Console.WriteLine("===========================================");
  };
};

void criarAluno(){
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
  System.Console.WriteLine(alunoCriado.ToString() + "\n");
};

void listarUmAluno(){
  System.Console.WriteLine("Digite a matricula do aluno:");

  int matricula = int.Parse(Console.ReadLine());

  try{
    Aluno teste = banco.GetValueOrDefault(matricula);
    System.Console.WriteLine(teste.ToString());
  }catch(Exception){
    throw new ArgumentException("Matricula não encontrada.");
  };
};

void editarAluno(){
  System.Console.WriteLine("Digite a matricula do aluno:");
  int matricula = int.Parse(Console.ReadLine());
  try{
    Aluno teste = banco.GetValueOrDefault(matricula);
    System.Console.WriteLine("Aluno encontrado:");
    System.Console.WriteLine(teste.ToString());
    System.Console.WriteLine("=================");
    while(true){
      System.Console.WriteLine("Digite o valor a ser alterado:");
      System.Console.WriteLine("1 - Nome");
      System.Console.WriteLine("2 - Idade");
      System.Console.WriteLine("3 - serie");
      System.Console.WriteLine("4 - Data de nascimento");
      System.Console.WriteLine("5 - Cancelar");
      string opcao = System.Console.ReadLine();

      switch(opcao){
        case "1":
          System.Console.WriteLine("Digite o novo nome:");
          string nome = System.Console.ReadLine();
          teste._nome = nome;
        break;

        case "2":
          System.Console.WriteLine("Digite a nova idade:");
          string idade = Console.ReadLine();
          teste._idade = idade;
        break;

        case "3":
          System.Console.WriteLine("Digite a nova serie:");
          string serie = Console.ReadLine();
          teste._serie = serie;
        break;

        case "4":
          System.Console.WriteLine("Digite a nova data de nascimento:");
          string nasc = Console.ReadLine();
          teste.DataNasc = nasc;
        break;


        case "5":
        break;

        default:
          Console.Clear();
          System.Console.WriteLine("Digite uma opção válida");
          System.Console.ReadLine();
          continue;
      }
      break;
    };
  }catch(Exception){
    throw new ArgumentException("Matricula não encontrada.");
  }finally{
    Console.WriteLine("Aperte enter para continuar");
    Console.Clear();
  };
};