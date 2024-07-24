using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Dodecahedron : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateDodecahedro();
    }

    private void CreateDodecahedro()
    {
        float phi = (1 + Mathf.Sqrt(5)) / 2;
       

        Vector3[] vertices = {
            new Vector3( 1,  1,  1),
            new Vector3( 1,  1, -1),
            new Vector3( 1, -1,  1),
            new Vector3( 1, -1, -1),
            new Vector3(-1,  1,  1),
            new Vector3(-1,  1, -1),
            new Vector3(-1, -1,  1),
            new Vector3(-1, -1, -1),
            new Vector3( 0,  1 / phi,  phi),
            new Vector3( 0,  1 / phi, -phi),
            new Vector3( 0, -1 / phi,  phi),
            new Vector3( 0, -1 / phi, -phi),
            new Vector3( 1 / phi,  phi,  0),
            new Vector3( 1 / phi, -phi,  0),
            new Vector3(-1 / phi,  phi,  0),
            new Vector3(-1 / phi, -phi,  0),
            new Vector3( phi,  0,  1 / phi),
            new Vector3( phi,  0, -1 / phi),
            new Vector3(-phi,  0,  1 / phi),
            new Vector3(-phi,  0, -1 / phi),
        };


        int[] triangles = new int[]
          {

           // Cara 1 base 
           0, 3, 4,
           0, 4, 2,
           1, 4, 2,

           // Cara 2 lado  de 0 a 1
           0,7,8,
           0,8,1,
           1,8,5,
           
           // Cara 4 lado de 1 a 2
           1,6,8,
           1,8,2,
           2,8,7,
            
           // Cara 5 lado de 2 a 3
            2,6,8,
            2,8,3,
            3,8,9,
            
           // Cara 6 lado de  3 a 4
           3,8,9,
           3,9,4,
           4,9,10,

           // Cara 3 lado  de 0 a 4
           4,5,9,
           4,9,0,
           0,9,8,
            
           // Cara 7 lado de 5 a 6
           5,11,10,
           5,10,6,
           6,10,12,
            
           // Cara 9 lado de 6 a 7
           6,13,14,
           6,14,7,
           7,14,15,
            
           // Cara 10 lado de 7 a 8
           7,15,16,
           7,16,8,
           8,16,17,

           // Cara 8 lado de 9 a 5
           9,12,13,
           9,13,5,
           5,13,14,

           // Cara 11 lado de 8 a 9
           8,14,13,
           8,13,9,
           9,13,15,
             
           // Cara 12 superior
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
