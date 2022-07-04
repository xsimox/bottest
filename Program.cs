using Discord;
using Discord.WebSocket;

public class Program {
    private DiscordSocketClient _client = new DiscordSocketClient();
    public static Task Main(string[] args) => new Program().MainAsync();

    public async Task MainAsync()
    {
        _client.Log += Log;

        var token = "OTkzMTY3NTQ0NTY5NTYxMjY5.Gh-fP7.iln1vraxicrZOmYXMj77jjZDT0duyjOC1fr7mQ";

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();
        await Task.Delay(-1);
    }

    private Task Log(LogMessage message)
    {
        Console.WriteLine(message.ToString());
        return Task.CompletedTask;
    }
}


