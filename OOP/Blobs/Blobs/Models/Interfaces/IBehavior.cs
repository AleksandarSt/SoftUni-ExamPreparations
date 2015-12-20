namespace Blobs.Models.Interfaces
{
    public interface IBehavior
    {
        string Name { get; }

        void triggerBehavior();
    }
}
