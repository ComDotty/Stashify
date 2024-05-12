using CommunityToolkit.Mvvm.ComponentModel;
using Realms;
using Realms.Sync;
using System.Collections.ObjectModel;

namespace Stashify.ViewModels
{
    public partial class DashboardPageVM : BaseVM
    {
        private Realm realm;
        private PartitionSyncConfiguration config;

        public DashboardPageVM()
        {

        }

        [ObservableProperty]
        ObservableCollection<Stash> stashlist;

        [ObservableProperty]
        string emptyString;

    }
}
