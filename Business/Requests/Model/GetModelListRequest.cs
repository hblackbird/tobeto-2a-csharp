﻿namespace Business.Requests.Model;

public class GetModelListRequest
{
    public int? FilterByBrandId { get; set; }
    public int? FilterByFuelId { get; set; }
    public int? FilterByTransmissionId { get; set; }

}
