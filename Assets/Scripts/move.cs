using UnityEngine;

public class move : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
    }

    }
