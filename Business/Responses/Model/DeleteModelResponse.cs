namespace Business.Responses.Model;

public class DeleteModelResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DeletedAt { get; set; }

    public DeleteModelResponse() { }
    public DeleteModelResponse(int id, string name) 
    {  Id = id; 
       Name = name; 
    }

}
