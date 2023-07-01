namespace Arquivos.Models
{
    public class Clinica
    {
        public int Id{ get;set;}        
        public string? Nome {get;set;}
        public string? Telephone {get;set;}
        public string? Address { get;set;}
        
        public Clinica(int id, 
                    string? Nome, 
                    string? telephone, 
                    string? address)
        {
            
        }

    public Clinica()
    {
    }

    public override string ToString()
        {
            return $"Id: {this.Id}; Nome: {this.Nome}; Telephone{this.Telephone}";
        }
    }
}