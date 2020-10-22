using Clicker.User;

namespace Clicker.Commands
{
    public class AddPointsInteractionCommand : ButtonInteractionCommand
    {
        public AddPointsInteractionCommand(UserModel userModel): base (userModel){}
        public override void Execute()
        {
            _userModel.Points += _userModel.ClickValue;
        } 
    }
}
