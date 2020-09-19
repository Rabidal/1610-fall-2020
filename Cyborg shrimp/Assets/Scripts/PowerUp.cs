using UnityEngine;

public class PowerUp : MonoBehaviour
{
  public int score;
  private void OnTriggerEnter(Collider other)
  {
    score++;  
    print(score);  
  }
}
