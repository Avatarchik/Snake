﻿using System.Net;
using Akka.Interfaced.SlimSocket.Client;
using Common.Logging;
using Domain;

public static class G
{
    static G()
    {
        _logger = LogManager.GetLogger("G");
    }

    // Communicator

    private static Communicator _communicator;

    public static Communicator Communicator
    {
        get { return _communicator; }
        set { _communicator = value; }
    }

    public static readonly IPEndPoint DefaultServerEndPoint = new IPEndPoint(IPAddress.Loopback, 9001);

    // Logger

    private static readonly ILog _logger;

    public static ILog Logger
    {
        get { return _logger; }
    }

    // User specific data

    public static UserRef User { get; set; }

    public static long UserId { get; set; }

    public static TrackableUserContext UserContext { get; set; }

    public static GameDifficulty GameDifficulty { get; set; }
}
