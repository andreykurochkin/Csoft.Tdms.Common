using Tdms.Api;

namespace Csoft.Tdms.Common.Attributes {
    /// <summary>
    /// Invokes TdmsObject from TdmsAttribute
    /// </summary>
    public class TdmsObjectTdmsAttributeValueBehavior : TdmsAttributeValueBehavior<TDMSObject> {
        public TdmsObjectTdmsAttributeValueBehavior(TDMSAttribute attribute) : base(
            attribute,
            new SafeInvocation<TDMSAttribute, TDMSObject>(
                new Invocation<TDMSAttribute, TDMSObject>(
                    attribute, 
                    (attr) => attr.Object
                )
            )
        ) { }
    }
}