namespace CP77SaveEditor.Core.Common
{
    public interface IReadSavegameProgress
    {
        void Report(bool running, bool indeterministic, int value, int max);
    }
}