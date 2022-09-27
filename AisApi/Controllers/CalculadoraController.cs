using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        
        // GET api/<CalculadoraController>/5
        [HttpGet("{numero}")]
        public string Get(int numero)
        {
            int resultado = 1;
            for (int counter = 1; counter <= numero; counter++)
            {
                resultado *= counter;
            }
            return resultado.ToString();
        }
        [HttpPost]
        public string Post([FromBody] int[] arrayNumeros)
        {
            try
            {
                int t;
                for (int a = 1; a < arrayNumeros.Length; a++) { 
                    for (int b = arrayNumeros.Length - 1; b >= a; b--)
                    {
                        if (arrayNumeros[b - 1] > arrayNumeros[b])
                        {
                            t = arrayNumeros[b - 1];
                            arrayNumeros[b - 1] = arrayNumeros[b];
                            arrayNumeros[b] = t;
                        } 
                    }
                }
                return String.Join(',', arrayNumeros);
            }
            catch(Exception error)
            {
                return $"Error: {error.Message}";
            }
        }
       
    }
}
