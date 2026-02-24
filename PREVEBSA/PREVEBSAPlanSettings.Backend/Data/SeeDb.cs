using PREVEBSAPlanSettings.Data.Entities;

namespace PREVEBSAPlanSettingBackend.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            // Danger zone //////////////////////////////////////////////////////////////////
            // await _context.Database.EnsureDeletedAsync();
            // Danger zone //////////////////////////////////////////////////////////////////


            await _context.Database.EnsureCreatedAsync();

        }
    }
}
