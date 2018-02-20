namespace MinnerDataAccess
{
    using SharpRepository.EfRepository;

    public class MinnerDataFactory
    {
        #region Private Fields

        private readonly MiningDbContext DatabaseContext = null;
        private EfRepository<Bookmark> bookmarkRepo = null;
        private EfRepository<MinerType> minerTypeRepo = null;
        private EfRepository<ServerRegion> regionRepo = null;
        private EfRepository<MiningServer> serverRepo = null;

        #endregion Private Fields

        #region Public Constructors

        public MinnerDataFactory(MiningDbContext context)
        {
            if (context == null) context = new MiningDbContext();
            this.DatabaseContext = context;
        }

        #endregion Public Constructors

        #region Public Methods

        public EfRepository<Bookmark> BookmarkRepository
        {
            get
            {
                if (this.bookmarkRepo == null) this.bookmarkRepo = new EfRepository<Bookmark>(this.DatabaseContext);
                return this.bookmarkRepo;
            }
        }

        public EfRepository<MinerType> MinerTypeRepository
        {
            get
            {
                if (this.minerTypeRepo == null) this.minerTypeRepo = new EfRepository<MinerType>(this.DatabaseContext);
                return this.minerTypeRepo;
            }
        }

        public EfRepository<ServerRegion> RegionRepository
        {
            get
            {
                if (this.regionRepo == null) this.regionRepo = new EfRepository<ServerRegion>(this.DatabaseContext);
                return regionRepo;
            }
        }

        public EfRepository<MiningServer> ServerRepository
        {
            get
            {
                if (this.serverRepo == null) this.serverRepo = new EfRepository<MiningServer>(this.DatabaseContext);
                return this.serverRepo;
            }
        }

        #endregion Public Methods
    }
}