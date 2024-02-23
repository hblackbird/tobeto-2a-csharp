using Business.Dtos.Car;

namespace Business;

public class GetCarResponse
{
    public ICollection<CarListItemDto> Items { get; set; }

    public GetCarResponse()
    {
        Items = Array.Empty<CarListItemDto>();
    }

    public GetCarResponse(ICollection<CarListItemDto> items)
    {
        Items = items;
    }
}