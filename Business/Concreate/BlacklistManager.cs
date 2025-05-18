using AutoMapper;
using Azure.Core;
using Business.Abstract;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Blacklist;
using Entities;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class BlacklistManager : IBlacklistService
    {
        private readonly IBlacklistRepository _repository;
        private readonly IMapper _mapper;
        public BlacklistManager(IBlacklistRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedBlacklistResponse Create(CreateBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);

            var result = _repository.Add(blacklist);

            return _mapper.Map<CreatedBlacklistResponse>(result);
        }

        public DeletedBlacklistResponse Delete(DeleteBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);

            var result = _repository.Delete(blacklist);

            return _mapper.Map<DeletedBlacklistResponse>(result);
        }

        public List<GetListBlacklistResponse> GetAll()
        {
            List<Blacklist> blacklists = _repository.GetAll();
            List<GetListBlacklistResponse> responses = _mapper.Map<List<GetListBlacklistResponse>>(blacklists);

            return responses;

        }

        public GetSingleBlacklistResponse GetById(Guid id)
        {
            Blacklist blacklist = _repository.Get(b => b.Id == id);

            return _mapper.Map<GetSingleBlacklistResponse>(blacklist);
        }

        public UpdatedBlacklistResponse Update(UpdateBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);

            var result = _repository.Update(blacklist);

            return _mapper.Map<UpdatedBlacklistResponse>(result);
        }
    }
}
