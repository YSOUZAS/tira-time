namespace TT.Reader.Interfaces
{
    public interface IReader
    {
        public List<T> Read<T>(string filePath, Func<T, bool> predicate) where T : class;
    }
}
