using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosMesh : MonoBehaviour
{

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
        Vector2[] uvs = {
            new Vector2(0.41f, 0.957f),    
            new Vector2(0.534f, 0.787f),   
            new Vector2(0.284f, 0.787f),   
            new Vector2(0.41f, 0.618f),    
            new Vector2(0.6615f, 0.9575f), 
            new Vector2(0.1615f, 0.9575f), 
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
