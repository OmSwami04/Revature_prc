using System;
using Microsoft.Extensions.DependencyInjection;

namespace Day04
{
    // Entry point
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1️ Create service container
            var services = new ServiceCollection();

            // 2️ Register dependencies (DI container)
            services.AddScoped<IMessageReader, TwitterMessageReader>();
            services.AddScoped<IMessageWriter, InstagramMessageWriter>();
            services.AddScoped<IMyLogger, ConsoleLogger>();
            services.AddScoped<App>();

            // 3️ Build service provider
            var serviceProvider = services.BuildServiceProvider();

            // 4️ Resolve App (dependencies injected automatically)
            var app = serviceProvider.GetRequiredService<App>();

            // 5️ Run application
            app.Run();
        }
    }

    // ---------------- APPLICATION ----------------

    // High-level module (depends on abstractions, not concrete classes)
    public class App
    {
        private readonly IMessageReader _messageReader;
        private readonly IMessageWriter _messageWriter;

        // Constructor Injection
        public App(IMessageReader reader, IMessageWriter writer)
        {
            _messageReader = reader;
            _messageWriter = writer;
        }

        public void Run()
        {
            string message = _messageReader.ReadMessage();
            _messageWriter.WriteMessage(message);
        }
    }

    // ---------------- READER ----------------

    // Interface for reading messages
    public interface IMessageReader
    {
        string ReadMessage();
    }

    // Twitter implementation
    public class TwitterMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "Hello from Twitter!";
        }
    }

    // ---------------- WRITER ----------------

    // Interface for writing messages
    public interface IMessageWriter
    {
        void WriteMessage(string message);
    }

    // Instagram writer (depends on logger)
    public class InstagramMessageWriter : IMessageWriter
    {
        private readonly IMyLogger _logger;

        public InstagramMessageWriter(IMyLogger logger)
        {
            _logger = logger;
        }

        public void WriteMessage(string message)
        {
            _logger.Log();
            Console.WriteLine($"{message} posted to Instagram");
        }
    }

    // ---------------- LOGGER ----------------

    // Logger interface
    public interface IMyLogger
    {
        void Log();
    }

    // Console logger implementation
    public class ConsoleLogger : IMyLogger
    {
        public void Log()
        {
            Console.WriteLine("Logging started...");
        }
    }
}
