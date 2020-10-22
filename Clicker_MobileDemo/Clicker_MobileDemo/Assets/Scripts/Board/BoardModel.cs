using Clicker.Configuration;
using Clicker.Events;

namespace Clicker.Board
{
    public class BoardModel
    {
        private readonly int _originalUpgradeCost;
        private readonly int _clickUpgradeIncrement;
        private int _upgradeCost;
        
        public event PointEvent OnUpgradeBought;
        
        public int ClickUpgradeIncrement => _clickUpgradeIncrement;

        public int UpgradeCost
        {
            get => _upgradeCost;
            set
            {
                _upgradeCost = value;
                if (OnUpgradeBought != null) OnUpgradeBought(_upgradeCost);
            }
        }
        
        public BoardModel(BoardConfigData boardConfigData)
        {
            _originalUpgradeCost = boardConfigData.UpgradeCost;
            _clickUpgradeIncrement = boardConfigData.UpgradeCostIncrement;

            UpgradeCost = _originalUpgradeCost;
        }
    }
}
