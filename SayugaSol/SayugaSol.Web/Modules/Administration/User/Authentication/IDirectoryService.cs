﻿
namespace SayugaSol.Administration
{
    public interface IDirectoryService
    {
        DirectoryEntry Validate(string username, string password);
    }
}