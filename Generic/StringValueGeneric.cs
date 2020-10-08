namespace Generic
{
    public class StringValueGeneric
    {
        public static string convertString<T>(T t)
        {
            return t.ToString();
        }
    }
}
