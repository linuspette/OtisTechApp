using OtisTechMobileApp.Models.ViewModels.Errands;

namespace OtisTechMobileApp.Models.ViewModels.Elevators;

public class ElevatorView
{
    public Guid Id { get; set; }
    public string Location { get; set; } = null!;
    public List<ErrandView> Errands { get; set; } = null!;
}
