using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenUtils : MonoBehaviour {

    #region Fields
    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;
    #endregion

    #region Properties
    public static float ScreenLeft
    {
        get { return screenLeft; }
    }

    public static float ScreenRight
    {
        get { return screenRight; }
    }

    public static float ScreenTop
    {
        get { return screenTop; }
    }

    public static float ScreenBottom
    {
        get { return screenBottom; }
    }
    #endregion 

    public static void Initialize()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 leftLowerCorner = new Vector3(0, 0, screenZ);
        Vector3 rightTopCorner = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 leftLowerCornerWorld = Camera.main.ScreenToWorldPoint(leftLowerCorner);
        Vector3 RighttopCornerWorld = Camera.main.ScreenToWorldPoint(rightTopCorner);

        screenLeft = leftLowerCornerWorld.x;
        screenRight = RighttopCornerWorld.x;
        screenTop = RighttopCornerWorld.y;
        screenBottom = leftLowerCornerWorld.y;
    }

}
