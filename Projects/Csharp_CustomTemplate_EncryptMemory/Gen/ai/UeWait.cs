
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Newtonsoft.Json;
using Scripts;







namespace cfg.ai
{
    [Serializable]
    public partial class UeWait : AConfig
    {
        [JsonProperty("wait_time")]
        private float _wait_time { get; set; }
        [JsonIgnore]
        public EncryptFloat wait_time { get; private set; } = new();

        [JsonProperty("random_deviation")]
        private float _random_deviation { get; set; }
        [JsonIgnore]
        public EncryptFloat random_deviation { get; private set; } = new();


        public override void EndInit() 
        {
            wait_time = _wait_time;
            random_deviation = _random_deviation;
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
