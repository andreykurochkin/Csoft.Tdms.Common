using Tdms.Api;

namespace Csoft.Tdms.Common.Attributes {
    /// <summary>
    /// Invokes TdmsUser from TdmsAttribute
    /// </summary>
    public class TdmsUserTdmsAttributeValueBehavior : TdmsAttributeValueBehavior<TDMSUser> {
        public TdmsUserTdmsAttributeValueBehavior(TDMSAttribute attribute) : base(
            attribute,
            new SafeInvocation<TDMSAttribute, TDMSUser>(
                new Invocation<TDMSAttribute, TDMSUser>(
                    attribute,
                    (attr) => attr.User
                )
            )
        ) { }
    }
}
