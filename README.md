Logging is a mechanism that records application events during runtime.
ASP.NET Core provides a built-in logging abstraction using the ILogger interface.
Logging frameworks such as NLog, Serilog, and log4net can be integrated with ILogger.
Logs can be written to the console, files, databases, or centralized logging systems.
We can configure log levels using methods such as LogInformation, LogDebug, and LogError, and separate logs based on severity.
Logging helps in debugging issues, monitoring production systems, and auditing application behavior.



In this project, NLog is used as the logging framework to store application logs in files.

Steps to Use NLog in an ASP.NET Core Application

1. Install the NuGet package:
    NLog.Web.AspNetCore

2. Add an nlog.config file (XML) to configure NLog.

3. Define targets (where logs are written) and rules (which logs go where) inside nlog.config.

4. Update Program.cs to configure NLog:

    builder.Logging.ClearProviders(); // this removes default logging providers
    builder.Host.UseNLog(); // this enables nlog 

5. Inject and use ILogger<T> in controllers or service classes.
