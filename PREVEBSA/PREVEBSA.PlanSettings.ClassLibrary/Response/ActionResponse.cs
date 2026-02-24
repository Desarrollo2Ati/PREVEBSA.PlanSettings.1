namespace PREVEBSAPlanSettingsClassLibrary.Response
{
    public class ActionResponse<T>
    {
        public bool IsSuccess { get; set; }

        public bool WasSuccess { get; set; }

        public string? Message { get; set; }

        public T? Result { get; set; }

        public List<string> Logs { get; set; } = new List<string>();
    }
}
