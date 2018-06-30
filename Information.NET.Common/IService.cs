using System.Threading.Tasks;

namespace Information
{
    public interface IService
    {
        ITextMessage PostMessage(string message);
        Task<ITextMessage> PostMessageAsync(string message);
    }
}
