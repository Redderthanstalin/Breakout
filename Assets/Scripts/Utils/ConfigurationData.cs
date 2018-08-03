
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

    static int minSpawnTime = 5;
    static int maxSpawnTime = 10;

    static int totalBalls = 10;

    static int standardBlockPercent = 70;
    static int bonusBlockPercent = 20;
    static int freezerBlockPercent = 5;
    static int speedupBlockPercent = 5;

    static int standardBlockPoints = 1;
    static int bonusBlockPoints = 2;
    static int freezerBlockPoints = 5;
    static int speedupBlockPoints = 5;

    static float freezeTime = 2;
    static float speedupTime = 2;

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

    public int MinSpawnTime
    {
        get { return minSpawnTime; }
    }
    public int MaxSpawnTime
    {
        get { return maxSpawnTime; }
    }

    public int TotalBalls
    {
        get { return totalBalls; }
    }

    public int StandardBlockPercent
    {
        get { return standardBlockPercent; }
    } 

    public int BonusBlockPercent
    {
        get { return bonusBlockPercent; }
    }
    public int FreezerBlockPercent
    {
        get { return freezerBlockPercent; }
    }
    public int SpeedupBlockPercent
    {
        get { return speedupBlockPercent; }
    }

    public int StandardBlockPoints
    {
        get { return standardBlockPoints; }
    }
    public int BonusBlockPoints
    {
        get { return bonusBlockPoints; }
    }
    public int FreezerBlockPoints
    {
        get { return freezerBlockPoints; }
    }
    public int SpeedupBlockPoints
    {
        get { return speedupBlockPoints; }
    }

    public float FreezeTime
    {
        get { return freezeTime; }
    }
    public float SpeedupTime
    {
        get { return speedupTime; }
    }
    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    //public ConfigurationData()
    //{
    //    StreamReader file = null;

    //    try
    //    {
    //        file = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));

    //        string names = file.ReadLine();
    //        string values = file.ReadLine();

    //        SetConfigurationDataFields(values);
    //    }
    //    catch(Exception e)
    //    {
    //        Debug.Log(e.Message);
    //    }
    //    finally
    //    {
    //        file.Close();
    //    }
    //}

    #endregion

    //void SetConfigurationDataFields(string s)
    //{
    //    string[] values = s.Split(","[0]);
    //    paddleMoveUnitsPerSecond = float.Parse(values[0]);
    //    ballImpulseForce = float.Parse(values[1]);
    //    minSpawnTime = int.Parse(values[2]);
    //    maxSpawnTime = int.Parse(values[3]);
    //    totalBalls = int.Parse(values[4]);
    //    standardBlockPercent = int.Parse(values[5]);
    //    bonusBlockPercent = int.Parse(values[6]);
    //    freezerBlockPercent = int.Parse(values[7]);
    //    speedupBlockPercent = int.Parse(values[8]);
    //    standardBlockPoints = int.Parse(values[9]);
    //    bonusBlockPoints = int.Parse(values[10]);
    //    freezerBlockPoints = int.Parse(values[11]);
    //    speedupBlockPoints = int.Parse(values[12]);
    //    freezetime = float.Parse(values[13]);
    //    speedupTime = float.Parse(values[14]);

    //}
}
