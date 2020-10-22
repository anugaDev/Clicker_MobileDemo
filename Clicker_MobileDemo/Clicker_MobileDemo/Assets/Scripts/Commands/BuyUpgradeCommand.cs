using Clicker.Board;
using Clicker.User;

namespace Clicker.Commands
{
    public class BuyUpgradeCommand : ButtonInteractionCommand
    {
        protected readonly BoardModel _boardModel;

        public BuyUpgradeCommand(UserModel userModel, BoardModel boardModel) : base(userModel)
        {
            _boardModel = boardModel;
        }
        public override void Execute()
        {
            if (_userModel.Points >= _boardModel.UpgradeCost)
            {
                _userModel.ClickValue++;
                _userModel.Points -= _boardModel.UpgradeCost;
                _boardModel.UpgradeCost *= _boardModel.ClickUpgradeIncrement;
            }
            
        }
    
    }
}