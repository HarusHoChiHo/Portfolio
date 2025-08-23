using System.Data;
using System.Runtime.CompilerServices;
using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.User.ValueObjects;

namespace PortfolioBackEnd.Domain.User.Models;

public class User : Entity<UserId>
{
    public string UserName { get; private set; } = default;
    public Password Password { get; private set; } = default;

    public static User Create(UserId   userId,
                              string   username,
                              Password password)
    {
        User user = new User
        {
            Id = userId,
            UserName = username,
            Password = password
        };

        return user;
    }

    public void UpdateRowSource(UserId userId,
                                  string userName,
                                  Password password)
    {
        UserName = userName;
        Password = password;
    }
}