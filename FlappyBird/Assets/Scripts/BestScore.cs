using UnityEngine;

public class BestScore : MonoBehaviour
{
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("bestScore").ToString();
    }
}
