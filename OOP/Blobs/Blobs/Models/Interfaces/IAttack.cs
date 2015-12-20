namespace Blobs.Models.Interfaces
{
    public interface IAttack
    {
        string Name { get; }
        void ExecuteAttack();
    }
}
