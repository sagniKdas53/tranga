﻿namespace Tranga.MangaConnectors;

public enum RequestType : byte
{
    Default = 0,
    MangaDexFeed = 1,
    MangaImage = 2,
    MangaCover = 3,
    MangaDexAuthor = 4,
    MangaDexImage = 5,
    MangaInfo = 6
}