using Objects;
using Utilities;
using System;
using System.Collections.Generic;

public class UserManager
{
    private const string UsersFilePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Users.txt"; 

    public static List<User> LoadUsers()
    {
        return Registry.LoadFromFile<User>(UsersFilePath, ParseUser); 
    }

    private static User ParseUser(string line)
    {
        var parts = line.Split(','); 

        if (parts.Length != 6) 
        {
            throw new FormatException("A linha do ficheiro Users.txt não está no formato esperado.");
        }
        return new User(
            Guid.Parse(parts[0]),         // ID (GUID)
            parts[1].Trim(),              // Nome
            parts[2].Trim(),              // Email
            DateTime.Parse(parts[3]),     // Data de Nascimento
            parts[4].Trim(),              // Password
            parts[5].Trim()               // Role (ex.: User, Admin)
        );
    }
}
