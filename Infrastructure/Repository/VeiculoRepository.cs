using Dapper;
using Domain.Entidades;
using Domain.Enum;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public async  Task<string> PostAsync(Veiculo command)
        {
            string queryInsert = "insert into Veiculo(Placa,AnoFabricacao,TipoVeiculoId,Estado,MontadoraId)" +
                "Values(@Placa, @AnoFabricacao, @TipoVeiculoId ,@Estado, @MontadoraId)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoId = command.TipoVeiculo,
                    Estado = command.Estado,
                    EMontadora = command.Montadora   

                });

                return "Veiculo Cadastro com Sucesseso";

            }
        }

        public void PostAsync() 
        {

        }
        public void GetAsync()
        {

        }

    }
}
