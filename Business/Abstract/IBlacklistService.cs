using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Blacklist;
using Entities;
namespace Business.Abstract
{
    public interface IBlacklistService
    {
        GetSingleBlacklistResponse GetById(Guid id);
        List<GetListBlacklistResponse> GetAll();
        CreatedBlacklistResponse Create(CreateBlacklistRequest request);
        UpdatedBlacklistResponse Update(UpdateBlacklistRequest request);
        DeletedBlacklistResponse Delete(DeleteBlacklistRequest request);
    }
}
