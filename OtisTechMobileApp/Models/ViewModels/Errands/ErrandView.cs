using OtisTechMobileApp.Models.ViewModels.Elevators;
using OtisTechMobileApp.Models.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtisTechMobileApp.Models.ViewModels.Errands
{
    public class ErrandView
    {
        public Guid Id { get; set; }
        public string ErrandNumber { get; set; } = null!;
        public string Title { get; set; } = null!;
        public ElevatorView Elevator { get; set; } = null!;
        public List<ErrandUpdateView> ErrandUpdates { get; set; } = null!;
        public List<EmployeeView> AssignedTechnicians { get; set; } = null!;
        public bool IsResolved { get; set; }
    }
}
