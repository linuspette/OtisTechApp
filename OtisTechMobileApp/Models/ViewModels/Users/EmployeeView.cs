using OtisTechMobileApp.Models.ViewModels.Errands;

namespace OtisTechMobileApp.Models.ViewModels.Users;

public class EmployeeView
{
    public int EmployeeNumber { get; set; }
    public string FullName { get; set; } = null!;
    public List<ErrandView>? ErrandViewModels { get; set; }

    public override bool Equals(object? o)
    {
        var other = o as EmployeeView;
        return other?.FullName == this!.FullName!;
    }
    public override int GetHashCode() => FullName?.GetHashCode() ?? 0;
    public override string ToString() => FullName;
}
