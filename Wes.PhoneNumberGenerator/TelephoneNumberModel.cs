using System;
using System.Collections.Generic;
using System.Text;

namespace Wes.PhoneNumberGenerator
{
    internal class TelephoneNumberModel
    {
        public char[] ContryCode { get; set; }

        public char[] RegionCode { get; set; }

        /// <summary>
        /// Central Office or Exchange Code. 3 bit
        /// </summary>
        public char[] ExchangeCode { get; set; }

        /// <summary>
        /// Line Number or Subscriber Number. 4 bit
        /// </summary>
        public char[] SubscriberNumber { get; set; }


        public override string ToString()
        {
            return $"+({ContryCode})({RegionCode}) {ExchangeCode} {SubscriberNumber}";
        }
    }
}
