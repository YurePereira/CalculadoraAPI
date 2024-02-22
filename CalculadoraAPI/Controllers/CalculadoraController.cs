using CalculadoraAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraAPI.Controllers
{
    [Route("api/calculadora")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {

        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Somar dois fatores
        /// </summary>
        /// <param name="fator"></param>
        /// <returns></returns>
        [HttpPost ("adicao")]
        public IEnumerable<Object> Adicao([FromBody] Parcela parcela)
        {

            var result = parcela.parcela1 + parcela.parcela2;

            return new List<Object>
            {
                new { Result = result }
            };

        }

        /// <summary>
        /// Subtração de um aditico com um subtrativo
        /// </summary>
        /// <param name="aditivo"></param>
        /// <returns></returns>
        [HttpPost("subtracao")]
        public IEnumerable<Object> Subtracao([FromBody] Aditivo aditivo)
        {

            var result = aditivo.aditivo - aditivo.subtrativo;

            return new List<Object>
            {
                new { Result = result }
            };

        }

        /// <summary>
        /// Multiplicação de dois fatores
        /// </summary>
        /// <param name="aditivo"></param>
        /// <returns></returns>
        [HttpPost("multiplicacao")]
        public IEnumerable<Object> Multiplicacao([FromBody] Fator fator)
        {

            var result = fator.fator1 * fator.fator2;

            return new List<Object>
            {
                new { Result = result }
            };

        }

        /// <summary>
        /// Divisão de um dividendo e um divisor
        /// </summary>
        /// <param name="aditivo"></param>
        /// <returns></returns>
        [HttpPost("divisao")]
        public IEnumerable<Object> Multiplicacao([FromBody] Dividendo dividendo)
        {

            var result = dividendo.dividendo / dividendo.divisor;

            return new List<Object>
            {
                new { Result = result }
            };

        }

    }
}
