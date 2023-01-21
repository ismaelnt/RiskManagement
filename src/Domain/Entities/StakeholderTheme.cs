namespace Domain.Entities;

public class StakeholderTheme
{
    public StakeholderTheme()
    {
    }

    public StakeholderTheme(int themeId, Theme theme, int stakeholderId, Stakeholder stakeholder)
    {
        StakeholderId = stakeholderId;
        Stakeholder = stakeholder;
        ThemeId = themeId;
        Theme = theme;
    }

    public int StakeholderId { get; }
    public Stakeholder Stakeholder { get; }

    public int ThemeId { get; }
    public Theme Theme { get; }
}
