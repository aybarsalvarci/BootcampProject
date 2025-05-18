using AutoMapper;
using Business.Abstract;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Entities;
using Repositories.Abstract;

namespace Business.Concreate
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _repository;
        private readonly IMapper _mapper;
        public ApplicationManager(IApplicationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CreatedApplicationResponse Create(CreateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);

            var response = _repository.Add(application);

            return _mapper.Map<CreatedApplicationResponse>(response);
        }

        public DeletedApplicationResponse Delete(DeleteApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);

            var response = _repository.Delete(application);

            return _mapper.Map<DeletedApplicationResponse>(response);
        }

        public List<GetListApplicationResponse> GetAll()
        {
            List<Application> applications= _repository.GetAll();
            List<GetListApplicationResponse> responses = _mapper.Map<List<GetListApplicationResponse>>(applications);

            return responses;
        }

        public GetSingleApplicationResponse GetById(Guid id)
        {
            Application application = _repository.Get(x => x.Id == id);

            return _mapper.Map<GetSingleApplicationResponse>(application);

        }

        public UpdatedApplicationResponse Update(UpdateApplicationRequest request)
        {
            Application application = _mapper.Map<Application>(request);

            var response = _repository.Update(application);

            return _mapper.Map<UpdatedApplicationResponse>(response);
        }
    }
}
