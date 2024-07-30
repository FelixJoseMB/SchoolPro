using SchoolPro.Common.Data.Repository;
using SchoolPro.Prestamo.Application.BLogin.Core;
using SchoolPro.Prestamo.Application.BLogin.EstadoPrestamo;
using SchoolPro.Prestamo.Application.BLogin.Exeptions;
using SchoolPro.Prestamo.Application.BLogin.Loggin;
using SchoolPro.Prestamo.Application.BLogin.Mappeo;
using SchoolPro.Prestamo.Application.BLogin.Models;
using SchoolPro.Prestamo.Domain.Entities;
using SchoolPro.Prestamo.Domain.Interface;

namespace SchoolPro.Prestamo.Application.BLogin.Service
{
    public class PrestamoService
    {


        private readonly IPrestamoRepository prestamoService;
        private readonly ILog log;



        public PrestamoService(IPrestamoRepository prestamoService, ILog log)
        {
            this.prestamoService = prestamoService;
            this.log = log;
        }

        private ServiceResult ExecuteOperation<T>(T entity, Action<T> operation) where T : class
        {
            var result = new ServiceResult();
            return result.ExecuteWithHandling(() =>
            {
                operation(entity);
            }, log);
        }


        public ServiceResult CreatePrestamoModel(CreatePrestamosModel createPrestamoModel)
        {
            PrestamoValidations.Validar(createPrestamoModel);
            var prestamo = PrestamoMapper.ToEntity(createPrestamoModel);
            return ExecuteOperation(prestamo, p => prestamoService.Save(p));
        }



        public ServiceResult DeletePrestamoModel(DeletePrestamosModel deletePrestamoModel)
        {
            PrestamoValidations.Validar(deletePrestamoModel);
            var prestamo = prestamoService.GetEntityBy(deletePrestamoModel.id);
            PrestamoMapper.DeleteEntityPrestamo(deletePrestamoModel, prestamo);
            return ExecuteOperation(prestamo, p => prestamoService.Remove(p));
        }


        public ServiceResult GetPrestamo()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = prestamoService.GetAll();

            }
            catch (Exception ex)
            {
                result.succes = false;
                result.message = "Error al obtener prestamos";
            }
            return result;
        }

        public ServiceResult GetPrestamo(int id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                return PrestamoMapper.ToModel(result.Data = this.prestamoService.GetEntityBy(id));
            }
            catch (Exception ex)
            {
                result.succes = false;
                result.message = "Ocurrio un error obteniendo el Prestamo por el ID";
            }
            return result;
        }

        public ServiceResult UpdateModelPrestamo(UpdatePrestamomodel updatePrestamoModel)
        {
            PrestamoValidations.Validar(updatePrestamoModel);
            var prestamo = prestamoService.GetEntityBy(updatePrestamoModel.idPrestamo);
            PrestamoMapper.UpdateentityPrestamo(updatePrestamoModel, prestamo);
            return ExecuteOperation(prestamo, p => prestamoService.Update(p));
        }



    }
}