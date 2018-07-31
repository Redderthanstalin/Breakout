
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    static float paddleMoveUnitsPerSecond = 10;
    static float ballImpulseForce = 200;

    static int minSpawnTime = 2;
    static int maxSpawnTime = 5;

    static int totalBalls = 10;

    static int StandardBlockPercent = 40;
    static int BonusBlockPercent = 30;
    static int FreezerBlockPercent = 15;
    static int SpeedupBlockPercent = 15;

    static int StandardBlockPoints = 1;
    static int BonusBlockPoints = 2;
    static int FreezerBlockPoints = 5;
    static int SpeedupBlockPoints = 5;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }
    }

    public int TotalBalls
    {
        get { return totalBalls; }
    }

    public int StandardBlockPercent = 40;
    static int BonusBlockPercent = 30;
    static int FreezerBlockPercent = 15;
    static int SpeedupBlockPercent = 15;

    static int StandardBlockPoints = 1;
    static int BonusBlockPoints = 2;
    static int FreezerBlockPoints = 5;
    static int SpeedupBlockPoints = 5;

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader file = null;

        try
        {
            file = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));

            string names = file.ReadLine();
            string values = file.ReadLine();

            SetConfigurationDataFields(values);
        }
        catch(Exception e)
        {

        }
        finally
        {
            file.Close();
        }
    }

    #endregion

    void SetConfigurationDataFields(string s)
    {
        string[] values = s.Split(","[0]);
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        minSpawnTime = int.Parse(values[2]);
        maxSpawnTime = int.Parse(values[3]);
        totalBalls = int.Parse(values[4]);
        StandardBlockPercent = int.Parse(values[5]);
        BonusBlockPercent = int.Parse(values[6]);
        FreezerBlockPercent = int.Parse(values[7]);
        SpeedupBlockPercent = int.Parse(values[8]);
        StandardBlockPoints = int.Parse(values[9]);
        BonusBlockPoints = int.Parse(values[10]);
        FreezerBlockPoints = int.Parse(values[11]);
        SpeedupBlockPoints = int.Parse(values[12]);

    }
}
