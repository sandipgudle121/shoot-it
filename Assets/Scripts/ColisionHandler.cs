using UnityEngine;

public class ColisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
