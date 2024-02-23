using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly ModelBusinessRules _modelBusinessRules;
        private readonly IModelDal _modelDal;
        private readonly IMapper _mapper;

        public ModelManager( IModelDal modelDal, IMapper mapper, ModelBusinessRules modelBusinessRules)
        {
            _modelDal = modelDal;
            _mapper = mapper;
            _modelBusinessRules = modelBusinessRules;
        }

        public AddModelResponse Add(AddModelRequest request)
        {
            _modelBusinessRules.CheckIfModelNameIsValid(request.Name);
            _modelBusinessRules.CheckIfDailyPriceIsValid(request.DailyPrice);
            _modelBusinessRules.CheckIfModelNoExists(request.BrandId);
            Model modelToAdd = _mapper.Map<Model>(request);
            _modelDal.Add(modelToAdd);
            AddModelResponse response = _mapper.Map<AddModelResponse>(modelToAdd);
            return response;
        }

        public UpdateModelResponse Update(int id, UpdateModelRequest request)
        {
            Model existingModel = _modelDal.Get(m => m.Id == id);
            _modelBusinessRules.CheckIfModelNoExists(request.BrandId);


            if (existingModel == null)
            {
                throw new Exception("Model not found");
            }

            _mapper.Map(request, existingModel);
            _modelDal.Update(existingModel);

            UpdateModelResponse response = _mapper.Map<UpdateModelResponse>(existingModel);
            return response;
        }


        public DeleteModelResponse Delete(DeleteModelRequest request)
        {
            Model model = _modelBusinessRules.FindId(request.Id);
            _modelBusinessRules.CheckIfModelNoExists(request.Id);
            _modelDal.Delete(model);
            DeleteModelResponse modelResponse = _mapper.Map<DeleteModelResponse>(model);
            return modelResponse;
        }

        

        public GetModelListResponse GetList(GetModelListRequest request)
        {

            IList<Model> modelList = _modelDal.GetList(
            predicate: model =>
                (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
                && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId)
                && (
                    request.FilterByTransmissionId == null
                    || model.TransmissionId == request.FilterByTransmissionId
                )
        );
            var response = _mapper.Map<GetModelListResponse>(modelList);
            return response;
        }

        GetModelByIdResponse IModelService.GetById(GetModelByIdRequest request)
        {
            throw new NotImplementedException();
        }

    }
}