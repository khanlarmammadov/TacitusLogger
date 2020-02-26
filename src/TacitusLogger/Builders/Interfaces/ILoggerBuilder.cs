﻿using System.ComponentModel;
using TacitusLogger.Destinations;
using TacitusLogger.LogIdGenerators;
using TacitusLogger.Strategies.ExceptionHandling;
using TacitusLogger.Strategies.LogCreation;

namespace TacitusLogger.Builders
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface ILoggerBuilder
    {
        ILoggerBuilder WithLogLevel(Setting<LogLevel> logLevel);
        ILoggerBuilder WithLogIdGenerator(ILogIdGenerator logIdGenerator);
        ILogContributorsBuilder Contributors();
        ILogTransformersBuilder Transformers();
        ILoggerBuilder WithLogCreation(LogCreationStrategyBase logCreationStrategy);
        ILoggerBuilder WithExceptionHandling(ExceptionHandlingStrategyBase exceptionHandlingStrategy);
        ILoggerBuilder WithSelfMonitoring(ILogDestination selfMonitoringDestination);
        ILoggerBuilder WriteLoggerConfigurationToDiagnostics(bool should);
        ILoggerBuilder NewLogGroup(LogGroupBase logGroup);
        ILogGroupBuilder NewLogGroup(string logGroupName);
        ILogGroupBuilder NewLogGroup();
        Logger BuildLogger();
    }
}
