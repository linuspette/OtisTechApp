using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtisTechMobileApp.Models.InputModels
{
    public class ErrandUpdateInputModel
    {
        [JsonProperty("errandNumber")] public string? ErrandNumber { get; set; }
        [JsonProperty("status")] public string Status { get; set; } = null!;
        [JsonProperty("message")] public string Message { get; set; } = null!;
        [JsonProperty("isResolved")] public bool IsResolved { get; set; }
        [JsonProperty("employeeIds")] public List<int>? EmployeeIds { get; set; }

        public void ClearData()
        {
            ErrandNumber = "";
            Status = "";
            Message = "";
            EmployeeIds = null!;
        }
    }
}
