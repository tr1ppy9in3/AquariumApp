﻿namespace Model.DataAccess.Repositories;

public interface IPlantRepository
{
    public Task<Plant?> GetById(long id);

    public List<Plant> GetAll(); 

    public Task Add(Plant plant); 

    public Task Update(Plant plant); 

    public Task Delete(long id);
}
