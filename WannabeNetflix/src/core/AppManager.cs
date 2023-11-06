using System.ComponentModel.DataAnnotations;
using WannabeNetflix.src.ui;
using WannabeNetflix.src.utils;

namespace WannabeNetflix.src.core
{
    public class AppManager
    {
        public static AppManager Instance => _instance;
        private static AppManager _instance;

        public bool IsReadOnly { get; set; }

        public EmployeeManager EmployeeManager => _employeeMgr;
        public ClientManager ClientManager => _clientMgr;
        public MovieManager MovieManager => _movieMgr;

        private EmployeeManager _employeeMgr;
        private ClientManager _clientMgr;
        private MovieManager _movieMgr;

        public AppManager(bool isMock = false)
        {
            _instance = this;
            _employeeMgr = new EmployeeManager();
            _clientMgr = new ClientManager();
            _movieMgr = new MovieManager();

            if (isMock)
                return;

            UI.TryOpenForm<Login>();
        }
    }
}
