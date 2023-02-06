﻿namespace AnimalClinic.Services
{
    public interface IRepository<T, Tid> where T: class
    {
        List<T> GetAll();
        T GetById(Tid id);

        int Create(T item);

        int Update(T item);

        int Delete(Tid id);
    }
}
