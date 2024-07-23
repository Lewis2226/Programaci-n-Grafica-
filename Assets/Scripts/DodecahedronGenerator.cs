using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class DodecahedronGenerator : MonoBehaviour
{
    void Start()
    {
        CreateDodecahedron();
    }

    private void CreateDodecahedron()
    {
        // Crear los vértices del dodecaedro
        float phi = (1 + Mathf.Sqrt(5)) / 2; // Número áureo

        Vector3[] vertices = {
            new Vector3(1, 1, 1),
            new Vector3(1, 1, -1),
            new Vector3(1, -1, 1),
            new Vector3(1, -1, -1),
            new Vector3(-1, 1, 1),
            new Vector3(-1, 1, -1),
            new Vector3(-1, -1, 1),
            new Vector3(-1, -1, -1),
            new Vector3(0, phi, 1/phi),
            new Vector3(0, phi, -1/phi),
            new Vector3(0, -phi, 1/phi),
            new Vector3(0, -phi, -1/phi),
            new Vector3(1/phi, 0, phi),
            new Vector3(1/phi, 0, -phi),
            new Vector3(-1/phi, 0, phi),
            new Vector3(-1/phi, 0, -phi),
            new Vector3(phi, 1/phi, 0),
            new Vector3(phi, -1/phi, 0),
            new Vector3(-phi, 1/phi, 0),
            new Vector3(-phi, -1/phi, 0)
        };

        int[][] faceIndices = {
            new int[] {0, 8, 4, 14, 12},
            new int[] {0, 12, 16, 17, 2},
            new int[] {0, 2, 10, 8, 4},
            new int[] {1, 9, 5, 15, 13},
            new int[] {1, 13, 17, 16, 3},
            new int[] {1, 3, 11, 9, 5},
            new int[] {6, 14, 4, 8, 10},
            new int[] {6, 19, 18, 7, 10},
            new int[] {7, 3, 17, 18, 19},
            new int[] {7, 11, 3, 17, 18},
            new int[] {15, 5, 9, 11, 19},
            new int[] {15, 13, 16, 12, 14}
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();

        // Asignar vértices
        mesh.vertices = vertices;

        // Crear triángulos
        List<int> triangles = new List<int>();

        foreach (var face in faceIndices)
        {
            for (int i = 1; i < face.Length - 1; i++)
            {
                triangles.Add(face[0]);
                triangles.Add(face[i]);
                triangles.Add(face[i + 1]);
            }
        }

        mesh.triangles = triangles.ToArray();
        mesh.RecalculateNormals();
    }
}

