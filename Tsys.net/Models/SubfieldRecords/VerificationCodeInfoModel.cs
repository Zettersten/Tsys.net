using Tsys.net.Extensions;
using Tsys.net.Models.Types;

namespace Tsys.net.Models.SubfieldRecords
{
    public class VerificationCodeInfoModel
    {
        public VerificationCodeDesiredResponseTypeModel DesiredResponseIndicator { get; set; }

        public VerificationCodePresenceTypeModel CodePresenceIndicator { get; set; }

        public string VerificationCode { get; set; }

        public static VerificationCodeInfoModel NewVerificationCodeInfo(VerificationCodeDesiredResponseTypeModel desiredResponse, string code)
        {
            var result = new VerificationCodeInfoModel
            {
                DesiredResponseIndicator = desiredResponse
            };

            result.SetVerificationCode(code);

            return result;
        }

        public override string ToString()
        {
            return this.Serialize();
        }
    }
}