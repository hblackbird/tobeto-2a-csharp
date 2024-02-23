using AutoMapper;
using Business.Dtos.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using Entities.Concrete;


namespace Business.Profiles.Mapping.AutoMapper;

public class ModelMapperProfiles: Profile
{
    public ModelMapperProfiles() {
        CreateMap<AddModelRequest, Model>();
        CreateMap<Model, AddModelResponse>();

        CreateMap<Model, ModelListItemDto>();
        CreateMap<IList<Model>, GetModelListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<Model, DeleteModelResponse>();
        CreateMap<UpdateModelRequest, Model>();
        CreateMap<Model, UpdateModelResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}

