

using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SchoolPro.Common.Data.Base;
using SchoolPro.Prestamo.Application.BLogin.EstadoPrestamo;
using SchoolPro.Prestamo.Application.BLogin.Models;
using SchoolPro.Prestamo.Domain.Entities;

namespace SchoolPro.Prestamo.Application.BLogin.Mappeo
{
    public static class PrestamoMapper 
    {

        public static Domain.Entities.Prestamo ToEntity(CreatePrestamosModel ModelPrestamo)
        {
            return new Domain.Entities.Prestamo
            {
                Descripcion = ModelPrestamo.Descripcion,
                Estado = (bool)ModelPrestamo.Estado,
                FechaCreacion = ModelPrestamo.FechaCreacion,

            };
        }


        public static PrestamosModel ToModel(Domain.Entities.Prestamo entityPrestamo)
        {
            return new PrestamosModel
            {
                IdPrestamo = entityPrestamo.Id,
                FechaDevolucion = entityPrestamo.FechaCreacion,
                Estado = (bool)entityPrestamo.Estado,
                Descripcion = entityPrestamo.Descripcion
            };
        }


        public static void UpdateentityPrestamo(UpdatePrestamomodel updateModel, Domain.Entities.Prestamo updateEntity)
        {
            updateEntity.Descripcion = updateModel.Descripcion;
            updateEntity.Estado = updateModel.Estado;

        }


        public static void DeleteEntityPrestamo(DeletePrestamosModel deleteModel, Domain.Entities.Prestamo deleteEntity)
        {
            deleteEntity.Id = deleteModel.id;
            deleteEntity.Descripcion = deleteModel.Descripcion;
            deleteEntity.Estado = deleteModel.Estado;

        }


    }


}

