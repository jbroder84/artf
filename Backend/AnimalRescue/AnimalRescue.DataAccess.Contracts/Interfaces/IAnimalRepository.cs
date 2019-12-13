﻿using AnimalRescue.Models.DTO.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimalRescue.DataAccess.Contracts.Interfaces
{
    public interface IAnimalRepository
    {
        Task<List<AnimalDto>> GetAnimalsAsync(int currentPage = 1, int pageSize = 10);
        Task<AnimalDto> GetAnimalAsync(string id);
        Task UpdateAnimalAsync(AnimalDto instanse);
        Task DeleteAnimalAsync(string id);
        Task DeleteAnimalAsync(AnimalDto instanse);
        Task<AnimalDto> CreateAnimalAsync(AnimalDto instanse);
    }
}
