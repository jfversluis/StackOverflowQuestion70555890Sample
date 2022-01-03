using FreshMvvm.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp22.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {
        private readonly IApiService _apiService;
        private List<NameModel> _nameModelList;

        public List<NameModel> NameModelList
        {
            get => _nameModelList;
            private set
            {
                _nameModelList = value;

                RaisePropertyChanged(nameof(NameModelList));
            }
        }

        public MainPageModel(IApiService apiService)
        {
            _apiService = apiService;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Task.Run(() => GetNameData());
        }

        private async Task GetNameData()
        {
            var result = await _apiService.GetNameData();
            NameModelList = result.GetRange(1, 10);
        }
    }
}
