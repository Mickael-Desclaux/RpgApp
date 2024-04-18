using RpgApp.Api.Entity;

namespace RpgApp.Api.Services
{
    public interface IGameMasterNoteService
    {
        public Task<IEnumerable<GameMasterNote>> GetAllGameMasterNoteAsync();
        public Task<GameMasterNote> GetGameMasterNoteByIdAsync(int gameMasterNoteId);
        public Task AddGameMasterNoteAsync(GameMasterNote gameMasterNote);
        public Task UpdateGameMasterNoteAsync(GameMasterNote gameMasterNote);
        public Task DeleteGameMasterNoteAsync(GameMasterNote gameMasterNote);
    }
}
