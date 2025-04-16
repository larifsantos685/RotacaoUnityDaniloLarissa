using UnityEngine;

public class RotateCube1 : MonoBehaviour
{
    public Transform AlvoDaRotacao;

    public bool DirecaoGiroXDireita;

    public float rotationSpeed = 500f;

    private void Update()
    {
        if(DirecaoGiroXDireita)
            transform.RotateAround(AlvoDaRotacao.position, Vector3.up, rotationSpeed * Time.deltaTime);
        else
            transform.RotateAround(AlvoDaRotacao.position, Vector3.down, rotationSpeed * Time.deltaTime);
    }
}
