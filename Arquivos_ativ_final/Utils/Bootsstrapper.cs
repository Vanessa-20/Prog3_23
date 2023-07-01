using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;
namespace Arquivos.Utils
{
    public static class Bootsstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Vanessa",
                LastName = "Rossetto",
                CPF = "258.545.545.-59",
                email = "vanessa21@gmail.com"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Luiz",
                    LastName = "Paz",
                    CPF = "518.585.981-56",
                    email = "Luiz57@gmail.com"
                }
            );

            DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Ana",
                    LastName = "Vitoria",
                    CPF = "695.259.295-59",
                    email = "Ana65@gmail.com"
                }
            );
        }
        public static void ChargeClinicas()
        {
            var a1 = new Clinica{
                Id = 1,
                FirstName = "Animal Amigo",
                Telephone = "(49) 98862-6625",
                Address = "Rua:Cibrazem , n:975"
            };
            DataSet.Clinicas.Add(a1);

            DataSet.Clinicas.Add(
                new Clinica{
                    Id = 2,
                    FirstName = "Alegria Animal",
                    Telephone = "(49) 99938-5884",
                    Address = "Rua:Alcantra , n:85"
                }
            );

            DataSet.Clinicas.Add(
                new Clinica{
                    Id = 3,
                    FirstName = "Recanto do Bichano",
                    Telephone = "(49) 98825-9315",
                    Address = "Rua:Cibrazem , n:278"
                }
            );
        }
        public static void ChargeVets()
        {
            DataSet.Vets.Add(
                new Vet{
                    Id = 1,
                    FirstName = "Allam",
                    LastName = "Bugui",
                    CPF = "542.515.268-54",
                    CRMV = "69948"
                } 
            );   
        }
        public static void ChargeAnimals()
        {
            DataSet.Animals.Add(
                new Animal{
                    Id = 1,
                    Name = "Marlei",
                    Raca = "Dalmata",
                    Nascimento = "05-10-2018"
                } 
            );   
        }
    }
}