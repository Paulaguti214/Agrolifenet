namespace Agrolifenet.FrontEnd.Puerto
{
    public interface ILoginServicio
    {
        Task LoginAsync(string Token);
        Task LogoutAsync();
    }
}
