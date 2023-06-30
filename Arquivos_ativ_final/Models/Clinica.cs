namespace Arquivos.Models
{
    public class Clinica
    {
        public int Id{ get;set;}        
        public string? FirstName {get;set;}
        public string? Telephone {get;set;}
        public string? Address { get;set;}
        
        public Clinica()
        {
            
        }
        public Clinica(int id, 
                    string? firstName, 
                    string? telephone, 
                    string? address)
        {
            Id = id;
            FirstName = firstName;
            Telephone = telephone;
            Address = address;
        }
        public string FullName =>
            $"{this.FirstName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.FullName}";
        }
    }
}