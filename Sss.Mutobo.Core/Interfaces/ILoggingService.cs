using System;

namespace Sss.Mutobo.Core.Interfaces
{
    public interface ILoggingService
    {
        void Warn(Type type, string message);
        void Error(Type type, string message);
        void Info(Type type, string message);

        void Warn(Type type, Exception exception, string message);
        void Error(Type type, Exception exception, string message);
    }
}
