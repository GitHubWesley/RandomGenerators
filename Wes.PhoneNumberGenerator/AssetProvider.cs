using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wes.PhoneNumberGenerator
{
    internal class AssetProvider
    {
        private List<UsAreaCodeDto>? _usAreaCodes;

        public List<UsAreaCodeDto> UsAreaCodeDtos => _usAreaCodes ??= GetUsAreaCodes();


        private List<GlobalContryCodeDto>? _globalContryCodes;

        public List<GlobalContryCodeDto> GlobalContryCodes => _globalContryCodes ??= GetGlobalContryCodes();


        private List<GlobalContryCodeDto> GetGlobalContryCodes()
        {
            var jsonPath = Path.Combine(Environment.CurrentDirectory, AssetConsts.Directory, AssetConsts.GlobalContryCodes);
            var json = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<GlobalContryCodeDto>>(json) ?? new List<GlobalContryCodeDto>();
        }

        private List<UsAreaCodeDto> GetUsAreaCodes()
        {
            var jsonPath = Path.Combine(Environment.CurrentDirectory, AssetConsts.Directory, AssetConsts.UsAreaCodes);
            var json = File.ReadAllText(jsonPath);
            return JsonConvert.DeserializeObject<List<UsAreaCodeDto>>(json) ?? new List<UsAreaCodeDto>();
        }
    }

    internal static class AssetConsts
    {
        public const string Directory = "Assets";

        public const string GlobalContryCodes = "global_contry_code.json";

        public const string UsAreaCodes = "us_area_code.json";
    }

    internal class GlobalContryCodeDto
    {
        public string Name { get; set; }

        public string DialCode { get; set; }

        public string IsoCode { get; set; }
    }

    internal class UsAreaCodeDto
    {
        public int Code { get; set; }

        public string State { get; set; }
    }
}
