namespace Mediator
{
    using System;

    public interface IClient
    {
        ICentralizedServer Server { get; }

        string IPAddress { get; }

        void Send(string to, IFile file);

        void Receive(string from, IFile file);
    }
}
