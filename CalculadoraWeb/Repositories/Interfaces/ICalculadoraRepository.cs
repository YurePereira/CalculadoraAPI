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

		[Post("/api/calculadora/adicao")]
		Task<IEnumerable<Object>> Adicao([FromBody] Parcela parcela);

		[Post("/api/calculadora/subtracao")]
		Task<IEnumerable<Object>> Subtracao([FromBody] Aditivo aditivo);

		[Post("/api/calculadora/multiplicacao")]
		Task<IEnumerable<Object>> Multiplicacao([FromBody] Fator fator);

		[Post("/api/calculadora/divisao")]
		Task<IEnumerable<Object>> Divisao([FromBody] Dividendo dividendo);

	}
}
