namespace TokenExample
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserApplcation[] Applications { get; set; }
    }

    public class Application
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class UserApplcation
    {
        public Profile Profile { get; set; }
        public Application Application { get; set; }
    }

    public enum Profile
    {
        Admin,
        User
    }
}
