using Cysharp.Threading.Tasks;

namespace Services
{
    public interface IGameService
    {
        public UniTask<bool> TryInitialize();
    }
}