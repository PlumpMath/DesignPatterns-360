namespace Builder
{
    public interface IDatabaseBuilder
    {
        void BuildConnection();
        void BuildCommand();
        void SetSettings();
        Database Database { get; }
    }
}
