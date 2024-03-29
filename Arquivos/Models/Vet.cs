using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Vet
    {
        public int Id{ get;set;}        
        public string? FirstName {get;set;}
        public string?LastName {get;set;}
        public string? CPF { get;set;}
        public string? CRMV { get;set;}
        
        public Vet()
        {
            
        }
        public Vet(int id, 
                    string? firstName, 
                    string? lastName, 
                    string? CPF, 
                    string? CRMV)
        {

        }
        public string FullName => $"{this.FirstName} {this.LastName}";

        public override string ToString()
        {
            return $"Id: {this.Id}; Name: {this.FullName}; CPF: {this.CPF}; CRMV: {this.CRMV}";
        }
    }
}
