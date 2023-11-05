using System.ComponentModel.DataAnnotations;
using WannabeNetflix.src.ui;
using WannabeNetflix.src.utils;

namespace WannabeNetflix.src.core
{
    internal class AppManager
    {
        internal static AppManager Instance => _instance;
        private static AppManager _instance;
        
        internal bool IsReadOnly { get; set; }

        internal EmployeeManager EmployeeManager => _employeeMgr;
        internal ClientManager ClientManager => _clientMgr;
        internal MovieManager MovieManager => _movieMgr;

        private EmployeeManager _employeeMgr;
        private ClientManager _clientMgr;
        private MovieManager _movieMgr;

        public AppManager()
        {
            _instance = this;
            _employeeMgr = new EmployeeManager();
            _clientMgr = new ClientManager();
            _movieMgr = new MovieManager();
            UI.TryOpenForm<Login>();
        }
    }
}
