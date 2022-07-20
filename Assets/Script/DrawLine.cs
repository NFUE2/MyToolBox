using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    //[Range(0.0f, 360.0f)]
    //public float angle;

    private void OnDrawGizmos()
    {
        //Line();

        float angle = -45.0f * Mathf.Deg2Rad;

        Vector3 Pos = transform.position;

        for (int i = 0; i < 2; i++)
        {
            float angle2 = (90.0f * i) * Mathf.Deg2Rad;
            Vector3 L = new Vector3(Mathf.Sin(angle + angle2),0.0f,Mathf.Cos(angle + angle2)) * 5.0f;

            Gizmos.DrawLine(Pos,L);
            Pos = L;
        }
        Gizmos.DrawLine(Pos,transform.position);
    }

    void Line()
    {
        //Gizmos.color = Color.red;
        //float angle2 = angle * Mathf.Deg2Rad;
        //Vector3 L = new Vector3(Mathf.Sin(angle2), 0.0f, Mathf.Cos(angle2)) * 5.0f;
        //Gizmos.DrawLine(transform.position, L);
    }
}
