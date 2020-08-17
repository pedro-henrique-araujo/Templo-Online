namespace TemploOnline.Models.ApiModels
{
  public class ResultMessage
  {
    public ResultMessage()
    {
        
    }

    public ResultMessage(string title, string message)
    {
      Title = title;
      Message = message;
    }

    public string Title { get; set; }
    public string Message { get; set; }
  }
}