namespace CozmicMinner.Classes
{
    public class PoolStatsResponse
    {
        public MinerBlocks[] minnerBlocks { set; get; }
        public TopMiners[] topMiners { set; get; }
        public poolStats poolStats { set; get; }
        public Price price { set; get; }
    }
}