using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Dado12 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateDodecahedron();
    }

    private void CreateDodecahedron()
    {
        Vector3[] vertices ={
            new Vector3 (1,0, 0), // vertice 1
            new Vector3 (0,0, 0), // vertice 1
            new Vector3 (-1,0, 0), // vertice 2
            new Vector3 (0,0, 1), // vertice 3
            new Vector3 (0,0, -1), // vertice 4
            new Vector3 (0,0, 0), // vertice 5
            new Vector3 (0,0, 0), // vertice 6
            new Vector3 (0,0, 0), // vertice 7
            new Vector3 (0,0, 0), // vertice 8
            new Vector3 (0,0, 0), // vertice 9
            new Vector3 (0,0, 0), // vertice 10
            new Vector3 (0,0, 0), // vertice 11
            new Vector3 (0,0, 0), // vertice 12
            new Vector3 (0,0, 0), // vertice 13
            new Vector3 (0,0, 0), // vertice 14
            new Vector3 (0,0, 0), // vertice 15
            new Vector3 (0,0, 0), // vertice 16
            new Vector3 (0,0, 0), // vertice 17
            new Vector3 (0,0, 0), // vertice 18
            new Vector3 (0,0, 0), // vertice 19

        };
        int[] triagles =
        {
            0,2,4, //Cara 0
            
             //Cara 1

             //Cara 2

             //Cara 3

             //Cara 4

             //Cara 5

             //Cara 6

             //Cara 7

             //Cara 8

             //Cara 9

             //Cara 10

             //Cara 11
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triagles;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }


}
