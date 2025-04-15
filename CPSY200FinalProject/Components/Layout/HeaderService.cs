namespace CPSY200FinalProject.Components.Layout;

public class HeaderService
{
    public string HeaderText { get; private set; } = "Customer";

    public event Action? OnChange;

    public void SetHeader(string text)
    {
        HeaderText = text;
        OnChange?.Invoke();
    }
}
