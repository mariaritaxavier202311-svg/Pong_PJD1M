using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private GameManeger gameMeneger;
   private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ball")
        {
            if(CompareTag("AiWall"))
            {
                gameMeneger.PlayerAddPoint();
            }

            if (CompareTag("PlayeWalll"))
            {
                gameMeneger.AIAddPoint();
            }

        }
       
    }

    
}
