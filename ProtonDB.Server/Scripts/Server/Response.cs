namespace ProtonDB.Server {
    public class Response {
        public string Status { get; set; } = "ok";
        public string Message { get; set; } = "";
        public string[]? Result { get; set; }
    }
}