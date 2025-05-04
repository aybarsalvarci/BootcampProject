using Business.Abstract;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using Entities;
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
        public BootcampManager(IBootcampRepository repository)
        {
            _repository = repository;
        }

        public CreatedBootcampResponse Create(CreateBootcampRequest request)
        {
            Bootcamp bootcamp = new Bootcamp
            {
                InstructorId = request.InstructorId,
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                State = request.State
            };

            var result = _repository.Add(bootcamp);

            return new CreatedBootcampResponse
            {
                Id = result.Id,
                InstructorId = result.InstructorId,
                Name = result.Name,
                StartDate = result.StartDate,
                EndDate = result.EndDate,
                State = result.State,
                CreatedDate = result.CreatedDate
            };
        }

        public DeletedBootcampResponse Delete(DeleteBootcampRequest request)
        {
            Bootcamp bootcamp = new Bootcamp
            {
                Id = request.Id,
                InstructorId = request.InstructorId,
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                State = request.State
            };

            var result = _repository.Add(bootcamp);

            return new DeletedBootcampResponse
            {
                Id = result.Id,
                InstructorId = result.InstructorId,
                Name = result.Name,
                StartDate = result.StartDate,
                EndDate = result.EndDate,
                State = result.State,
                CreatedDate = result.CreatedDate,
                UpdatedDate = result.UpdatedDate,
            };
        }

        public List<GetListBootcampResponse> GetAll()
        {
            List<Bootcamp> bootcamps = _repository.GetAll();
            List<GetListBootcampResponse> responses = new List<GetListBootcampResponse>();
            foreach(var bootcamp in bootcamps)
            {
                GetListBootcampResponse response = new GetListBootcampResponse
                {
                    Id = bootcamp.Id,
                    InstructorId = bootcamp.InstructorId,
                    Name = bootcamp.Name,
                    StartDate = bootcamp.StartDate,
                    EndDate = bootcamp.EndDate,
                    State = bootcamp.State,
                    CreatedDate = bootcamp.CreatedDate,
                    UpdatedDate = bootcamp.UpdatedDate,
                };

                responses.Add(response);
            }

            return responses;   
        }

        public GetSingleBootcampResponse GetById(Guid id)
        {
            Bootcamp bootcamp = _repository.Get(x => x.Id == id);
            return new GetSingleBootcampResponse
            {
                Id = bootcamp.Id,
                InstructorId = bootcamp.InstructorId,
                Name = bootcamp.Name,
                StartDate = bootcamp.StartDate,
                EndDate = bootcamp.EndDate,
                State = bootcamp.State,
                CreatedDate = bootcamp.CreatedDate,
                UpdatedDate = bootcamp.UpdatedDate,
            };
        }

        public UpdatedBootcampResponse Update(UpdateBootcampRequest request)
        {
            Bootcamp bootcamp = new Bootcamp
            {
                Id = request.Id,
                InstructorId = request.InstructorId,
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                State = request.State
            };

            var result = _repository.Add(bootcamp);

            return new UpdatedBootcampResponse
            {
                Id = bootcamp.Id,
                InstructorId = bootcamp.InstructorId,
                Name = bootcamp.Name,
                StartDate = bootcamp.StartDate,
                EndDate = bootcamp.EndDate,
                State = bootcamp.State,
                CreatedDate = bootcamp.CreatedDate,
                UpdatedDate = bootcamp.UpdatedDate,
            };
        }
    }
}
