using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    //  GoF: Separate the construction of a complex object from its
    //  representation so that the same construction process can
    //  create different representations.

    //  Constructors can be too long and tedious
    //  Make the process of object creation intuitive

    public interface IServerBuilder
    {
        IServerBuilder AddIpAddress(string ipAddress);
        IServerBuilder AddLocation(string location);
        IServerBuilder AddOperatingSystem(string operatingSystem);
        IServerBuilder AddBlockCode(int blockCode);
        IServerBuilder AddAvailabilityZone(string availabilityZone);
        Server Build();
    }

    public class Server
    {
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public string OperatingSystem { get; set; }
        public int BlockCode { get; set; }
        public string AvailabilityZone { get; set; }
    }

    public class ServerBuilder : IServerBuilder
    {
        private Server _server;

        public ServerBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            this._server = new Server();
        }
        public IServerBuilder AddIpAddress(string ipAddress)
        {
            this._server.IpAddress = ipAddress;
            return this;
        }

        public IServerBuilder AddLocation(string location)
        {
            this._server.Location = location;
            return this;
        }

        public IServerBuilder AddOperatingSystem(string operatingSystem)
        {
            this._server.OperatingSystem = operatingSystem;
            return this;
        }

        public IServerBuilder AddBlockCode(int blockCode)
        {
            this._server.BlockCode = blockCode;
            return this;
        }

        public IServerBuilder AddAvailabilityZone(string availabilityZone)
        {
            this._server.AvailabilityZone = availabilityZone;
            return this;
        }

        public Server Build()
        {
            return this._server;
        }
    }
}
