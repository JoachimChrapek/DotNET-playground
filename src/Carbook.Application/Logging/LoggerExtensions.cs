﻿using Microsoft.Extensions.Logging;

namespace Carbook.Application.Logging;

public static class LoggerExtensions
{
    public static IDisposable TimedOperation<T>(this ILogger<T> logger, LogLevel logLevel, string message)
    {
        return new TimedOperation<T>(logger, logLevel, message);
    }
}