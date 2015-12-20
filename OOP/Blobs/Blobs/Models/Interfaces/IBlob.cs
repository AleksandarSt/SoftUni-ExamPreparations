namespace Blobs.Models.Interfaces
{
    public interface IBlob
    {
        string Name { get; }

        int Health { get; }

        int Damage { get; }
    }
}
