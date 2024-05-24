#nullable disable

namespace Application.Wrappers;

public class Response<T>
{
    public T Data { get; set; }
    public bool Succeeded { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; }

    private Response() { }

    public Response(T data, string message = null)
    {
        Data = data;
        Message = message;
        Succeeded = true;
        Errors = new List<string>();
    }

    public Response(string message)
    {
        Message = message;
        Succeeded = false;
        Errors = new List<string>();
    }
}
