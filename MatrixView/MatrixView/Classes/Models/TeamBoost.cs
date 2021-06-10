using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixView.Classes.Models
{
    class TeamBoost
    {
        public class Root
        {
            [JsonProperty("availableSkins")]
            public List<object> AvailableSkins { get; set; }

            [JsonProperty("ipReward")]
            public int IpReward { get; set; }

            [JsonProperty("ipRewardForPurchaser")]
            public int IpRewardForPurchaser { get; set; }

            [JsonProperty("price")]
            public int Price { get; set; }

            [JsonProperty("skinUnlockMode")]
            public string SkinUnlockMode { get; set; }

            [JsonProperty("summonerId")]
            public int SummonerId { get; set; }

            [JsonProperty("unlocked")]
            public bool Unlocked { get; set; }
        }
    }
}
