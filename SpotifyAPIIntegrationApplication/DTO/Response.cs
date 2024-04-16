namespace SpotifyAPIIntegrationApplication.DTO
{
    public class Response<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }

        public T Data { get; set; }
    }
}
