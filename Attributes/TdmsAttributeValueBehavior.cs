﻿using Tdms.Api;

namespace Csoft.Tdms.Common.Attributes {
    public abstract class TdmsAttributeValueBehavior<TResult> {
        protected IInvokable<TDMSAttribute, TResult> Invocation { get; }
        public TdmsAttributeValueBehavior(TDMSAttribute attribute, IInvokable<TDMSAttribute, TResult> invocation) {
            Invocation = invocation;
        }
        public TResult GetValue() {
            return Invocation.Invoke();
        }
    }
}