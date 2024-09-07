using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 50f;

    void Update()
    {
        // Calcular el ángulo de rotación
        float angle = rotationSpeed * Time.deltaTime;

        // Aplicar la rotación sobre el eje Y
        transform.Rotate(Vector3.up, angle);
    }
}
