using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.PhoneNumberGenerator
{
    internal class TelephoneNumberModel
    {
        public string ContryCode { get; set; }

        public int RegionCode { get; set; }

        /// <summary>
        /// Central Office or Exchange Code. 3 bit
        /// </summary>
        public int ExchangeCode { get; set; }

        /// <summary>
        /// Line Number or Subscriber Number. 4 bit
        /// </summary>
        public int SubscriberNumber { get; set; }


        public override string ToString()
        {
            return $"+({ContryCode.Replace("+", "")})({RegionCode}) {ExchangeCode}-{SubscriberNumber}";
        }
    }
}
