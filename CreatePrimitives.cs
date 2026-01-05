using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    void Start()
    {
        GameObject cube;

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0f, 0f, 0f);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(-0.5f, 1f, 0f);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0.5f, 1f, 0f);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0.5f, 2f, 0f);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(-0.5f, 2f, 0f);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0f, 3f, 0f);
    }
}
