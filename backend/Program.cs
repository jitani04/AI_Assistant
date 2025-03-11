var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
  //  endpoints.MapHub<ChatHub>("/chatHub");
    endpoints.MapControllers();
});

app.Run();
