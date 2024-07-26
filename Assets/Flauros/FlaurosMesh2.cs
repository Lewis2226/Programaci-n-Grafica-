using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class FlaurosMesh2 : MonoBehaviour
{
    void Start()
    {
       
        Vector3[] vertices = {
          new Vector3(1, 0, 0), //0
          new Vector3(0, 0, 1), //1
          new Vector3(-1, 0, 0),//2
          new Vector3(1, 0, 0),//3
          new Vector3(0, 1, 0), //4
          new Vector3(0, -1, 0),//5
          

        };

        int[] triangles = {
           
            /*
            //Cara 0 Lado sub
            0,4,1,
          
            
            //Cara 1 Lado 1 sub
            1,4,2,
            
            */
            //Cara 2 Lado 2 sub
            3,4,0,

            /*
            // Cara 3 Lado sub
            2,4,5,
            /*
            //Cara 4 Lado 1 inf
            0,5,4,
            */
        };

        /*
        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };
        */

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        //mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
