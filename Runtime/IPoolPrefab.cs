namespace LazyCoder.Pool
{
    public interface IPoolPrefab 
    {
        void OnGet();
        void OnRelease();
    }
}
