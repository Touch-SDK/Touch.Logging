﻿using System;
using Castle.Core.Logging;

namespace Touch.Logging
{
    /// <summary>
    /// Castle Windsor logger provider implementation.
    /// </summary>
    sealed public class CastleLoggerProvider : ILoggerProvider
    {
        #region Data
        private readonly ILoggerFactory _factory;
        #endregion

        #region .ctor
        public CastleLoggerProvider(ILoggerFactory factory)
        {
            _factory = factory;
        }
        #endregion

        #region ILoggerProvider implementation
        public ILogger Get<T>() where T : class
        {
            return Get(typeof(T));
        }

        public ILogger Get(Type type)
        {
            return new CastleLogger(_factory.Create(type));
        }
        #endregion
    }
}
