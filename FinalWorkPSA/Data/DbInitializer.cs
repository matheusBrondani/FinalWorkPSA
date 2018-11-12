using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalWorkPSA.Data.Context;
using FinalWorkPSA.Data;

namespace CopaStefaniniBackEnd.Data
{
    public class DbInitializer
    {

        public static void Initialize(RegistryContext registryContext) {

            if (registryContext.Class.Any() && 
                registryContext.Historic.Any() &&
                registryContext.Requirement.Any() &&
                registryContext.Student.Any() &&
                registryContext.Subject.Any()) {
                return;
            }

            // TODO 
            // Criar inicialização do banco 
            // Pegando os dados dos csv's para popular o banco de dados 
            // //Insere na inicialização do banco de teste os players
            // cupContext.Players.Add(new Player(1, "Ronaldo Fenomeno", 1, 22, 1, 0, true));

            // cupContext.SaveChanges();
        }
    }
}
