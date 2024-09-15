using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient 
{
    private readonly List<GameSummary>games=
    [
         new(){
            Id=1,
            Name="Street Fighter",
            Genre="Fighting",
            Price= 19.9M,
            ReleaseDate =new DateOnly(1992, 7, 15)

        },
         new(){
             Id=2,
            Name="Final Fantasy ii",
            Genre="Roleplaying",
            Price= 29.9M,
            ReleaseDate =new DateOnly(2001, 7, 15)   

        },
         new(){
            Id=3,
            Name="Fifa",
            Genre="Sports",
            Price= 45.9M,
            ReleaseDate =new DateOnly(2016, 7, 15)    

        }
         

    ];
    public GameSummary[] GetGames() => [.. games];
}
