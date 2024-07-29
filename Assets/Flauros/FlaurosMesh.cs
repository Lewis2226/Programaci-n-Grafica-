using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurosMesh : MonoBehaviour
{

    void Start()
    {
        
        Vector3[] vertices = {
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 1),
            new Vector3(-1, 0, 0),
            new Vector3(0, 1, 0),

        };

        int[] triangles = {
            
            //Cara 0 Lado 
            3,1,0,

            //Cara 1 Lado 
            1,3,2,

            //Cara 2 Lado 
            2,3,0,
          
            //Cara 3 base
            1,2,0,
            
           
          
        };


        Vector2[] uvs = {
            new Vector2(0.10f, 0.28f),
            new Vector2(0.28f, 0.58f),
            new Vector2(0.10f, 0.78f),
            new Vector2(0.10f, 0.28f),
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
