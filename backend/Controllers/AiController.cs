// using Microsoft.AspNetCore.Mvc;
// using System.Threading.Tasks;

// [Route("api/ai")]
// [ApiController]
// public class AiController : ControllerBase
// {
//     private readonly AiService _aiService;

//     public AiController(AiService aiService)
//     {
//         _aiService = aiService;
//     }

//     [HttpPost("chat")]
//     public async Task<IActionResult> Chat([FromBody] ChatRequest request)
//     {
//         var response = await _aiService.GetAiResponse(request.Message);
//         return Ok(new { response });
//     }
// }

// public class ChatRequest
// {
//     public string Message { get; set; }
// }
