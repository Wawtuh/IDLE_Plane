using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Upgrade_Gold : MonoBehaviour
{
    private double upgrade = 1.2;
    private int cost = 100;

    [SerializeField]
    private Text myUpgrade;
    [SerializeField]
    private Text myCost;

    // Start is called before the first frame update
    void Start()
    {
        SetUpgradeText();
        SetCostLevelText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClicked()
    {
        if(GameController.Instance.gold > cost)
        {
            GameController.Instance.gold -= cost;
            GameController.Instance.goldLevel = upgrade;
            GameController.Instance.SetStatus();

            cost += (int)(100 * upgrade);
            upgrade += 0.2;

            SetUpgradeText();
            SetCostLevelText();
        }
    }

    void SetUpgradeText()
    {
        myUpgrade.text = "X " + upgrade.ToString();
    }
    void SetCostLevelText()
    {
        myCost.text = cost.ToString();
    }
}
