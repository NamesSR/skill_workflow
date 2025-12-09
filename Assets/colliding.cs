using Unity.VisualScripting;
using UnityEngine;

public class colliding : MonoBehaviour
{
   public bool canJump = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            canJump = true;
            Debug.Log("can jump");
        
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
        Debug.Log("can not jump");
    }
}
