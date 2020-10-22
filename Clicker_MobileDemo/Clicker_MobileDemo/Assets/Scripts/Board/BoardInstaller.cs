using Clicker.User;
using Clicker.Commands;
using Clicker.Configuration;
using UnityEngine;

namespace Clicker.Board
{
    public class BoardInstaller : MonoBehaviour
    {
        [SerializeField] private BoardView _boardView;

        public void Install(UserModel userModel,BoardConfigData boardConfigData)
        {
            
            var boardModel = new BoardModel(boardConfigData);

            var mainButtonInteractionCommand = new AddPointsInteractionCommand(userModel);
            var buyUpgradeCommand = new BuyUpgradeCommand(userModel, boardModel);

            new BoardController(boardModel, _boardView, mainButtonInteractionCommand,buyUpgradeCommand);
        }
    }
}
