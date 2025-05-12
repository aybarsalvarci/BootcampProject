using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class BootcampManager : IBootcampService
    {
        private readonly IBootcampRepository _repository;
        private readonly IMapper _mapper;
        public BootcampManager(IBootcampRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedBootcampResponse Create(CreateBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);

            var result = _repository.Add(bootcamp);

            return _mapper.Map<CreatedBootcampResponse>(result);
        }

        public DeletedBootcampResponse Delete(DeleteBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);

            var result = _repository.Add(bootcamp);

            return _mapper.Map<DeletedBootcampResponse>(result);
        }

        public List<GetListBootcampResponse> GetAll()
        {
            List<Bootcamp> bootcamps = _repository.GetAll(include:x=> x.Include(x=>x.Instructor));
            List<GetListBootcampResponse> responses = new List<GetListBootcampResponse>();
            foreach(var bootcamp in bootcamps)
            {
               responses.Add(_mapper.Map<GetListBootcampResponse>(bootcamp));
            }

            return responses;   
        }

        public GetSingleBootcampResponse GetById(Guid id)
        {
            Bootcamp bootcamp = _repository.Get(x => x.Id == id);
            return _mapper.Map<GetSingleBootcampResponse>(bootcamp);
        }

        public UpdatedBootcampResponse Update(UpdateBootcampRequest request)
        {
            Bootcamp bootcamp = _mapper.Map<Bootcamp>(request);

            var result = _repository.Add(bootcamp);

            return _mapper.Map<UpdatedBootcampResponse>(result);
        }
    }
}
