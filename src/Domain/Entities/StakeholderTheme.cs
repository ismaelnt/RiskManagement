namespace Domain.Entities;

public class StakeholderTheme
{
    public StakeholderTheme(int themeId, int stakeholderId)
    {
        StakeholderId = stakeholderId;
        ThemeId = themeId;
    }

    public int StakeholderId { get; }
    public Stakeholder Stakeholder { get; }

    public int ThemeId { get; }
    public Theme Theme { get; }
}
