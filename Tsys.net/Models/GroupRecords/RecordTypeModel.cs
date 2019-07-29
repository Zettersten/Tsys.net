using System;
using System.Text;

namespace Tsys.net.Models.GroupRecords
{
    public struct RecordTypeModel
    {
        public const char HeaderRecord = 'H';
        public const char ParameterRecord = 'P';
        public const char Parameter = 'P';
        public const char DetailRecord = 'T';
        public const char AmericanExpressLineItemDetailRecord = 'A';
        public const char TrailerRecord = 'T';
        public const char TrailerResponseRecord = 'R';
        public const char CommercialCardLineItemDetailRecord = 'L';
        public const char EncryptedTransmissionBlockRecord = 'E';
        public const char ChipCardAddendumRecord = 'C';
        public const char CanadianTaxLineItemDetailRecord = 'X';
        public const char GeneralAirlineTravelCruiseRecord = 'G';
        public const char BatchInquiry = 'I';

        private readonly char recordTypeIdentifier;

        public RecordTypeModel(char recordTypeIdentifier)
        {
            this.recordTypeIdentifier = recordTypeIdentifier;

            GroupsI = new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 };
            GroupsII = new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 };
            GroupsIII = new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 };
            GroupsIIII = new byte[] { 0, 1, 0, 0, 0, 0, 0, 0 };
        }

        private byte[] GroupsI { get; set; }

        private byte[] GroupsII { get; set; }

        private byte[] GroupsIII { get; set; }

        private byte[] GroupsIIII { get; set; }

        public static implicit operator RecordTypeModel(char value)
        {
            return new RecordTypeModel(value);
        }

        public static implicit operator RecordTypeModel(string value)
        {
            var recordType = value[0];
            var recordBytes = Encoding.ASCII.GetBytes(value);

            RecordTypeModel result = recordType;

            result.GroupsI = GetBytesWithinRange(recordBytes, 1);
            result.GroupsII = GetBytesWithinRange(recordBytes, 2);
            result.GroupsIII = GetBytesWithinRange(recordBytes, 3);
            result.GroupsIIII = GetBytesWithinRange(recordBytes, 4);

            return result;
        }

        public void SetGroups(int value)
        {
            const int totalBits = 6;

            if (value < 24)
            {
                if (value >= 1 && value <= 6)
                {
                    var rightIndex = value - (totalBits * 0);

                    // set group 1
                    ToggleByteFromRightToLeft(GroupsIIII, rightIndex);
                    return;
                }

                if (value >= 7 && value <= 12)
                {
                    var rightIndex = value - (totalBits * 1);

                    // set group 2
                    ToggleByteFromRightToLeft(GroupsIII, rightIndex);
                    return;
                }

                if (value >= 13 && value <= 18)
                {
                    var rightIndex = value - (totalBits * 2);

                    // set group 3
                    ToggleByteFromRightToLeft(GroupsII, rightIndex);
                    return;
                }

                if (value >= 19 && value <= 24)
                {
                    var rightIndex = value - (totalBits * 3);

                    // set group 4
                    ToggleByteFromRightToLeft(GroupsI, rightIndex);
                    return;
                }
            }
            else
            {
                if (value >= 25 && value <= 30)
                {
                    var rightIndex = value - (totalBits * 4);

                    // set group 1
                    ToggleByteFromRightToLeft(GroupsIIII, rightIndex);
                    return;
                }

                if (value >= 31 && value <= 36)
                {
                    var rightIndex = value - (totalBits * 5);

                    // set group 2
                    ToggleByteFromRightToLeft(GroupsIII, rightIndex);
                    return;
                }

                if (value >= 37 && value <= 42)
                {
                    var rightIndex = value - (totalBits * 6);

                    // set group 3
                    ToggleByteFromRightToLeft(GroupsII, rightIndex);
                    return;
                }

                if (value >= 43 && value <= 48)
                {
                    var rightIndex = value - (totalBits * 7);

                    // set group 4
                    ToggleByteFromRightToLeft(GroupsI, rightIndex);
                    return;
                }
            }

            throw new ArgumentException(nameof(value));
        }

        public override string ToString()
        {
            var result = new char[5];

            result[0] = recordTypeIdentifier;
            result[1] = ConvertBytesToString(GroupsI);
            result[2] = ConvertBytesToString(GroupsII);
            result[3] = ConvertBytesToString(GroupsIII);
            result[4] = ConvertBytesToString(GroupsIIII);

            return new string(result);
        }

        public string ToStringWithoutHeader()
        {
            var result = new char[4];

            result[0] = ConvertBytesToString(GroupsI);
            result[1] = ConvertBytesToString(GroupsII);
            result[2] = ConvertBytesToString(GroupsIII);
            result[3] = ConvertBytesToString(GroupsIIII);

            return new string(result);
        }

        private static char ConvertBytesToString(byte[] bytes)
        {
            var str = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", 0, 1, bytes[2], bytes[3], bytes[4], bytes[5], bytes[6], bytes[7]);

            return (char)Convert.ToInt32(value: str, fromBase: 2);
        }

        private static void ToggleByteFromRightToLeft(byte[] byteRef, int index)
        {
            var byteIndex = byteRef.Length - index;
            byteRef[byteIndex] = 1;
        }

        private static byte[] GetBytesWithinRange(byte[] allBytes, int group)
        {
            var result = new byte[8] { 0, 1, 0, 0, 0, 0, 0, 0 };

            var currentSet = allBytes[group];
            var binarySet = Convert.ToString(currentSet, 2);

            result[2] = byte.Parse(binarySet[1].ToString());
            result[3] = byte.Parse(binarySet[2].ToString());
            result[4] = byte.Parse(binarySet[3].ToString());
            result[5] = byte.Parse(binarySet[4].ToString());
            result[6] = byte.Parse(binarySet[5].ToString());
            result[7] = byte.Parse(binarySet[6].ToString());

            return result;
        }
    }
}