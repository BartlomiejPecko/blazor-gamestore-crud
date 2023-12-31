﻿using blazorgamestorecrud.Models;

namespace blazorgamestorecrud;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "FirstGame",
            Genre = "FirstGenre",
            Price = 19.99M,
            ReleaseDate = new DateTime(2013, 2, 1)
        },

        new Game()
        {
            Id = 2,
            Name = "SecondGame",
            Genre = "SecondGenre",
            Price = 19.99M,
            ReleaseDate = new DateTime(1996, 2, 1)
        },

        new Game()
        {
            Id = 2,
            Name = "ThirdGame",
            Genre = "ThirdGenre",
            Price = 29.99M,
            ReleaseDate = new DateTime(1998, 2, 1)
        },

    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game) //method to add games
    {
        game.Id = games.Max(game => game.Id) + 1; //to add correct Id of newly made games.
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }

}
