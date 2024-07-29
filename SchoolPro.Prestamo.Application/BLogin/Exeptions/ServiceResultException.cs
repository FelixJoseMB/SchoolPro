

using SchoolPro.Prestamo.Application.BLogin.Core;
using SchoolPro.Prestamo.Application.BLogin.Loggin;

namespace SchoolPro.Prestamo.Application.BLogin.Exeptions
{
    public static class ServiceResultExceptions
    {
        public static ServiceResult ExecuteWithHandling(this ServiceResult result, Action action, ILog log)
        {
            try
            {
                action();
                result.succes = true;
            }
            catch (PrestamosServiceExeption ex)
            {
                log.LogError(ex.Message);
                result.succes = false;
                result.message = ex.Message;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString());
                result.succes = false;
                result.message = "error procesando la solicitud";
            }
            return result;
        }
    }
}