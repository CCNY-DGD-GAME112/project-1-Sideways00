using UnityEngine;
using TMPro;
public class Scorebehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshPro ScoreText;
    public int Score = 0;
    public void UpdateScore(){
        ScoreText.text = "Score: " + Score;
    }

    void Start(){
        UpdateScore();
    }
    private void OnTriggerEnter2D(Collider2D other){
        SwordBehavior Zombie = other.gameObject.GetComponent<SwordBehavior>();
        
        if(Zombie != null){
            Score++;
            UpdateScore();
        }
    } 
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
