using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawArc : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float length;

    [Range(1.0f, 360.0f)]
    public float arcangle;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Circle(transform.position, length,arcangle);
    }


    //중앙위치,반지름,호의 각도
    void Circle(Vector3 Center, float radius,float angle)
    {
        Vector3 Pos1, Pos2;
        float angle2 = -((angle / 2) * Mathf.Deg2Rad);

        Pos1 = (Center + new Vector3(Mathf.Sin(angle2), 0.0f, Mathf.Cos(angle2))) * radius;
        Gizmos.DrawLine(Center,Pos1);

        for (int i = 0; i < angle; i++)
        {
            angle2 += 1.0f * Mathf.Deg2Rad;
            Pos2 = (Center + new Vector3(Mathf.Sin(angle2), 0.0f, Mathf.Cos(angle2))) * radius;

            Gizmos.DrawLine(Pos1,Pos2);
            Pos1 = Pos2;
        }

        Gizmos.DrawLine(Center, Pos1);
    }
}
