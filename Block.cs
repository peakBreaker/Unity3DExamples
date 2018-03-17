using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public AudioClip crack;
    public int timesHit;
    public Sprite[] blockSprites;

    private LevelManager LevelMan;
    static int breakableCount = 0;
    // possible codes
        // 
        //
        
    // Use this for initialization
    void Start()
    {
        LevelMan = FindObjectOfType<LevelManager>().GetComponent<LevelManager>();
        breakableCount++;
        timesHit = 0;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position);

        timesHit++;
        int maxHits = blockSprites.Length + 1;
        if (timesHit >= maxHits) {
            breakableCount--;
            if (breakableCount == 0) {
                LevelMan.loadNextLevel();
            }
            Destroy(gameObject);
        } else {
            LoadSprites();
        }
    }

    void LoadSprites() {
        int spriteIndex = timesHit - 1;
        this.GetComponent<SpriteRenderer>().sprite = blockSprites[spriteIndex];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
