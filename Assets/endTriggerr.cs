
using UnityEngine;

public class endTriggerr : MonoBehaviour
{
    
    
       public GameManager gameManager;
       void OnTriggerEnter ()
        {
          gameManager.Completelevel();

        }
    
}
