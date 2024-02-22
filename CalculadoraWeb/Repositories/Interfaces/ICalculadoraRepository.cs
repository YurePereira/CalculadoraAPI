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
		Task<IEnumerable<Resultado>> Adicao([FromBody] Parcela parcela);

		[Post("/api/calculadora/subtracao")]
		Task<IEnumerable<Resultado>> Subtracao([FromBody] Aditivo aditivo);

		[Post("/api/calculadora/multiplicacao")]
		Task<IEnumerable<Resultado>> Multiplicacao([FromBody] Fator fator);

		[Post("/api/calculadora/divisao")]
		Task<IEnumerable<Resultado>> Divisao([FromBody] Dividendo dividendo);

	}
}
