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
using log4net;

namespace Touch.Logging
{
    [Serializable]
    sealed public class Log4NetLogger : ILogger
    {
        public Log4NetLogger(ILog logger)
        {
            if (logger == null) throw new ArgumentNullException("logger");
            _logger = logger;
        }

        private readonly ILog _logger;
        private ILog Logger
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
                Logger.Debug(message);
            }
        }

        public void Debug(String message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                Logger.Debug(message, exception);
            }
        }

        public void DebugFormat(String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Debug(String.Format(format, args));
            }
        }

        public void DebugFormat(Exception exception, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Debug(String.Format(format, args), exception);
            }
        }

        public void DebugFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Debug(String.Format(formatProvider, format, args));
            }
        }

        public void DebugFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsDebugEnabled)
            {
                Logger.Debug(String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Info

        public void Info(String message)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(message);
            }
        }

        public void Info(String message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(message, exception);
            }
        }

        public void InfoFormat(String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(String.Format(format, args));
            }
        }

        public void InfoFormat(Exception exception, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(String.Format(format, args), exception);
            }
        }

        public void InfoFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(String.Format(formatProvider, format, args));
            }
        }

        public void InfoFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsInfoEnabled)
            {
                Logger.Info(String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Warn

        public void Warn(String message)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(message);
            }
        }

        public void Warn(String message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(message, exception);
            }
        }

        public void WarnFormat(String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(String.Format(format, args));
            }
        }

        public void WarnFormat(Exception exception, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(String.Format(format, args), exception);
            }
        }

        public void WarnFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(String.Format(formatProvider, format, args));
            }
        }

        public void WarnFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsWarnEnabled)
            {
                Logger.Warn(String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Error

        public void Error(String message)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(message);
            }
        }

        public void Error(String message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(message, exception);
            }
        }

        public void ErrorFormat(String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(String.Format(format, args));
            }
        }

        public void ErrorFormat(Exception exception, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(String.Format(format, args), exception);
            }
        }

        public void ErrorFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(String.Format(formatProvider, format, args));
            }
        }

        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsErrorEnabled)
            {
                Logger.Error(String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Fatal

        public void Fatal(String message)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(message);
            }
        }

        public void Fatal(String message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(message, exception);
            }
        }

        public void FatalFormat(String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(String.Format(format, args));
            }
        }

        public void FatalFormat(Exception exception, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(String.Format(format, args), exception);
            }
        }

        public void FatalFormat(IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(String.Format(formatProvider, format, args));
            }
        }

        public void FatalFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
        {
            if (IsFatalEnabled)
            {
                Logger.Fatal(String.Format(formatProvider, format, args), exception);
            }
        }

        #endregion

        #region Is (...) Enabled

        public bool IsErrorEnabled
        {
            get { return Logger.IsErrorEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return Logger.IsWarnEnabled; }
        }

        public bool IsDebugEnabled
        {
            get { return Logger.IsDebugEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return Logger.IsFatalEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return Logger.IsInfoEnabled; }
        }

        #endregion
    }
}
