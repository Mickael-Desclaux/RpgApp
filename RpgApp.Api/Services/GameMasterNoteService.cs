using RpgApp.Api.Entity;
using RpgApp.Api.Repository;

namespace RpgApp.Api.Services
{
    public class GameMasterNoteService(IRepository<GameMasterNote> gameMasterNoteRepository) : IGameMasterNoteService
    {
        public async Task<IEnumerable<GameMasterNote>> GetAllGameMasterNoteAsync()
        {
            return await gameMasterNoteRepository.GetAllAsync();
        }

        public async Task<GameMasterNote> GetGameMasterNoteByIdAsync(int gameMasterNoteId)
        {
            IEnumerable<GameMasterNote> gameMasterNotes = await gameMasterNoteRepository.GetAllAsync();
            GameMasterNote? gameMasterNote = gameMasterNotes.FirstOrDefault(g => g.Id == gameMasterNoteId);

            if (gameMasterNote == null)
            {
                throw new Exception("Cette note n'existe pas.");
            }

            return gameMasterNote;
        }

        public async Task AddGameMasterNoteAsync(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteRepository.AddAsync(gameMasterNote);
        }

        public async Task UpdateGameMasterNoteAsync(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteRepository.UpdateAsync(gameMasterNote);
        }

        public async Task DeleteGameMasterNoteAsync(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteRepository.DeleteAsync(gameMasterNote);
        }
    }
}
