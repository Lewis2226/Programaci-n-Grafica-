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
            new Vector3 (-.5f,0, 0), // vertice 0
            new Vector3 (.5f,0, 0), // vertice 1
            new Vector3 (0,0, .5f), // vertice 2
            new Vector3 (0,0, -.5f), // vertice 3
            new Vector3 (0,.5f, 0), // vertice 4
            new Vector3 (-1,0.6f, 0), // vertice 5
            new Vector3 (1,0.6f, 0), // vertice 6
            new Vector3 (0,0.6f, 1), // vertice 7
            new Vector3 (0,0.6f, -1), // vertice 8
            new Vector3 (0,1.1f, 0), // vertice 9
            new Vector3 (-1.5f,0.8f, 0), // vertice 10
            new Vector3 (1.5f,0.8f, 0), // vertice 11
            new Vector3 (0,0.8f, 1.5f), // vertice 12
            new Vector3 (0,0.8f, -1.5f), // vertice 13
            new Vector3 (0,1.3f, 0), // vertice 14
            new Vector3 (-2,1.4f, 0), // vertice 15
            new Vector3 (2,1.4f, 0), // vertice 16
            new Vector3 (0,1.4f, 2), // vertice 17
            new Vector3 (0,1.4f, -2), // vertice 18
            new Vector3 (0,1.9f, 0), // vertice 19

        };
        int[] triangles =
        {
              
             //Cara 0 base
             0,3,4,
             0,4,2,
             1,4,3,
            
             //Cara 1 lado
             0,5,9,
             0,9,6,
             7,8,9,

             //Cara 2 lado
             1,9,7,
             1,7,8,
             6,8,7,

             //Cara 3 lado
             3,6,8,
             3,8,9,
             5,8,7,

             //Cara 4 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 5 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 6 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 7 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 8 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 9 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 10 lado
             0,0,0,
             0,0,0,
             0,0,0,

             //Cara 11 superior
             15,17,19,
             15,19,16,
             16,19,18,
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
