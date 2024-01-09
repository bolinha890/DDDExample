using Domain;
using Domain.Command;
using Domain.Enum;
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

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            
            int AnoAtual = DateTime.Now.Year;

            if (command == null)


                return "Todos os Campos são obrigatorio";
            //regras 
            if (command.TipoVeiculo != EtipoVeiculo.SUV
               && command.TipoVeiculo != EtipoVeiculo.Hatch
               && command.TipoVeiculo != EtipoVeiculo.Sedans

            )
                return "Cadastro Realzado com sucesso";

             if (AnoAtual - command.AnoFabricacao >= 5)
                return "O Ano do veículo menor que o permetido";

              return _veiculoRepository.PostAsync(command);
        }

       
      

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
