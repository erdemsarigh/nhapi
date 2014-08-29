namespace ModelGenerator
{
    using Microsoft.Test.CommandLineParsing;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            ModelBuilder builder = new ModelBuilder();
            builder.ParseArguments(args);
            builder.Execute();
        }

        #endregion
    }
}