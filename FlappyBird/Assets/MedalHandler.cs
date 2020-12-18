using UnityEngine;
using UnityEngine.UI;

public class MedalHandler : MonoBehaviour
{
    public Sprite noMedal;
    public Sprite bronzeMedal;
    public Sprite silverMedal;
    public Sprite goldMedal;
    public Sprite platinumMedal;

    public void SetMedal(int medalNumber)
    {
        switch (medalNumber)
        {
            case 0:
                GetComponent<Image>().sprite = noMedal;
                break;
            case 1:
                GetComponent<Image>().sprite = bronzeMedal;
                break;
            case 2:
                GetComponent<Image>().sprite = silverMedal;
                break;
            case 3:
                GetComponent<Image>().sprite = goldMedal;
                break;
            case 4:
                GetComponent<Image>().sprite = platinumMedal;
                break;
        }
    }
}
