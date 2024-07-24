using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Dado12 : MonoBehaviour
{
    void Start()
    {
        CreateDodecahedron();
    }
    private void CreateDodecahedron()
    {
        // Variables for the golden ratio
        float t = (1 + Mathf.Sqrt(5)) / 2;
        float r = 1 / t;

        // 20 vertices of a dodecahedron
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(1, 1, 1),
            new Vector3(1, 1, -1),
            new Vector3(1, -1, 1),
            new Vector3(1, -1, -1),
            new Vector3(-1, 1, 1),
            new Vector3(-1, 1, -1),
            new Vector3(-1, -1, 1),
            new Vector3(-1, -1, -1),

            new Vector3(0, r, t),
            new Vector3(0, r, -t),
            new Vector3(0, -r, t),
            new Vector3(0, -r, -t),

            new Vector3(r, t, 0),
            new Vector3(r, -t, 0),
            new Vector3(-r, t, 0),
            new Vector3(-r, -t, 0),

            new Vector3(t, 0, r),
            new Vector3(t, 0, -r),
            new Vector3(-t, 0, r),
            new Vector3(-t, 0, -r)
        };

        // 12 faces of the dodecahedron, each face with 5 vertices (pentagon)
        int[] triangles = new int[]
        {
            // Define each pentagonal face using triangles
            // Each face is divided into 3 triangles
            0, 8, 9, 0, 9, 4, 0, 4, 16,
            0, 16, 17, 0, 17, 1, 0, 1, 12,
            1, 9, 8, 1, 8, 10, 1, 10, 11,
            1, 17, 16, 1, 16, 3, 1, 3, 2,
            2, 11, 10, 2, 10, 14, 2, 14, 13,
            2, 13, 12, 2, 12, 4, 2, 4, 9,
            3, 16, 4, 3, 4, 12, 3, 12, 13,
            3, 13, 14, 3, 14, 15, 3, 15, 2,
            4, 9, 8, 4, 8, 7, 4, 7, 6,
            5, 14, 13, 5, 13, 12, 5, 12, 11,
            6, 8, 9, 6, 9, 5, 6, 5, 7,
            7, 15, 14, 7, 14, 5, 7, 5, 10
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
