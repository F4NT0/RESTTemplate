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

        [HttpGet("sum/{firstNumber}/{secondNumber}")] // Rota que vai ser chamada do request GET da nossa API REST
        public IActionResult Get(string firstNumber, string secondNumber) // vai pegar os dois atributos passados pelo parâmetros
        {
            // Lógica de soma de dois números entrados como parâmetros na request
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) // valida se são dois valores numéricos
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString()); // Envia um OK 200 e o valor somado
            }

            return BadRequest("Error! Invalid Input"); // Caso de um 400 BAD REQUEST ele mostra essa mensagem
        }

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
