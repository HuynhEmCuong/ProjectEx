using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Models;
using Web_API.Repository;
using Web_API.Service.Interface;

namespace Web_API.Service.Service
{
    public class BuildingService : Service<BuildingDto, Building>, IBuildingService
    {
        public BuildingService(IRepository<Building> repo, IMapper mapper, MapperConfiguration configuration) : base(repo, mapper, configuration)
        {
        }
    }
}
