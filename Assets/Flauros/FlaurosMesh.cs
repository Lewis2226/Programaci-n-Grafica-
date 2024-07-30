using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosMesh : MonoBehaviour
{

    void Start()
    {
        
        Vector3[] vertices = {
            new Vector3(.8f, 0, 0),
            new Vector3(0, 0, .8f),
            new Vector3(-.8f, 0, 0),
            new Vector3(0, .8f, 0),
            new Vector3(0, .8f, 0),
            new Vector3(0, .8f, 0),

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
            new Vector2(0.41f, 0.957f),    //0
            new Vector2(0.534f, 0.787f),   //1
            new Vector2(0.284f, 0.787f),   //2
            new Vector2(0.41f, 0.618f),    //3
            new Vector2(0.6615f, 0.9575f), //3 - 4
            new Vector2(0.1615f, 0.9575f), //3 - 5
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
