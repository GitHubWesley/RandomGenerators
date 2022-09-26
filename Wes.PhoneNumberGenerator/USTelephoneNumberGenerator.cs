
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wes.Utility.Extensions;

namespace Wes.PhoneNumberGenerator
{
    public class USTelephoneNumberGenerator
    {
        private readonly AssetProvider _assetProvider;
        private readonly Random _random;

        public USTelephoneNumberGenerator()
        {
            _assetProvider = new AssetProvider();
            _random = new Random();
        }

        public string Generate()
        {
            TelephoneNumberModel telephoneNumberModel = new TelephoneNumberModel()
            {
                ContryCode = _assetProvider.GlobalContryCodes.FirstOrDefault(c => c.IsoCode == "US")?.DialCode ?? "+1",
                RegionCode = _assetProvider.UsAreaCodeDtos.GetOneRandomly().Code,
                ExchangeCode = _random.Next(000, 999),
                SubscriberNumber = _random.Next(0000, 9999)
            };

            return telephoneNumberModel.ToString();
        }
    }
}
