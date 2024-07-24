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
          new Vector3 (0,1.4f, .5f), // vertice 0
          new Vector3 (.5f,1.4f, .1f), // vertice 1
          new Vector3 (.3f,1.4f, -.5f), // vertice 2
          new Vector3 (-.3f,1.4f, -.5f), // vertice 3
          new Vector3 (-.5f,1.4f, .1f), // vertice 4
          
          new Vector3 (0,0.8f, .8f), // vertice 5
          new Vector3 (.8f,0.8f, .2f), // vertice 6
          new Vector3 (.5f,0.8f, -.8f), // vertice 7
          new Vector3 (-.5f,0.8f, -.8f), // vertice 8
          new Vector3 (-.8f,0.8f, .2f), // vertice 9

          new Vector3 (0,0.6f, -.8f),  // vertice 10
          new Vector3 (-.8f,0.6f, -.2f),  // vertice 11
          new Vector3 (-.5f,0.6f, .8f), // vertice 12
          new Vector3 (.5f,0.6f, .8f), // vertice 13
          new Vector3 (.8f,0.6f, -.2f), // vertice 14

          new Vector3 (0,0, -.5f), // vertice 15
          new Vector3 (-.5f,0, -.1f), // vertice 16
          new Vector3 (-.3f,0, .5f), // vertice 17
          new Vector3 (.3f,0, .5f), // vertice 18
          new Vector3 (.5f,0, -.1f), // vertice 19
          
        };


        int[] triangles = new int[]
          {
           // Cara 1 superior
           0,1,2,
           0,2,3,
           0,3,4,
           

           //Cara 2 lado 0 a 1 lado sup
           13,0,5,
           13,1,0,
           13,6,1,
           
           //Cara 3 lado 0 a 4 lado sup
           12,4,9,
           12,0,4,
           12,5,0,
           
           //Cara 4 lado 1 a 2 lado sup
           14,1,6,
           14,2,1,
           14,7,2,
           
           //Cara 5 lado 2 a 3 lado sup
           10,2,7,
           10,3,2,
           10,8,3,
           
           //Cara 6 lado 3 a 4 lado sup
           11,3,8,
           11,4,3,
           11,9,4,
           
           //Cara 7 lado 5 a 6 lado inf
           8,10,15,
           8,15,16,
           8,16,11,
           
           
           //Cara 8 lado 5 a 9 lado inf
           7,14,19,
           7,19,15,
           7,15,10,
           
           
           //Cara 9 lado 6 a 7 lado inf
           6,13,18,
           6,18,19,
           6,19,14,
           
           
           //Cara 10 lado 7 a 8 lado inf
           5,12,17,
           5,17,18,
           5,18,13,
           
           //Cara 11 lado 8 a 9 lado inf
           9,11,16,
           9,16,17,
           9,17,12,
           
           //Cara 12 base
           15,17,16,
           15,18,17,
           15,19,18,
           
          };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
     }
}
