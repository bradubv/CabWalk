namespace MyModule
{
    public interface IMyView
    {
        event EventHandler Load;
        string Message { get; set; }
    }
}
