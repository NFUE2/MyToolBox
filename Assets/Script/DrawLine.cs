using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    [Range(0.0f,360.0f)]
    public float angle;

    private void OnDrawGizmos()
    {
        Line();
    }

    void Line()
    {
        Gizmos.color = Color.red;
        float angle2 = angle * Mathf.Deg2Rad;
        Vector3 L = new Vector3(Mathf.Sin(angle2),0.0f,Mathf.Cos(angle2)) * 5.0f;
        Debug.DrawLine(transform.position,L);
    }
}
