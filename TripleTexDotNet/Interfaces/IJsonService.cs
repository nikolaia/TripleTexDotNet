namespace TripleTexDotNet.Interfaces
{
    public interface IJsonService
    {
        void ChangeUrl(string url);
        T Call<T>(string method, params object[] params_) where T : class;
    }
}
