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
        public IActionResult Get(string firstNumber, string secondNumber) // vai pegar os dois atributos passados pelo par�metros
        {
            // L�gica de soma de dois n�meros entrados como par�metros na request
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) // valida se s�o dois valores num�ricos
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
                out number); // valida��o para verificar se o valor string entrado � um valor num�rico avaliando todos os tipos internacionais
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
