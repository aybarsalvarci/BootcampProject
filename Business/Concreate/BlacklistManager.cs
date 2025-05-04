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
        public BlacklistManager(IBlacklistRepository repository)
        {
            _repository = repository;
        }

        public CreatedBlacklistResponse Create(CreateBlacklistRequest request)
        {
            Blacklist blacklist = new Blacklist
            {
                ApplicantId = request.ApplicantId,
                Reason = request.Reason,
                Date = request.Date
            };

            var result = _repository.Add(blacklist);

            return new CreatedBlacklistResponse
            {
                ApplicantId = result.ApplicantId,
                Reason = result.Reason,
                Date = result.Date
            };
        }

        public DeletedBlacklistResponse Delete(DeleteBlacklistRequest request)
        {
            Blacklist blacklist = new Blacklist
            {
                ApplicantId = request.ApplicantId,
                Reason = request.Reason,
                Date = request.Date
            };

            var result = _repository.Delete(blacklist);

            return new DeletedBlacklistResponse
            {
                ApplicantId = result.ApplicantId,
                Reason = result.Reason,
                Date = result.Date
            };
        }

        public List<GetListBlacklistResponse> GetAll()
        {
            List<Blacklist> blacklists = _repository.GetAll();
            List<GetListBlacklistResponse> responses = new List<GetListBlacklistResponse>();
            foreach (var blacklist in blacklists)
            {
                GetListBlacklistResponse response = new GetListBlacklistResponse
                {
                    ApplicantId = blacklist.ApplicantId,
                    Reason = blacklist.Reason,
                    Date = blacklist.Date
                };
                responses.Add(response);
            }

            return responses;

        }

        public GetSingleBlacklistResponse GetById(Guid id)
        {
            Blacklist blacklist = _repository.Get(b => b.Id == id);

            return new GetSingleBlacklistResponse
            {
                ApplicantId = blacklist.ApplicantId,
                Reason = blacklist.Reason,
                Date = blacklist.Date
            };
        }

        public UpdateBlacklistResponse Update(UpdateBlacklistRequest request)
        {
            Blacklist blacklist = new Blacklist
            {
                ApplicantId = request.ApplicantId,
                Reason = request.Reason,
                Date = request.Date
            };

            var result = _repository.Update(blacklist);

            return new UpdateBlacklistResponse
            {
                ApplicantId = result.ApplicantId,
                Reason = result.Reason,
                Date = result.Date
            };
        }
    }
}
