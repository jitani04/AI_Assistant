// using OpenAI;
// using OpenAI.Chat;
// using System.Threading.Tasks;

// public class AiService
// {
//     private readonly OpenAIAPI _openAi;

//     public AiService(IConfiguration config)
//     {
//         _openAi = new OpenAIAPI(config["OpenAI:ApiKey"]);
//     }

//     public async Task<string> GetAiResponse(string userMessage)
//     {
//         var chatRequest = new ChatRequest()
//         {
//             Model = "gpt-4",
//             Messages = new List<ChatMessage>()
//             {
//                 new ChatMessage(ChatMessageRole.User, userMessage)
//             }
//         };

//         var response = await _openAi.Chat.Completions.CreateCompletionAsync(chatRequest);

//         return response.Choices[0].Message.Content;
//     }
// }
