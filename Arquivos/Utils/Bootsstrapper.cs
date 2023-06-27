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
    }
}