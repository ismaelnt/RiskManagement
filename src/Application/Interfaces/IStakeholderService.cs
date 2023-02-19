using Application.DTOs.StakeholderDto;

namespace Application.Interfaces;

public interface IStakeholderService
{
    Task<List<ReadStakeholdersDto>> GetStakeholdersAsync();
    Task<ReadStakeholderDto> GetStakeholderByIdAsync(int id);
    Task<ResponseStakeholderDto> CreateStakeholderAsync(CreateStakeholderDto stakeholderDto);
}
