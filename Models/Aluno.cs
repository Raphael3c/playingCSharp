namespace DigitalInnovationOne.Models
{
    public class Aluno
    {
        private int _alunoId { get; set; }

        private string _nome { get; set; }

        private string _idade { get; set; }

        private string _serie { get; set; }

        private DateOnly _datanasc { get; set; }

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

        public Aluno(string nome, string idade, string serie, string datanasc){
            _alunoId = 1;
            _nome = nome;
            _idade = idade;
            _serie = serie;
            DataNasc = datanasc;
        }

        public override string ToString(){
            string var = $"Aluno: {_nome}\nIdade: {_idade}\nSerie: {_serie}\nNascimento: {_datanasc}";
            return var;
        }
    }
}