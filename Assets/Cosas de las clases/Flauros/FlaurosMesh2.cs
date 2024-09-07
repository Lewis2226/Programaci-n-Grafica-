using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class FlaurosMesh2 : MonoBehaviour
{
    void Start()
    {
       
        Vector3[] vertices = {
          new Vector3(0, 0, 1),  //Vertice 0
          new Vector3(1, 0, 0),  //Vertice 1
          new Vector3(0, 1, 0),  //Vertice 2
          new Vector3(-1, 0, 0), //Vertice 3
          new Vector3(0, 0, -1), //Vertice 4
          new Vector3(0, -1, 0), //Vertice 5
         
          //Tengo 4 más para poder acomadar mejor el uv
          new Vector3(1, 0, 0),  
          new Vector3(1, 0, 0),  
          new Vector3(0, 1, 0),  
          new Vector3(-1, 0, 0)  

        };

        int[] triangles = {
           
            
            //Cara 0 Lado sub
            0,1,2,
          
            //Cara 1 Lado  sub
            0,2,3,
            
            //Cara 2 Lado  sub
            0,3,5,

            // Cara 3 Lado sub
            0,5,6,
            
            //Cara 4 Lado inf
            4,6,5,
          
            //Cara 5 Lado inf
            4,8,7,
            
            //Cara 2 Lado 2 inf
            4,9,8,

            // Cara 3 Lado inf
            4,5,9,

        };

        //Son iguales al numero de vertices de las caras pero solo en u  y v
        Vector2[] uvs = {
           new Vector2(0.8455f, 0.43f),  
            new Vector2(0.96f, 0.281f),  
            new Vector2(0.74f, 0.281f),  
            new Vector2(0.6f, 0.43f),    
            new Vector2(0.8455f, 0.775f),
            new Vector2(0.72f, 0.605f),  
            new Vector2(0.96f, 0.60f),   
            new Vector2(0.96f, 0.95f),   
            new Vector2(.725f, 0.95f),   
            new Vector2(.6f, 0.775f)     
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
