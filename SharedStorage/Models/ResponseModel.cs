namespace SharedStorage.Models
{
    public class ResponseModel<T>
    {
        public T? Result { get; set; }

        public bool HasError { get; set; }

        public string? Message { get; set; }
    }
}