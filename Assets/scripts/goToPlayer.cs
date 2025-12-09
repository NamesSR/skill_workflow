using UnityEngine;

public class goToPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f,10f,0f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
