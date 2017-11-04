using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, "Mzc1NzU0NzYyMDAxNDQ4OTc5.DN1HNg.HF3nr9wQVjKlH2yEwd71Oo7Dvww");

            await _client.StartAsync();

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);

            await Task.Delay(-1);
        }

    }
