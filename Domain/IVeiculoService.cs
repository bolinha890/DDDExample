using Domain.Command;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public interface IveiculoService
    {
        // A interface é um contrato, apenas usamos para adicionar 
        //metedos,
        // não é feita implementação de nada 


         Task  PostAsync(VeiculoCommand command );

        void PostAsync();

        void GetAsync();
    }
}
