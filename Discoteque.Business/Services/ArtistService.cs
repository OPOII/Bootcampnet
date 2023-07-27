namespace Discoteque.Business.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

public class ArtistService : IArtistService
{

    private readonly List<Artist> artists;

    public ArtistService()
    {
        artists=new List<Artist>();
    }
    public Task<Artist> CreateArtist(Artist artist)
    {
        var randomGen=new Random();
        artist.Id=randomGen.Next(0, 100);
        // if(artists.Any(item=>item.Id==artist.Id)){
        //     artist.Id=randomGen.Next(0,500);
        // }
        artists.Add(artist);
        Console.WriteLine(artists.Count);
        return Task.FromResult(artist);
    }

    public Task<IEnumerable<Artist?>> GetArtistsAsync()
    {
         throw new NotImplementedException();
    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}