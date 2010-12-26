// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Services.Logging.NLogIntegration
{
	using System;

	using Castle.Core.Logging;

	using NLog;

	/// <summary>
	///   Implementation of <see cref = "ILogger" /> for NLog.
	/// </summary>
	public class NLogLogger : ILogger
	{
		/// <summary>
		///   Initializes a new instance of the <see cref = "NLogLogger" /> class.
		/// </summary>
		/// <param name = "logger">The logger.</param>
		/// <param name = "factory">The factory.</param>
		public NLogLogger(Logger logger, NLogFactory factory)
		{
			Logger = logger;
			Factory = factory;
		}

		internal NLogLogger()
		{
		}

		/// <summary>
		///   Determines if messages of priority "debug" will be logged.
		/// </summary>
		/// <value>True if "debug" messages will be logged.</value>
		public bool IsDebugEnabled
		{
			get { return Logger.IsDebugEnabled; }
		}

		/// <summary>
		///   Determines if messages of priority "error" will be logged.
		/// </summary>
		/// <value><c>true</c> if "error" messages will be logged, <c>false</c> otherwise</value>
		public bool IsErrorEnabled
		{
			get { return Logger.IsErrorEnabled; }
		}

		/// <summary>
		///   Determines if messages of priority "fatal" will be logged.
		/// </summary>
		/// <value><c>true</c> if "fatal" messages will be logged, <c>false</c> otherwise</value>
		public bool IsFatalEnabled
		{
			get { return Logger.IsFatalEnabled; }
		}

		/// <summary>
		///   Determines if messages of priority "info" will be logged.
		/// </summary>
		/// <value><c>true</c> if "info" messages will be logged, <c>false</c> otherwise</value>
		public bool IsInfoEnabled
		{
			get { return Logger.IsInfoEnabled; }
		}

		/// <summary>
		///   Determines if messages of priority "warn" will be logged.
		/// </summary>
		/// <value><c>true</c> if "warn" messages will be logged, <c>false</c> otherwise</value>
		public bool IsWarnEnabled
		{
			get { return Logger.IsWarnEnabled; }
		}

		/// <summary>
		///   Gets or sets the factory.
		/// </summary>
		/// <value>The factory.</value>
		protected internal NLogFactory Factory { get; set; }

		/// <summary>
		///   Gets or sets the logger.
		/// </summary>
		/// <value>The logger.</value>
		protected internal Logger Logger { get; set; }

		/// <summary>
		///   Returns a <see cref = "String" /> that represents this instance.
		/// </summary>
		/// <returns>
		///   A <see cref = "String" /> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return Logger.ToString();
		}

		/// <summary>
		///   Creates a child logger with the specied <paramref name = "name" />.
		/// </summary>
		/// <param name = "name">The name.</param>
		/// <returns></returns>
		public virtual ILogger CreateChildLogger(String name)
		{
			return Factory.Create(Logger.Name + "." + name);
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "message">The message to log</param>
		public void Debug(string message)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.Debug(message);
			}
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "message">The message to log</param>
		public void Debug(string message, Exception exception)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.DebugException(message, exception);
			}
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void DebugFormat(string format, params object[] args)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.Debug(format, args);
			}
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void DebugFormat(Exception exception, string format, params object[] args)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.DebugException(String.Format(format, args), exception);
			}
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.Debug(formatProvider, format, args);
			}
		}

		/// <summary>
		///   Logs a debug message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsDebugEnabled)
			{
				Logger.DebugException(String.Format(formatProvider, format, args), exception);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "message">The message to log</param>
		public void Error(string message)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.Error(message);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "message">The message to log</param>
		public void Error(string message, Exception exception)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.ErrorException(message, exception);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void ErrorFormat(string format, params object[] args)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.Error(format, args);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void ErrorFormat(Exception exception, string format, params object[] args)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.ErrorException(String.Format(format, args), exception);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.Error(formatProvider, format, args);
			}
		}

		/// <summary>
		///   Logs an error message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsErrorEnabled)
			{
				Logger.ErrorException(String.Format(formatProvider, format, args), exception);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "message">The message to log</param>
		public void Fatal(string message)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.Fatal(message);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "message">The message to log</param>
		public void Fatal(string message, Exception exception)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.FatalException(message, exception);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void FatalFormat(string format, params object[] args)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.Fatal(format, args);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void FatalFormat(Exception exception, string format, params object[] args)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.FatalException(String.Format(format, args), exception);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.Fatal(formatProvider, format, args);
			}
		}

		/// <summary>
		///   Logs a fatal message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsFatalEnabled)
			{
				Logger.FatalException(String.Format(formatProvider, format, args), exception);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "message">The message to log</param>
		public void Info(string message)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.Info(message);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "message">The message to log</param>
		public void Info(string message, Exception exception)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.InfoException(message, exception);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void InfoFormat(string format, params object[] args)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.Info(format, args);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void InfoFormat(Exception exception, string format, params object[] args)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.InfoException(String.Format(format, args), exception);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.Info(formatProvider, format, args);
			}
		}

		/// <summary>
		///   Logs an info message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsInfoEnabled)
			{
				Logger.InfoException(String.Format(formatProvider, format, args), exception);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "message">The message to log</param>
		public void Warn(string message)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.Warn(message);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "message">The message to log</param>
		public void Warn(string message, Exception exception)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.WarnException(message, exception);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void WarnFormat(string format, params object[] args)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.Warn(format, args);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void WarnFormat(Exception exception, string format, params object[] args)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.WarnException(String.Format(format, args), exception);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.Warn(formatProvider, format, args);
			}
		}

		/// <summary>
		///   Logs a warn message.
		/// </summary>
		/// <param name = "exception">The exception to log</param>
		/// <param name = "formatProvider">The format provider to use</param>
		/// <param name = "format">Format string for the message to log</param>
		/// <param name = "args">Format arguments for the message to log</param>
		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			if (Logger.IsWarnEnabled)
			{
				Logger.WarnException(String.Format(formatProvider, format, args), exception);
			}
		}
	}
}