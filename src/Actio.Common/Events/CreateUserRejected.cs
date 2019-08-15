namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public CreateUserRejected(string reason, string code, string email)
        {
            this.Reason = reason;
            this.Code = code;
            this.Email = email;

        }
        public string Reason { get; set; }
        public string Code { get; set; }
        public string Email { get; set; }
        protected CreateUserRejected()
        {

        }
    }
}