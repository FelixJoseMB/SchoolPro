
namespace SchoolPro.Prestamo.Application.BLogin.Loggin
{
    public interface ILog
    {
        public void LogInformation(string message);
        public void LogError(string message);
        void LogError(Exception ex);
    }
}