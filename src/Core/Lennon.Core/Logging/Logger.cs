﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lennon.Core.Logging
{
    /// <summary>
    /// 日志记录者
    /// </summary>
    public sealed class Logger : ILogger
    {
        internal Logger(Type type)
            : this(type.FullName)
        { }

        internal Logger(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 获取 日志记录者名称
        /// </summary>
        public string Name { get; private set; }

        #region Implementation of ILogger

        /// <summary>
        /// 写入<see cref="LogLevel.Trace"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Trace<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Trace(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Trace"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Trace(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Trace(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Debug"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Debug<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Debug(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Debug"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Debug(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Debug(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Info"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Info<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Info(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Info"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Info(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Info(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Warn"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Warn<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Warn(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Warn"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Warn(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Warn(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Error"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Error<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Error(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Error"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Error(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Error(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Error"/>日志消息，并记录异常
        /// </summary>
        /// <param name="message">日志消息</param>
        /// <param name="exception">异常</param>
        public void Error<T>(T message, Exception exception)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Error(message, exception);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Error"/>格式化日志消息，并记录异常
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="exception">异常</param>
        /// <param name="args">格式化参数</param>
        public void Error(string format, Exception exception, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Error(format, exception, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Fatal"/>日志消息
        /// </summary>
        /// <param name="message">日志消息</param>
        public void Fatal<T>(T message)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Fatal(message);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Fatal"/>格式化日志消息
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="args">格式化参数</param>
        public void Fatal(string format, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Fatal(format, args);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Fatal"/>日志消息，并记录异常
        /// </summary>
        /// <param name="message">日志消息</param>
        /// <param name="exception">异常</param>
        public void Fatal<T>(T message, Exception exception)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Fatal(message, exception);
            }
        }

        /// <summary>
        /// 写入<see cref="LogLevel.Fatal"/>格式化日志消息，并记录异常
        /// </summary>
        /// <param name="format">日志消息格式</param>
        /// <param name="exception">异常</param>
        /// <param name="args">格式化参数</param>
        public void Fatal(string format, Exception exception, params object[] args)
        {
            foreach (ILog log in LogManager.Adapters.Select(adapter => adapter.GetLogger(Name)))
            {
                log.Fatal(format, exception, args);
            }
        }

        #endregion
    }
}