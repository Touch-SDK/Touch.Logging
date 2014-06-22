// Copyright 2004-2008 Castle Project - http://www.castleproject.org/
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

using System;
using System.IO;
using log4net.Config;
using log4net.Core;
using System.Reflection;

namespace Touch.Logging
{
    [Serializable]
    sealed public class Log4NetLogger : ILogger
    {
        public Log4NetLogger() :
            this(null)
        {
        }

        public Log4NetLogger(string configPath)
        {
            _logger = log4net.LogManager.GetLogger(Assembly.GetCallingAssembly(), String.Empty).Logger;

            try
            {
                if (!string.IsNullOrEmpty(configPath))
                    XmlConfigurator.Configure(new FileInfo(configPath));
                else
                    XmlConfigurator.Configure();
            }
            catch
            {
                BasicConfigurator.Configure();
            }
        }

        private Type _ownerType = typeof(Log4NetLogger);
        public Type OwnerType
        {
            get { return _ownerType; }
            set { _ownerType = value; }
        }

        public IDisposable Stack(string name)
        {
            return log4net.LogicalThreadContext.Stacks["NDC"].Push(name);
        }

        private readonly log4net.Core.ILogger _logger;
        private log4net.Core.ILogger Logger
        {
            get { return _logger; }
        }

        public override string ToString()
        {
            return Logger.ToString();
        }

        #region Debug

        public void Debug(String message)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, message, null);
            }
        }

        public void Debug(String message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, message, exception);
            }
        }

        public void DebugFormat(String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, String.Format(format, args), null);
            }
        }

        public void DebugFormat(Exception exception, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, String.Format(format, args), exception);
            }
        }

        public void DebugFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, String.Format(formatProvider, format, args), null);
            }
        }

        public void DebugFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Log(_ownerType, Level.Debug, String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Info

        public void Info(String message)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, message, null);
            }
        }

        public void Info(String message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, message, exception);
            }
        }

        public void InfoFormat(String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, String.Format(format, args), null);
            }
        }

        public void InfoFormat(Exception exception, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, String.Format(format, args), exception);
            }
        }

        public void InfoFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, String.Format(formatProvider, format, args), null);
            }
        }

        public void InfoFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Log(_ownerType, Level.Info, String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Warn

        public void Warn(String message)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, message, null);
            }
        }

        public void Warn(String message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, message, exception);
            }
        }

        public void WarnFormat(String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, String.Format(format, args), null);
            }
        }

        public void WarnFormat(Exception exception, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, String.Format(format, args), exception);
            }
        }

        public void WarnFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, String.Format(formatProvider, format, args), null);
            }
        }

        public void WarnFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Log(_ownerType, Level.Warn, String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Error

        public void Error(String message)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, message, null);
            }
        }

        public void Error(String message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, message, exception);
            }
        }

        public void ErrorFormat(String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, String.Format(format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, String.Format(format, args), exception);
            }
        }

        public void ErrorFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, String.Format(formatProvider, format, args), null);
            }
        }

        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Log(_ownerType, Level.Error, String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Fatal

        public void Fatal(String message)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, message, null);
            }
        }

        public void Fatal(String message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, message, exception);
            }
        }

        public void FatalFormat(String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, String.Format(format, args), null);
            }
        }

        public void FatalFormat(Exception exception, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, String.Format(format, args), exception);
            }
        }

        public void FatalFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, String.Format(formatProvider, format, args), null);
            }
        }

        public void FatalFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Log(_ownerType, Level.Fatal, String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Is (...) Enabled

        public bool IsErrorEnabled
        {
            get { return Logger.IsEnabledFor(Level.Error); }
        }

        public bool IsWarnEnabled
        {
            get { return Logger.IsEnabledFor(Level.Warn); }
        }

        public bool IsDebugEnabled
        {
            get { return Logger.IsEnabledFor(Level.Debug); }
        }

        public bool IsFatalEnabled
        {
            get { return Logger.IsEnabledFor(Level.Fatal); }
        }

        public bool IsInfoEnabled
        {
            get { return Logger.IsEnabledFor(Level.Info); }
        }

        #endregion
    }
}
