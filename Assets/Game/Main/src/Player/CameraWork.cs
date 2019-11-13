using UnityEngine;

public class CameraWork : MonoBehaviour {

    public Transform horizontalRotNode;
    public Transform verticalRotNode;

    int angleLimit = 0;

    public int MaxLimit;
    public int MinLimit;

    public const float DELTA_ANGLE = 1.0f;
    public const float DELTA_DOLLY = 0.05f;

    float horizontalAngle;

    /**
     * 十字キーで回転 Z/Xキーでズーム
     */
    void Update () {
        RotateHorizontal();
        RotateVertical();
    }

    private void RotateHorizontal()
    {
        horizontalAngle = horizontalRotNode.localRotation.eulerAngles.y;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(angleLimit < MaxLimit){
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle + DELTA_ANGLE, 0));
                angleLimit++;
            }
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(angleLimit > MinLimit){
                horizontalRotNode.localRotation = Quaternion.Euler(new Vector3(0, horizontalAngle - DELTA_ANGLE, 0));  
                angleLimit--;
            }  
        }
    }

    private void RotateVertical()
    {
        float verticalAngle = verticalRotNode.localRotation.eulerAngles.x;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle + DELTA_ANGLE, 0, 0));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalRotNode.localRotation = Quaternion.Euler(new Vector3(verticalAngle - DELTA_ANGLE, 0, 0));
        }
    }
}
