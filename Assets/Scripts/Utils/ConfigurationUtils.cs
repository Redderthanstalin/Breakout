using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    #region Properties
    
    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }
    }

    public static int TotalBalls
    {
        get { return configurationData.TotalBalls; }
        set { TotalBalls = value; }
    }

    public static int MinSpawnTime
    {
        get { return configurationData.minSpawnTime; }
    }
    static int maxSpawnTime = 5;

    static int StandardBlockPercent = 40;
    static int BonusBlockPercent = 30;
    static int FreezerBlockPercent = 15;
    static int SpeedupBlockPercent = 15;

    static int StandardBlockPoints = 1;
    static int BonusBlockPoints = 2;
    static int FreezerBlockPoints = 5;
    static int SpeedupBlockPoints = 5;

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
