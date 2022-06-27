using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    [Range(1.0f, 10.0f)]
    public float length;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Circle(transform.position,length);
    }


    //중앙위치,반지름
    void Circle(Vector3 Center,float radius)
    {
        Vector3 Pos1, Pos2;

        float angle = 360.0f * Mathf.Deg2Rad;
        Pos1 = (Center + new Vector3(Mathf.Sin(angle), 0.0f, Mathf.Cos(angle))) * radius;
        angle = 1.0f * Mathf.Deg2Rad;

        //각도 1도 마다 벡터가 생성되어 원을 그린다.
        for (int i = 0; i < 360; i++)
        {
            Pos2 = (Center + new Vector3(Mathf.Sin(angle), 0.0f, Mathf.Cos(angle))) * radius;
            Gizmos.DrawLine(Pos1,Pos2);

            Pos1 = Pos2;
            angle += 1.0f * Mathf.Deg2Rad;
        }
    }
}
