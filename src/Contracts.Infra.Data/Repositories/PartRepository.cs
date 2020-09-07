using System.Collections.Generic;
using AutoMapper;
using Contracts.Domain.Repositories;
using Contracts.Infra.Data.MongoDb;
using Contracts.Shared.Dtos;
using MongoDB.Driver;
using OperationResult;

namespace Contracts.Infra.Data.Repositories
{
    public sealed class PartRepository : IPartRepository
    {
        private readonly IMongoCollection<PartDto> _logCollection;
        private readonly IMapper _mapper;

        public PartRepository(ContractsContext context, IMapper mapper)
        {
            _logCollection = context.GetCollection<PartDto>("Part");
            _mapper = mapper;
        }

        public Result<PartDto> GetPartById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Result<List<PartDto>> GetParts()
        {
            throw new System.NotImplementedException();
        }

        Result IPartRepository.CreatePart(PartDto part)
        {
            throw new System.NotImplementedException();
        }
    }
}
