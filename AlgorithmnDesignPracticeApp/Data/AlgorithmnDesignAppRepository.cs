using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmnDesignPracticeApp.Data
{
    public class AlgorithmnDesignAppRepository : IAlgorithmnDesignAppRepository
    {

        //private readonly AlgorithmnDesignAppDbContext dctx;
        private readonly ILogger<AlgorithmnDesignAppRepository> logger;

        //Repository pattern - also supports testability of code. 
        public AlgorithmnDesignAppRepository(/*SamuraiDbContext dctx*/ ILogger<AlgorithmnDesignAppRepository> logger)
        {
            //this.dctx = dctx;
            this.logger = logger;
        }







    }
}
