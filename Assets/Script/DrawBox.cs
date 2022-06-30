using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBox : MonoBehaviour
{
    [Range(0.0f,100.0f)]
    public float length;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Box(transform.position, length);
    }

    void Box(Vector3 Center, float distance)
    {
        Vector3 Pos1, Pos2;
        float angle = -45.0f * Mathf.Deg2Rad;

        Pos1 = new Vector3(Mathf.Sin(angle),0.0f,Mathf.Cos(angle)) * distance;
        for (int i = 0; i < 4; i++)               
        {
            angle += 90.0f * Mathf.Deg2Rad;
            Pos2 = new Vector3(Mathf.Sin(angle),0.0f,Mathf.Cos(angle)) * distance;
            Gizmos.DrawLine(Pos1,Pos2);

            Pos1 = Pos2;
        }
    }

}
