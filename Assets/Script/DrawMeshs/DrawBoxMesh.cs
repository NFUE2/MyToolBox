using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBoxMesh : MonoBehaviour
{
    Mesh mesh;
    public Vector3[] Pos;

    MeshFilter MF;

    private void Start()
    {
        MF = GetComponent<MeshFilter>();
        mesh = new Mesh();

        Pos = new Vector3[4];
        Pos[0] = Vector3.zero;
        Pos[1] = Vector3.forward;
        Pos[2] = Vector3.forward + Vector3.right;
        Pos[3] = Vector3.right;

        //Vector3 배열형
        mesh.vertices = Pos;

        int[] vertices = { 0,1,2,0,2,3 };
        //int 배열형

        mesh.triangles = vertices;
        MF.mesh = mesh;
    }
}
