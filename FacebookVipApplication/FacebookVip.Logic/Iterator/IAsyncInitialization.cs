﻿using System.Threading.Tasks;

namespace FacebookVip.Logic.Iterator
{

    /// Marks a type as requiring asynchronous initialization and provides the result of that initialization.
    public interface IAsyncInitialization
    {
        /// <summary>
        /// The result of the asynchronous initialization of this instance.
        /// </summary>
        Task Initialization { get; }
    }
}
