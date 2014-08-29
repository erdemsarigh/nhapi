namespace ModelGenerator
{
    using System;
    using System.Configuration;

    using Microsoft.Test.CommandLineParsing;

    using NHapi.Base.SourceGeneration;

    public class ModelBuilder : Command
    {
        #region Constructors and Destructors

        public ModelBuilder()
        {
            this.BasePath = @"D:\projects\nhapi\SourceForge\nhapi20";
            this.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            this.MessageTypeToBuild = MessageType.All;
        }

        #endregion

        #region Enums

        public enum MessageType
        {
            All,

            Message,

            Segment,

            DataType,

            EventMapping
        }

        #endregion

        #region Public Properties

        public string BasePath { get; set; }

        public string ConnectionString { get; set; }

        public MessageType MessageTypeToBuild { get; set; }

        public string Version { get; set; }

        #endregion

        #region Public Methods and Operators

        public override void Execute()
        {
            NHapi.Base.NormativeDatabase.Instance.OpenNewConnection(this.ConnectionString);

            Console.WriteLine("Using Database:{0}", NHapi.Base.NormativeDatabase.Instance.Connection.ConnectionString);
            Console.WriteLine("Base Path:{0}", this.BasePath);

            switch (this.MessageTypeToBuild)
            {
                case MessageType.All:
                    SourceGenerator.makeAll(this.BasePath, this.Version);
                    break;
                case MessageType.EventMapping:
                    SourceGenerator.MakeEventMapping(this.BasePath, this.Version);
                    break;
                case MessageType.Segment:
                    SegmentGenerator.makeAll(this.BasePath, this.Version);
                    break;
                case MessageType.Message:
                    MessageGenerator.makeAll(this.BasePath, this.Version);
                    break;
            }
        }

        #endregion
    }
}