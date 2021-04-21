using Tdms.Api;

namespace Csoft.Tdms.Common.Attributes {
    /// <summary>
    /// Invokes string value from TdmsAttribute by name or string.Empty
    /// </summary>
    public class StringTdmsAttributeValueBehavior : TdmsAttributeValueBehavior<string> {
        public StringTdmsAttributeValueBehavior(TDMSAttribute attribute) : base(
            attribute,
            new SafeInvocation<TDMSAttribute, string>(
                new Invocation<TDMSAttribute, string>(
                    attribute,
                    (attr) => attr.Value.ToString()
                )
            )
        ) { }
    }
}