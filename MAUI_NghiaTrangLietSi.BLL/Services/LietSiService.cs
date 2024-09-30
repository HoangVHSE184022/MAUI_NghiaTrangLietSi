using MAUI_NghiaTrangLietSi.DAL.Models;
using MAUI_NghiaTrangLietSi.DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAUI_NghiaTrangLietSi.BLL.Services
{
    public class LietSiService
    {
        private readonly LietSiRepository _lietSiRepository;

        public LietSiService()
        {
            _lietSiRepository = new LietSiRepository();
        }

        public async Task AddLietSiAsync(LietSi lietSi)
        {
            await _lietSiRepository.AddLietSiAsync(lietSi);
        }

        public async Task<IEnumerable<LietSi>> GetAllLietSisAsync()
        {
            return await _lietSiRepository.GetAllLietSisAsync();
        }

        public async Task<LietSi> GetLietSiByIdAsync(string lietSiId)
        {
            return await _lietSiRepository.GetLietSiByIdAsync(lietSiId);
        }

        public async Task UpdateLietSiAsync(LietSi lietSi)
        {
            await _lietSiRepository.UpdateLietSiAsync(lietSi);
        }

        public async Task DeleteLietSiAsync(string lietSiId)
        {
            await _lietSiRepository.DeleteLietSiAsync(lietSiId);
        }
    }
}
