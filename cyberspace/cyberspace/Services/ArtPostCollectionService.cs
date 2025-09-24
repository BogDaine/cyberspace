using cyberspace.Models;

namespace cyberspace.Services
{
    public class ArtPostCollectionService : ICollectionService<ArtPost>
    {
        List<ArtPost> _Posts = new List<ArtPost> {
            new ArtPost{Id = Guid.NewGuid(), Title = "aaa", Description = "", Src = ""},
            new ArtPost{Id = Guid.NewGuid(), Title = "bbb", Description = "", Src = ""},
            new ArtPost{Id = Guid.NewGuid(), Title = "ccc", Description = "", Src = ""},
            new ArtPost{Id = Guid.NewGuid(), Title = "ddd", Description = "", Src = ""},
        };
        public List<ArtPost> GetAll() { return new List<ArtPost>(); }
        public ArtPost Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public bool Create(ArtPost model) { throw new NotImplementedException(); }
        
    }
}
