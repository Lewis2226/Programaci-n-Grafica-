using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class FlaurosMesh2 : MonoBehaviour
{
    void Start()
    {
       
        Vector3[] vertices = {
          new Vector3 (1,0,0), //Vertice 0
          new Vector3 (-1,0,0), //Vertice 1
          new Vector3 (0,0,1), //Vertice 2
          new Vector3 (0,0,-1), //Vertice 3
          new Vector3 (0,1,0), //Vertice 4
          new Vector3 (0,-1,0), //Vertice 5
          

        };

        int[] triangles = {
           
            
            //Cara 0 Lado sub
            0,4,2,
          
            
            //Cara 1 Lado  sub
            2,4,1,
            
            
            //Cara 2 Lado  sub
            3,4,0,

            
            // Cara 3 Lado sub
            1,4,3,
            
            //Cara 4 Lado inf
            2,5,0,
          
            
            //Cara 5 Lado inf
            1,5,2,
            
            
            //Cara 2 Lado 2 inf
            0,5,3,

            
            // Cara 3 Lado inf
            3,5,1,

        };

        
        Vector2[] uvs = {
            new Vector2(0.10f, 0.25f),
            new Vector2(0.25f, 0.30f),
            new Vector2(0.30f, 0.45f),
            new Vector2(0.50f, 0.45f),
            new Vector2(0.50f, 0.30f),
            new Vector2(0.60f, 0.45f),
 
        };
        
        

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
