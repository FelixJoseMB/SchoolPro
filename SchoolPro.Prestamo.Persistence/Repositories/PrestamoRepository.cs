using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using BiblioMonolitica.web.Data.Context;
using SchoolPro.Prestamo.Domain.Entities;
using SchoolPro.Prestamo.Domain.Interface;

public class PrestamoRepository : IPrestamoRepository
{
    private readonly PrestamoContext context;

    public PrestamoRepository(PrestamoContext context)
    {
        this.context = context;
    }

    public bool Exists(Expression<Func<Prestamo, bool>> filter)
    {
        return this.context.Prestamo.Any(filter);
    }

    public List<Prestamo> GetAll()
    {
        return this.context.Prestamo.ToList();
    }

    public Prestamo GetEntityBy(int id)
    {
        return this.context.Prestamo.Find(id);
    }

    public List<Prestamo> GetPrestamobyPrestamoId(int prestamoId)
    {
        return this.context.Prestamo.Where(p => p.Id == prestamoId).ToList();
    }

    public void Remove(Prestamo tentity)
    {
        var prestamoToRemove = this.context.Prestamo.Find(tentity.Id);

        if (prestamoToRemove == null)
        {
            throw new ArgumentException("Prestamo no encontrado");
        }

        prestamoToRemove.Estado = false;
        this.context.Prestamo.Remove(prestamoToRemove);
        //this.context.Save();
    }

    public void Save(Prestamo tentity)
    {
        tentity.Estado = true;
        this.context.Prestamo.Add(tentity);
       // this.context.SaveChanges();
    }

    public void Update(Prestamo tentity)
    {
        var prestamoToUpdate = this.context.Prestamo.Find(tentity.Id);
        if (prestamoToUpdate == null)
        {
            throw new ArgumentException("Prestamo no encontrado");
        }

        prestamoToUpdate = tentity; // Aquí puedes mapear las propiedades individualmente si no quieres reemplazar toda la entidad
        this.context.Prestamo.Update(prestamoToUpdate);
        //this.context.SaveChanges();
    }
}
