namespace Arquivos.Models
{
    public class Animal
    {
        public int Id {get;set;}
        public string? Nome {get;set;}
        public string? Raca {get;set;}
        public string? Nascimento {get;set;}

        public Animal()
        {

        }

        public Animal (int id,string? nome, string? raca, string? nascimento)
        {
            id = Id;
            nome = Nome;
            raca = Raca;
            nascimento = Nascimento;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}; Nome: {this.Nome}; Raça: {this.Raca}; Nascimento: {this.Nascimento};";
        }
    }
}