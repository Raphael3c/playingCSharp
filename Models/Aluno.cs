namespace DigitalInnovationOne.Models
{
    public class Aluno
    {
        public int _matricula { get; set; }

        public string _nome { get; set; }

        public string _idade { get; set; }

        public string _serie { get; set; }

        public DateOnly _datanasc { get; set; }

        public string DataNasc { 
            get{
                string datanasc = _datanasc.ToString();
                return datanasc;
            }

            set{
                DateTime valueParsed = DateTime.Parse(value);
                value = valueParsed.ToString();
            }
        }

        public Aluno(){}

        public Aluno(int matricula, string nome, string idade, string serie, string datanasc){
            _matricula = matricula;
            _nome = nome;
            _idade = idade;
            _serie = serie;
            DataNasc = datanasc;
        }

        public override string ToString(){
            string var = $"Matricula: {_matricula}\nAluno: {_nome}\nIdade: {_idade}\nSerie: {_serie}\nNascimento: {_datanasc}";
            return var;
        }
    }
}