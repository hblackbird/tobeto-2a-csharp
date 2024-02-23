using Business.Requests.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public DeleteBrandResponse Delete(DeleteBrandRequest request);
    public UpdateBrandResponse Update(int id, UpdateBrandRequest request);

    public GetBrandListResponse GetList(GetBrandListRequest request);
    Brand? GetById(int id);
}
