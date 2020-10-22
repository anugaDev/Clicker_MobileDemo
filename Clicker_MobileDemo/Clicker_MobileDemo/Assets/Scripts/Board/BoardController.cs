using Clicker.Commands;

namespace Clicker.Board
{
    public class BoardController
    {
        private readonly BoardView _view;
        private readonly BoardModel _model;
        
        public BoardController(BoardModel model, BoardView view, ButtonInteractionCommand mainButtonInteraction,BuyUpgradeCommand buyUpgradeInteraction)
        {
            _view = view;
            
            _model = model;
            _model.OnUpgradeBought += OnUpgradeBought;
            
            _view.MainButton.onClick.AddListener(mainButtonInteraction.Execute);
            _view.BuyUpgradeButton.onClick.AddListener(buyUpgradeInteraction.Execute);
           
            OnUpgradeBought(_model.UpgradeCost);
        }
        
        private void OnUpgradeBought(int value)
        {
            _view.SetUpgradeTextValue(value);
        }   
    }
}
