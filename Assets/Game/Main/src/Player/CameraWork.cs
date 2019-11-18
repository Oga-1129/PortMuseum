using UnityEngine;

public class CameraWork : MonoBehaviour
{

    public Transform horizontalRotNode;
    public Transform verticalRotNode;

    /// <summary>
    /// 上限比較用
    /// </summary>
    int[] angleLimit = new int[2];

    /// <summary>
    /// 左右の移動上限
    /// </summary>
    public int[] LRLimit = new int[2];

    /// <summary>
    /// 上下の移動上限
    /// </summary>
    public int[] UDLimit = new int[2];

    public const float DELTA_ANGLE = 1.0f;
    public const float DELTA_DOLLY = 0.05f;

    float horizontalAngle;
    float verticalAngle;

    /// <summary>
    /// 左右移動のリセット
    /// </summary>
    bool[] angleRLReset = new bool[2];

    /// <summary>
    /// 上限移動のリセット
    /// </summary>
    bool[] angleUDReset = new bool[2];



    /**
     * 十字キーで回転 Z/Xキーでズーム
     */
    void Update()
    {
        RotateHorizontal();
        RotateVertical();

        if (angleRLReset[0])
        {
            if (angleLimit[0] > 0)
            {
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle - DELTA_ANGLE, 0));
                angleLimit[0]--;
            }
            else
            {
                angleRLReset[0] = false;
            }
        }

        if (angleRLReset[1])
        {
            if (angleLimit[0] < 0)
            {
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle + DELTA_ANGLE, 0));
                angleLimit[0]++;
            }
            else
            {
                angleRLReset[1] = false;
            }
        }

        if (angleUDReset[0])
        {
            if (angleLimit[1] < 0)
            {
                verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle - DELTA_ANGLE, 0, 0));
                angleLimit[1]++;
            }
            else
            {
                angleUDReset[0] = false;
            }
        }
        if (angleUDReset[1])
        {
            if (angleLimit[1] > 0)
            {
                verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle + DELTA_ANGLE, 0, 0));
                angleLimit[1]--;
            }
            else
            {
                angleUDReset[1] = false;
            }
        }
    }

    private void RotateHorizontal()
    {
        horizontalAngle = horizontalRotNode.localRotation.eulerAngles.y;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (angleLimit[0] < LRLimit[0])
            {
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle + DELTA_ANGLE, 0));
                angleLimit[0]++;
            }
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            angleRLReset[0] = true;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (angleLimit[0] > LRLimit[1])
            {
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle - DELTA_ANGLE, 0));
                angleLimit[0]--;
            }
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            angleRLReset[1] = true;
        }
    }

    private void RotateVertical()
    {
        verticalAngle = verticalRotNode.localRotation.eulerAngles.x;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (angleLimit[1] > UDLimit[0])
            {
                verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle + DELTA_ANGLE, 0, 0));
                angleLimit[1]--;
            }
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            angleUDReset[0] = true;
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (angleLimit[1] < UDLimit[1])
            {
                verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle - DELTA_ANGLE, 0, 0));
                angleLimit[1]++;
            }
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            angleUDReset[1] = true;
        }
    }
}
