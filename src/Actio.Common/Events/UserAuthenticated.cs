namespace Actio.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public UserAuthenticated(string email)
        {
            Email = email;
        }

        protected UserAuthenticated()
        {

        }

        public string Email { get; set; }

    }
}