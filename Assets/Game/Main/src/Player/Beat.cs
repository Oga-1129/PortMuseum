using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public Transform neckBone;
    //動かす首の指定
    public GameObject watchTarget;

    protected virtual void LateUpdate()
    {
        if (neckBone != null)
        {
            if (watchTarget != null)
            {
                Vector2 target_posY = new Vector2(watchTarget.transform.position.x, watchTarget.transform.position.z);
                Vector2 char_posY = new Vector2(transform.position.x, transform.position.z);

                Vector2 directionY = target_posY - char_posY;

                float angleY = -(Mathf.Atan2(directionY.y, directionY.x) * Mathf.Rad2Deg) - 90f;

                neckBone.rotation = Quaternion.identity;
                neckBone.Rotate(0f, angleY - 180f, -90f);
            }
        }
    }
}