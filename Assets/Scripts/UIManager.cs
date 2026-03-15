using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private EconomyManager economyManager;
    [SerializeField] private Text marmeladeText;
    [SerializeField] private Text marmeladePerSecondText;

    public void UpdateMarmeladeText()
    {
        marmeladeText.text = "Marmelade: " + economyManager.currentMarmelade.ToString();
    }

    public void UpdateMarmeladePerSecondText()
    {
        marmeladePerSecondText.text = "Marmelade/s: " + economyManager.marmeladePerSecond.ToString();
    }
}
