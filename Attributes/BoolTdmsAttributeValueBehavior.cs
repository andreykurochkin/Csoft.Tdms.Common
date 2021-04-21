﻿using System;
using Tdms.Api;

namespace Csoft.Tdms.Common.Attributes {
    /// <summary>
    /// Invokes bool value from TdmsAttributes by name
    /// </summary>
    public class BoolTdmsAttributeValueBehavior : TdmsAttributeValueBehavior<bool> {
        public BoolTdmsAttributeValueBehavior(TDMSAttribute attribute) : base(
            attribute,
            new SafeInvocation<TDMSAttribute, bool>(
                new Invocation<TDMSAttribute, bool>(
                    attribute,
                    (attr) => Convert.ToBoolean(attr.Value)
                )
            )
        ) { }
    }
}