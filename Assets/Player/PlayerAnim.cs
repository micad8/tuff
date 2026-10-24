using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public int balloonAmount = 0;
    public Sprite defaultSprite;
    public Sprite fallSprite;
    public Sprite balloonSprite;
    public Rigidbody2D playerPhysics;
    public Rigidbody2D balloon;
    public SpriteRenderer playerImage;
    public SpriteRenderer balloonImage;
    public Sprite[] balloonSprites;

    void Update(){
        int index = Mathf.Clamp( balloonAmount, 0, balloonSprites.Length -1);
        balloonImage.sprite = balloonSprites[index];
        balloon.position = new Vector2(playerPhysics.position.x, playerPhysics.position.y); 

        if (balloonAmount >= 1) 
        {
            playerImage.sprite = balloonSprite;
            if (balloonAmount*3 > playerPhysics.position.y){
            playerPhysics.linearVelocity = new Vector2(playerPhysics.linearVelocity.x, balloonAmount); }
        }
        else if (playerPhysics.linearVelocity.y < -0.1f) 
        {
            playerImage.sprite = fallSprite;
        } 
        else 
        {
            playerImage.sprite = defaultSprite;
        }
    }
}
