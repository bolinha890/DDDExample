using Domain;
using Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class VeiculoService : IveiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)
        {
            //Todo 

            //Incluir validação, só podem cadastrar veículo com 
            //até 5 anos de uso
            //Incluir Somente Carros do tipo SUV, Sedan e Hatch
            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
