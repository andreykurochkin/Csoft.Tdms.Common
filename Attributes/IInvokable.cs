﻿using System;

namespace Csoft.Tdms.Common.Attributes {
    /// <summary>
    /// invokes encapsulated delegate
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public interface IInvokable<T, TResult> {
        public T Target { get; }
        public Func<T, TResult> Command { get; }
        public TResult Invoke();
    }
}