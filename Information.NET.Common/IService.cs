using System.Threading.Tasks;

namespace Information
{
    public interface IService
    {
        Task<ITextMessage> PostMessageAsync(string message);
    }
}
