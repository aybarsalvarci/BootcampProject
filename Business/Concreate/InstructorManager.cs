using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Entities;
using Repositories.Abstract;

namespace Business.Concreate
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _repository;
        private readonly IMapper _mapper;
        public InstructorManager(IInstructorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedInstructorResponse Create(CreateInstructorRequest request)
        {
            Instructor instructor = _mapper.Map<Instructor>(request);

            var result = _repository.Add(instructor);

            return _mapper.Map<CreatedInstructorResponse>(result);
        }

        public DeletedInstructorResponse Delete(DeleteInstructorRequest request)
        {
            Instructor instructor = _mapper.Map<Instructor>(request);

            var result = _repository.Add(instructor);

            return _mapper.Map<DeletedInstructorResponse>(result);
        }

        public List<GetListInstructorResponse> GetAll()
        {
            List<Instructor> instructors = _repository.GetAll();
            List<GetListInstructorResponse> responses = new List<GetListInstructorResponse>();
            foreach(var instructor in instructors)
            {
                responses.Add(_mapper.Map<GetListInstructorResponse>(instructor));
            }

            return responses;   
        }

        public GetSingleInstructorResponse GetById(Guid id)
        {
            Instructor instructor = _repository.Get(x => x.Id == id);
            return _mapper.Map<GetSingleInstructorResponse>(instructor);
        }

        public UpdatedInstructorResponse Update(UpdateInstructorRequest request)
        {
            Instructor employee = _mapper.Map<Instructor>(request);

            var result = _repository.Add(employee);

            return _mapper.Map<UpdatedInstructorResponse>(result);
        }
    }
}
