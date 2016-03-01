namespace iBookie.Features.Repository
{
    public interface IRepository<out T> where T : class
    {
        T Search(string searchUrl);
    }
}
