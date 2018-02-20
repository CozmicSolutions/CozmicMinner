namespace CozmicMinner.Classes
{
    using System.Collections.Generic;

    using CozmicMinner.Connection;

    using Newtonsoft.Json;

    public static class ApiQuery
    {
        /// <summary>
        /// GetCredits
        /// </summary>
        /// <returns></returns>
        public static List<Credits> GetCredits()
        {
            var creditList = new List<Credits>();
            var respone = ApiConnection.Get(@"http://api.ethpool.org", @"credits");
            var receivedData = JsonConvert.DeserializeObject <ApiResponseArray> (respone.ToString());
            foreach (var cred in receivedData.data)
            {
                creditList.Add(JsonConvert.DeserializeObject<Credits>(cred.ToString()));
            }

            return creditList;
        }

        /// <summary>
        /// GetBlocksHistory
        /// </summary>
        /// <returns></returns>
        public static List<Blocks> GetBlocksHistory()
        {
            var blockList = new List<Blocks>();
            var response = ApiConnection.Get(@"http://api.ethpool.org", @"blocks/history");
            var receivedData = JsonConvert.DeserializeObject<ApiResponseArray>(response.ToString());
            foreach (var cred in receivedData.data)
            {
                blockList.Add(JsonConvert.DeserializeObject<Blocks>(cred.ToString()));
            }

            return blockList;
        }

        /// <summary>
        /// GetNetworkStats
        /// </summary>
        /// <returns></returns>
        public static List<NetworkStats> GetNetworkStats()
        {
            var networkStatList = new List<NetworkStats>();
            var response = ApiConnection.Get(@"http://api.ethpool.org", @"networkStats");
            var receivedData = JsonConvert.DeserializeObject<ApiResponseObject>(response.ToString());
            networkStatList.Add(JsonConvert.DeserializeObject<NetworkStats>(receivedData.data.ToString()));
            

            return networkStatList;
        }


        /// <summary>
        /// GetBlocksHistory
        /// </summary>
        /// <returns></returns>
        public static List<HashrateStats> GetServerHashRateStats()
        {
            var blockList = new List<HashrateStats>();
            var response = ApiConnection.Get(@"http://api.ethpool.org", @"servers/history");
            var receivedData = JsonConvert.DeserializeObject<ApiResponseArray>(response.ToString());
            foreach (var cred in receivedData.data)
            {
                blockList.Add(JsonConvert.DeserializeObject<HashrateStats>(cred.ToString()));
            }

            return blockList;
        }
    }
}