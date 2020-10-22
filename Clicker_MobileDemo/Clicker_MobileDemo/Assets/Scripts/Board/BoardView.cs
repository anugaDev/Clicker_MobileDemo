using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Clicker.Board
{
    public class BoardView : MonoBehaviour
    {
        
        [SerializeField] private Button _mainButton;
        [SerializeField] private Button _buyUpgradeButton;
        [SerializeField] private TMP_Text _buyUpgradeButtonText;
        
        public Button MainButton => _mainButton;
        public Button BuyUpgradeButton => _buyUpgradeButton;
        
        public void SetUpgradeTextValue(int value)
        {
            _buyUpgradeButtonText.text = value.ToString();
        }
    }
}
