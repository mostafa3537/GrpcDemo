using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient;

internal class Program
{
    static async Task Main(string[] args)
    {

        var request = new HelloRequest { Name = "darsh" };

        var channel = GrpcChannel.ForAddress("https://localhost:7109/");

        var client = new Greeter.GreeterClient(channel);

        var reply = await client.SayHelloAsync(request);

        Console.WriteLine(reply);

        Console.ReadLine();
    }
}
