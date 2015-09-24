namespace Mediator
{
    using System;

    public interface ICentralizedServer
    {
        void Register(IClient participant);

        void Send(string from, string to, IFile file);
    }
}
