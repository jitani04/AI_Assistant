using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

[Route("api/speech")]
[ApiController]
public class SpeechController : ControllerBase
{
    private readonly SpeechService _speechService;

    public SpeechController(SpeechService speechService)
    {
        _speechService = speechService;
    }

    [HttpPost("transcribe")]
    public async Task<IActionResult> TranscribeSpeech([FromForm] IFormFile audioFile)
    {
        var filePath = Path.Combine("uploads", audioFile.FileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await audioFile.CopyToAsync(stream);
        }

        var transcript = await _speechService.ConvertSpeechToText(filePath);
        return Ok(new { transcript });
    }
}
