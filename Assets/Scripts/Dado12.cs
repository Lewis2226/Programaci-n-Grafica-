using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Dad012 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateDodecahedro();
    }

    private void CreateDodecahedro()
    {
    
        Vector3[] vertices = {
          new Vector3 (-.5f,0, 0), // vertice 0
          new Vector3 (.5f,0, 0), // vertice 1
          new Vector3 (0,0, .5f), // vertice 2
          new Vector3 (0,0, -.5f), // vertice 3
          new Vector3 (0,.5f, 0), // vertice 4

          new Vector3 (-1,0.6f, 0), // vertice 5
          new Vector3 (1,0.6f, 0), // vertice 6
          new Vector3 (0,0.6f, 1), // vertice 7
          new Vector3 (0,0.6f, -1), // vertice 8
          new Vector3 (0,.6f, 0), // vertice 9

          new Vector3 (0,0.8f, -1), // vertice 10
          new Vector3 (0,0.8f, 1), // vertice 11
          new Vector3 (1,0.8f, 0), // vertice 12
          new Vector3 (-1,0.8f, 0), // vertice 13
          new Vector3 (0,0.8f, 0), // vertice 14

          new Vector3 (0,1.4f, -.5f), // vertice 15
          new Vector3 (0,1.4f, .5f), // vertice 16
          new Vector3 (.5f,1.4f, 0), // vertice 17
          new Vector3 (-.5f,1.4f, 0), // vertice 18
          new Vector3 (0,1.4f, 0), // vertice 19
        };


        int[] triangles = new int[]
          {
           // Cara 1 base
           4,3,2,
           4,2,1,
           1,0,2,
           
           //Cara 2 lado 0 a 1
           0,7,8,
           0,8,6,
           1,8,5,
           
           //Cara 3 lado 0 a 4
           0,5,9,
           0,9,4,
           4,9,8,
           
           //Cara 4 lado 1 a 2
           1,6,8,
           1,8,2,
           2,8,7,
           
           //Cara 5 lado 2 a 3
           2,6,8,
           2,8,3,
           3,8,9,
           
           //Cara 6 lado 3 a 4
           3,8,9,
           3,9,4,
           4,9,10,
           
           //Cara 7 lado 5 a 6
           5,11,10,
           5,10,6,
           6,10,12,
           
           //Cara 8 lado 5 a 9
           5,12,13,
           5,13,9,
           9,13,14,
           
           //Cara 9 lado 6 a 7
           6,13,14,
           6,14,7,
           7,14,15,
           
           //Cara 10 lado 7 a 8
           7,15,16,
           7,16,8,
           8,16,17,
           
           //Cara 11 lado 8 a 9
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
