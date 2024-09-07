using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosMesh : MonoBehaviour
{
     public int numText;
    void Start()
    {
        float altura = Mathf.Sqrt(2f / 3f);
        Vector3[] vertices = {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0.5f, 0, Mathf.Sqrt(0.75f)),
            new Vector3(0.5f, altura, 0.5f / Mathf.Sqrt(3f)), 
            //Tengo 2 más para poder acomadar mejor el uv
            new Vector3(0.5f, altura, 0.5f / Mathf.Sqrt(3f)),
            new Vector3(0.5f, altura, 0.5f / Mathf.Sqrt(3f)),

        };

        int[] triangles = {
            
            //Cara 0 Lado 
            0,1,2,

            //Cara 1 Lado 
            0,2,5,

            //Cara 2 Lado 
            0,4,1,
          
            //Cara 3 base
            3,2,1,
            
           
          
        };


        //Son iguales al numero de vertices de las caras pero solo en u  y v
        Vector2[] uvs1= {
            new Vector2(0.41f, 0.957f),    
            new Vector2(0.534f, 0.787f),   
            new Vector2(0.284f, 0.787f),   
            new Vector2(0.41f, 0.618f),    
            new Vector2(0.6615f, 0.9575f), 
            new Vector2(0.1615f, 0.9575f), 
        };

        Vector2[] uvs2 = {
            new Vector2(0.265f, 0.43f),
            new Vector2(0.138f, 0.6f), 
            new Vector2(0.384f, 0.6f), 
            new Vector2(0.265f, 0.766f),
            new Vector2(0.011f, 0.43f),
            new Vector2(0.523f, 0.43f),
        };

        Vector2[] uvs3 = {
          new Vector2(0.296f, 0.387f),
          new Vector2(0.276f, 0.327f),
          new Vector2(0.176f, 0.327f),
          new Vector2(0.3f, 0.042f),  
          new Vector2(0.546f, 0.387f),
          new Vector2(0.05f, 0.387f), 
        };

        Vector2[] uvs4 = {
            new Vector2(0.6f, 0.042f), 
            new Vector2(0.476f, 0.209f), 
            new Vector2(0.73f, 0.209f), 
            new Vector2(0.6f, 0.381f),  
            new Vector2(0.353f, 0.042f), 
            new Vector2(0.853f, 0.042f), 
        };
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        
        switch (numText)
        {
            case 1:
                mesh.uv = uvs1;
                break;
            
            case 2:
                mesh.uv = uvs2;
                break;
            
            case 3:
                mesh.uv = uvs3;
                break;

            case 4:
                mesh.uv = uvs4;
                break;
        }

        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}
