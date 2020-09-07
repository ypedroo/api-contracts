using System;
using System.Collections.Generic;
using AutoMapper;
using Contracts.Domain.Models;
using Contracts.Domain.Repositories;
using Contracts.Infra.Data.MongoDb;
using Contracts.Shared.Dtos;
using MongoDB.Driver;
using OperationResult;

namespace Contracts.Infra.Data.Repositories
{
    public sealed class PartRepository : IPartRepository
    {
        private readonly IMongoCollection<Part> _logCollection;
        private readonly IMapper _mapper;

        public PartRepository(ContractsContext context, IMapper mapper)
        {
            _logCollection = context.GetCollection<Part>("Part");
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
            try
            {
                _logCollection.InsertOne(_mapper.Map<Part>(part));
                return Result.Success();

            }
            catch (Exception ex)
            {
                return Result.Error(ex);
            }
        }
    }
}
