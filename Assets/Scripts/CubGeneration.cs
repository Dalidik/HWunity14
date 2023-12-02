using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubGeneration : MonoBehaviour
{
    Mesh Mesh;
    MeshFilter meshFilter;

    void Start()
    {
        Mesh = new Mesh();
        Mesh.name = "GeneratedMesh";

        Mesh.vertices = GenerateVerts();
        Mesh.triangles = GenerateTries();

        Mesh.RecalculateNormals();
        Mesh.RecalculateBounds();

        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = Mesh;
    }

    private Vector3[] GenerateVerts()
    {
        return new Vector3[]
        {
            //bottom
           new Vector3(-1, 0, 1),
           new Vector3(1, 0, 1),
           new Vector3(1, 0, -1),
           new Vector3(-1, 0, -1),

            //top
           new Vector3(-1, 2, 1),
           new Vector3(1, 2, 1),
           new Vector3(1, 2, -1),
           new Vector3(-1, 2, -1),

            //left
           new Vector3(-1, 0, 1),
           new Vector3(-1, 0, -1),
           new Vector3(-1, 2, 1),
           new Vector3(-1, 2, -1),

             //right
           new Vector3(1, 0, 1),
           new Vector3(1, 0, -1),
           new Vector3(1, 2, 1),
           new Vector3(1, 2, -1),

            //front
           new Vector3(1, 0, -1),
           new Vector3(-1, 0, -1),
           new Vector3(1, 2, -1),
           new Vector3(-1, 2, -1),

           //back
           new Vector3(-1, 0, 1),
           new Vector3(1, 0, 1),
           new Vector3(-1, 2, 1),
           new Vector3(1, 2, 1),

        };
    }

    private int[] GenerateTries()
    {
        return new int[]
        {
            //bottom/top
            1, 0, 2,
            2, 0, 3,
            4, 5, 6,
            4, 6, 7,

            //left/right
            9, 10, 11,
            8, 10, 9,
            12, 13, 15,
            14, 12, 15,

            //front/back
            16, 17, 19,
            18, 16, 19,
            20, 21, 23,
            22, 20, 23,
        };
    }
}