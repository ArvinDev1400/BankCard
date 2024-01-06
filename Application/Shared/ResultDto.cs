namespace Application.Shared;
public class ResultDto
{
    public ResultDto(bool isSuccess , string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}


public class ResultDto<T>
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
}
