using System.Collections;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    private float destroyDelay = 2.0f;

    private void Start()
    {
        StartCoroutine(Destroy(destroyDelay));
    }

    IEnumerator Destroy(float time)
    {
        yield return new WaitForSeconds(time * Time.timeScale);
        Destroy(gameObject);
    }
}
