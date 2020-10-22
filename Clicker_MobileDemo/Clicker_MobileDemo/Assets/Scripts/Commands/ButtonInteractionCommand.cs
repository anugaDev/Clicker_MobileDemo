using Clicker.User;

namespace Clicker.Commands
{
    public abstract class ButtonInteractionCommand : ICommand
    {
        protected readonly UserModel _userModel;

        protected ButtonInteractionCommand(UserModel userModel)
        {
            _userModel = userModel;
        }

        public abstract void Execute();
    }
}
