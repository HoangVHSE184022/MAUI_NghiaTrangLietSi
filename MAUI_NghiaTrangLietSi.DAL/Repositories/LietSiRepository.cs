using MAUI_NghiaTrangLietSi.DAL.Models;
using Realms;

namespace MAUI_NghiaTrangLietSi.DAL.Repositories
{
    public class LietSiRepository
    {
        private Realm _realm;

        public LietSiRepository()
        {
            RealmConfiguration config = new RealmConfiguration
            {
                SchemaVersion = 1,
                ShouldDeleteIfMigrationNeeded = true
            };

            _realm = Realm.GetInstance(config);
        }

        public async Task AddLietSiAsync(LietSi lietSi)
        {
            using (var transaction = _realm.BeginWrite())
            {
                _realm.Add(lietSi);
                await transaction.CommitAsync(); 
            }
        }

        public async Task<IEnumerable<LietSi>> GetAllLietSisAsync()
        {
            return await Task.Run(() => _realm.All<LietSi>().ToList());
        }

        public async Task<LietSi> GetLietSiByIdAsync(string lietSiId)
        {
            return await Task.Run(() => _realm.Find<LietSi>(lietSiId));
        }

        public async Task UpdateLietSiAsync(LietSi lietSi)
        {
            using (var transaction = _realm.BeginWrite())
            {
                var lietSiToUpdate = _realm.Find<LietSi>(lietSi.LietSiId);

                if (lietSiToUpdate != null)
                {
                    lietSiToUpdate.HoVaTen = lietSi.HoVaTen;
                    lietSiToUpdate.QueQuan = lietSi.QueQuan;
                    lietSiToUpdate.NamSinh = lietSi.NamSinh;
                    lietSiToUpdate.NamMat = lietSi.NamMat;
                    lietSiToUpdate.DonVi = lietSi.DonVi;
                    lietSiToUpdate.CapBac = lietSi.CapBac;
                    lietSiToUpdate.NoiYenNghi = lietSi.NoiYenNghi;
                    lietSiToUpdate.ViTriMoX = lietSi.ViTriMoX;
                    lietSiToUpdate.ViTriMoY = lietSi.ViTriMoY;
                }

                await transaction.CommitAsync();
            }
        }

        public async Task DeleteLietSiAsync(string lietSiId)
        {
            using (var transaction = _realm.BeginWrite())
            {
                var lietSiToDelete = _realm.Find<LietSi>(lietSiId);

                if (lietSiToDelete != null)
                {
                    _realm.Remove(lietSiToDelete);
                }

                await transaction.CommitAsync();
            }
        }
    }
}
