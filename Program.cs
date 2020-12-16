using System;

namespace Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IServerBuilder serverBuilder = new ServerBuilder();
            var server = 
                serverBuilder
                .AddIpAddress("127.0.0.1")
                .AddOperatingSystem("Windows Server 2012")
                .AddAvailabilityZone("India-1")
                .AddLocation("Mumbai")
                .AddBlockCode(123)
                .Build();
        }
    }
}
