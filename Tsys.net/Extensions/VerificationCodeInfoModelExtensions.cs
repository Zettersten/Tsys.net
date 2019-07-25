using System;
using System.Collections.Generic;
using System.Text;
using Tsys.net.Models.SubfieldRecords;
using Tsys.net.Models.Types;

namespace Tsys.net.Extensions
{
    public static class VerificationCodeInfoModelExtensions
    {
        public static string Serialize(this VerificationCodeInfoModel verificationCodeInfo)
        {
            return string.Format("{0}{1}{2}", verificationCodeInfo.CodePresenceIndicator, verificationCodeInfo.DesiredResponseIndicator, verificationCodeInfo.VerificationCode);
        }

        public static void SetVerificationCode(this VerificationCodeInfoModel verificationCodeInfo, string code)
        {
            verificationCodeInfo.CodePresenceIndicator = VerificationCodePresenceTypeModel.VerificationCodeIntentionallyNotProvided;

            if (code.Length >= 3)
            {
                verificationCodeInfo.CodePresenceIndicator = VerificationCodePresenceTypeModel.VerificationCodePresent;
                verificationCodeInfo.VerificationCode = code.Trim();
            }
            else if (code == "?")
            {
                verificationCodeInfo.CodePresenceIndicator = VerificationCodePresenceTypeModel.VerificationCodePresentButIllegible;
            }
        }
    }
}