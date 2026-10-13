using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitPoints = 3;

    [SerializeField] int scoreValue=10;

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>(); 
    }
    void OnParticleCollision(GameObject other)
    {
        processHit();
    }

    private void processHit()
    {
        hitPoints--;
        if (hitPoints <= 0)
        {
            scoreBoard.increaseScore(scoreValue);
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
