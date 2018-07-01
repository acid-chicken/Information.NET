namespace Information
{
    public interface IMessage
    {
    }

    public interface ITextMessage : IMessage
    {
        string Text { get; }
    }
}
