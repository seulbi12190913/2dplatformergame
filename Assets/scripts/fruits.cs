using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruits : MonoBehaviour
{
    public float timeAdd = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            GameManager.Instance.AddTime(timeAdd);
            GetComponent<Animator>().SetTrigger("Eaten");
            Invoke("DestroyThis", 0.4f);
        }
    }
    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
