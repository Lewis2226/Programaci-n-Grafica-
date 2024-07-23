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
        Vector3[] vertices ={
            new Vector3 (-1,0, 0), // vertice 0
            new Vector3 (1,0, 0), // vertice 1
            new Vector3 (2,0, 1.5f), // vertice 2
            new Vector3 (-2,0, 1.5f), // vertice 3
            new Vector3 (2,0, 2), // vertice 4
            new Vector3 (-2,0.6f, 0), // vertice 5
            new Vector3 (2,0.6f, 0), // vertice 6
            new Vector3 (-3,0.6f, 2.5f), // vertice 7
            new Vector3 (3,0.6f, 2.5f), // vertice 8
            new Vector3 (3,0.6f, 3), // vertice 9
            new Vector3 (-2,0.8f, 0), // vertice 10
            new Vector3 (2,0.8f, 0), // vertice 11
            new Vector3 (-3,0.8f, 2.5f), // vertice 12
            new Vector3 (3,0.8f, 2.5f), // vertice 13
            new Vector3 (3,0.8f, 3), // vertice 14
            new Vector3 (-1,1.4f, 0), // vertice 15
            new Vector3 (1,1.4f, 0), // vertice 16
            new Vector3 (2,1.4f, 1.5f), // vertice 17
            new Vector3 (-2,1.4f, 1.5f), // vertice 18
            new Vector3 (2,1.4f, 2), // vertice 19

        };
        int[] triagles =
        {
              
             //Cara 0
             0,4,1,
             1,2,4,
             0,3,4,
            
             //Cara 1
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 2
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 3
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 4
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 5
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 6
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 7
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 8
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 9
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 10
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 11
             15,18,19,
             15,19,16,
             16,17,19,
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triagles;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
