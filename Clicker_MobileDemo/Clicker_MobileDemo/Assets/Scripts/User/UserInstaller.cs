using UnityEngine;

namespace Clicker.User
{
    public class UserInstaller : MonoBehaviour
    {
        [SerializeField] private UserView _userView;
        
        public void Install(UserModel userModel)
        {
            new UserController(userModel, _userView);
        }
    }
}