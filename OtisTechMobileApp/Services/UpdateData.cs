using Newtonsoft.Json;
using OtisTechMobileApp.Models.ViewModels.Errands;
using OtisTechMobileApp.Pages;

namespace OtisTechMobileApp.Services
{
    public class UpdateData : IUpdateData
    {
        
        private IApiService apiService { get; set; }
        public UpdateData(IApiService apiServ)
        {
            apiService = apiServ;
        }

        public async Task<ErrandView> UpdateErrandData(string errandId)
        {
            var jsonObject = await apiService.GetAsync($"Errands/GetErrand",  new Dictionary<string, string> { { "errandNumber", errandId! } });

            ErrandView errandOne = new();
            errandOne = JsonConvert.DeserializeObject<ErrandView>(jsonObject) ?? null!;


            return errandOne;
        }
    }

    public interface IUpdateData
    {
        Task<ErrandView> UpdateErrandData(string errandId);
    }
}
