using System.Runtime.Serialization;

namespace Sender.UniOne.ApiClient.Common
{
    public enum TemplateEngineEnum
    {
        [EnumMember(Value = "simple")]
        Simple,

        [EnumMember(Value = "velocity")]
        Velocity
    }
}
