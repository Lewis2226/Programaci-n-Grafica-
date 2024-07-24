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
              
             //Cara 1 base
             0,4,3,
             0,3,1,
             1,3,2,
            
             //Cara 2 lado
             0,7,8,
             0,8,6,
             1,8,5,

             //Cara 3 lado
             0,5,9,
             0,9,4,
             4,9,8,

             //Cara 4 lado
             1,6,8,
             1,8,2,
             2,8,7,

             //Cara 5 lado
             2,6,8,
             2,8,3,
             3,8,9,

             //Cara 6 lado
             2,6,8,
             2,8,3,
             3,8,9,

             //Cara 7 lado
             2,6,8,
             2,8,3,
             3,8,9,

             //Cara 8 lado
             5,12,13,
             5,13,9,
             9,13,14,

             //Cara 9 lado
             6,13,14,
             6,14,7,
             7,14,15,

             //Cara 10 lado
             7,15,16,
             7,16,8,
             8,16,17,

             //Cara 11 lado
             8,14,13,
             8,13,9,
             9,13,15,

             //Cara 12 superior
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
