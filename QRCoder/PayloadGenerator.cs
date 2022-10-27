using System;

namespace QRCoder {
    public static class PayloadGenerator {
        public abstract class Payload {
            public virtual int Version { get { return -1; } }
            public virtual QRCodeGenerator.ECCLevel EccLevel { get { return QRCodeGenerator.ECCLevel.M; } }
            public virtual QRCodeGenerator.EciMode EciMode { get { return QRCodeGenerator.EciMode.Default; } }
            public abstract override string ToString();
        }

        public static bool ChecksumMod10(string digits) {
            if (string.IsNullOrEmpty(digits) || digits.Length < 2)
                return false;
            int[] mods = new int[] { 0, 9, 4, 6, 8, 2, 7, 1, 3, 5 };

            int remainder = 0;
            for (int i = 0;i < digits.Length - 1;i++) {
                var num = Convert.ToInt32(digits[i]) - 48;
                remainder = mods[(num + remainder) % 10];
            }
            var checksum = (10 - remainder) % 10;
            return checksum == Convert.ToInt32(digits[digits.Length - 1]) - 48;
        }

    }
}
