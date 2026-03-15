using UnityEngine;
using System.Collections;

public class EconomyManager : MonoBehaviour
{
    public float currentMarmelade;
    public float marmeladePerSecond;

    [SerializeField] private UIManager uiManager;


    private void Start()
    {
        currentMarmelade = 0;
        StartCoroutine(MarmeladePerSecond());

        uiManager.UpdateMarmeladePerSecondText();
    }

    public void AddMarmelade(float amount)
    {
        currentMarmelade += amount;
        if (currentMarmelade >= 1000f)
        {
            Application.Quit();
            Debug.Log("kukkkk");
        }
    }

    public void SubtractMarmelade(float amount)
    {
        currentMarmelade -= amount;
    }

    public void IncreaseMarmeladePerSecond(float amount)
    {
        marmeladePerSecond += amount;
        uiManager.UpdateMarmeladePerSecondText();
    }

    private IEnumerator MarmeladePerSecond()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            AddMarmelade(marmeladePerSecond);
            uiManager.UpdateMarmeladeText();

        }
    }
}
