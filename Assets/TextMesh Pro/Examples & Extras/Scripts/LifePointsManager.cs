using UnityEngine;
using UnityEngine.UI;

public class LifePointsManager : MonoBehaviour
{
    public int lifePoints = 16000; // Valor inicial
    public Text lifePointsText;   // Texto UI

    void Start()
    {
        UpdateLifePointsText();
    }

    public void ChangeLifePoints(int amount)
    {
        lifePoints += amount;
        UpdateLifePointsText();
    }

    void UpdateLifePointsText()
    {
        lifePointsText.text =lifePoints.ToString();
    }
}
