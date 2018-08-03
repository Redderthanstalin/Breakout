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
        get { return configurationData.MinSpawnTime; }
    }
    public static int MaxSpawnTime
    {
        get { return configurationData.MaxSpawnTime; }
    }

    public static int StandardBlockPercent
    {
        get { return configurationData.StandardBlockPercent; }
    }
    public static int BonusBlockPercent
    {
        get { return configurationData.BonusBlockPercent; }
    }
    public static int FreezerBlockPercent
    {
        get { return configurationData.FreezerBlockPercent; }
    }
    public static int SpeedupBlockPercent
    {
        get { return configurationData.SpeedupBlockPercent; }
    }

    public static int StandardBlockPoints
    {
        get { return configurationData.StandardBlockPoints; }
    }
    public static int BonusBlockPoints
    {
        get { return configurationData.BonusBlockPoints; }
    }
    public static int FreezerBlockPoints
    {
        get { return configurationData.FreezerBlockPoints; }
    }
    public static int SpeedupBlockPoints
    {
        get { return configurationData.SpeedupBlockPoints; }
    }

    public static float FreezeTime
    {
        get { return configurationData.FreezeTime; }
    }
    public static float SpeedupTime
    {
        get { return configurationData.SpeedupTime; }
    }
    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }
}
