namespace nothinbutdotnetstore.stubs
{
    public class Stub
    {
        public static StubImplementation with<StubImplementation>() where StubImplementation : new()
        {
            return new StubImplementation();
        }
    }
}