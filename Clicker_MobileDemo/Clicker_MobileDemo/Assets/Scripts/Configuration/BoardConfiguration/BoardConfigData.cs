using UnityEngine;

namespace Clicker.Configuration
{
    [CreateAssetMenu(menuName = "Config/BoardConfigData", fileName = "BoardConfigData")]
    public class BoardConfigData : ScriptableObject
    {
        [SerializeField] private int _upgradeCost; 
        [SerializeField] private int _upgradeCostIncrement;
        
        public int UpgradeCost => _upgradeCost;
        public int UpgradeCostIncrement => _upgradeCostIncrement;
    }
}