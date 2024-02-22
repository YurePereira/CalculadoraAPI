using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace CalculadoraWeb.Repositories.Interfaces
{
    public interface ICalculadoraRepository
    {

		[Post("/v1/calculadora/adicao")]
		Task<IEnumerable<Object>> Adicao([FromBody] Parcela parcela);

		[Post("/v1/calculadora/subtracao")]
		Task<IEnumerable<Object>> Subtracao([FromBody] Aditivo aditivo);

		[Post("/v1/calculadora/multiplicacao")]
		Task<IEnumerable<Object>> Multiplicacao([FromBody] Fator fator);

		[Post("/v1/calculadora/divisao")]
		Task<IEnumerable<Object>> Divisao([FromBody] Dividendo dividendo);

	}
}
