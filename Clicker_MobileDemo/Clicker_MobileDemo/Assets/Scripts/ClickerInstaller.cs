using Clicker.User;
using Clicker.Board;
using Clicker.Configuration;
using UnityEngine;

namespace Clicker
{
    public class ClickerInstaller : MonoBehaviour
    {
        [Header("Configuration")] 
        [SerializeField] private UserConfigData _userConfigData;
        [SerializeField] private BoardConfigData _boardConfigData;
        
        [Header("Installers")]
        [SerializeField] private UserInstaller _userInstaller;
        [SerializeField] private BoardInstaller _boardInstaller;
        

        private void Start()
        {
            var userModel= new UserModel(_userConfigData);
            
            _userInstaller.Install(userModel);
            _boardInstaller.Install(userModel,_boardConfigData);
        }
    }
}
