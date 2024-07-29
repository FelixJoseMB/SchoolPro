

namespace SchoolPro.Prestamo.Application.BLogin.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            this.succes = true;
        }
        public bool succes { get; set; }
        public string message { get; set; }
        public dynamic Data { get; set; }


    }
}
