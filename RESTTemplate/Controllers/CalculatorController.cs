using Microsoft.AspNetCore.Mvc;

namespace RESTTemplate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        /*
         * ----------------------------
         * HTTP GET (READ) SUM NUMBERS
         * ---------------------------
        */
        [HttpGet("sum/{firstNumber}/{secondNumber}")] // Rota que vai ser chamada do request GET da nossa API REST
        public IActionResult Sum(string firstNumber, string secondNumber) // vai pegar os dois atributos passados pelo parâmetros
        {
            // Lógica de soma de dois números entrados como parâmetros na request
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) // valida se são dois valores numéricos
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                _logger.LogInformation($"Resultado da soma: {sum}");
                return Ok(sum.ToString()); // Envia um OK 200 e o valor somado
            }

            return BadRequest("Error! Invalid Input"); // Caso de um 400 BAD REQUEST ele mostra essa mensagem
        }

        /*
         * -----------------------------------
         * HTTP GET (READ) SUBTRACTION NUMBERS
         * -----------------------------------
        */
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) 
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Error! Invalid Input");
        }

        /*
         * ----------------------------------------
         * HTTP GET (READ) MULTIPLICATIONS NUMBERS
         * ----------------------------------------
        */
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
            }

            return BadRequest("Error! Invalid Input");
        }

        /*
         * --------------------------------
         * HTTP GET (READ) DIVISION NUMBERS
         * --------------------------------
        */
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }

            return BadRequest("Error! Invalid Input");
        }


        /*
         * -------------------
         * MÉTODOS AUXILIARES
         * -------------------
         */

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number); // validação para verificar se o valor string entrado é um valor numérico avaliando todos os tipos internacionais
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
