// using Microsoft.AspNetCore.SignalR;
// using System.Threading.Tasks;

// public class ChatHub : Hub
// {
//     private readonly AiService _aiService;

//     public ChatHub(AiService aiService)
//     {
//         _aiService = aiService;
//     }

//     public async Task SendMessage(string user, string message)
//     {
//         var aiResponse = await _aiService.GetAiResponse(message);
//         await Clients.All.SendAsync("ReceiveMessage", user, aiResponse);
//     }
// }
