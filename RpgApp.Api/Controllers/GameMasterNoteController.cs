using Microsoft.AspNetCore.Mvc;
using RpgApp.Api.Entity;
using RpgApp.Api.Services;

namespace RpgApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameMasterNoteController(IGameMasterNoteService gameMasterNoteService) : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<IEnumerable<GameMasterNote>> GetAll()
        {
            IEnumerable<GameMasterNote> gameMasterNotes = await gameMasterNoteService.GetAllGameMasterNoteAsync();
            return gameMasterNotes;
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<GameMasterNote>> GetById(int id)
        {
            GameMasterNote gameMasterNote = await gameMasterNoteService.GetGameMasterNoteByIdAsync(id);
            return Ok(gameMasterNote);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<GameMasterNote>> Add(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteService.AddGameMasterNoteAsync(gameMasterNote);
            return Ok(gameMasterNote);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<GameMasterNote>> Update(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteService.UpdateGameMasterNoteAsync(gameMasterNote);
            return Ok(gameMasterNote);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<GameMasterNote>> Delete(GameMasterNote gameMasterNote)
        {
            await gameMasterNoteService.DeleteGameMasterNoteAsync(gameMasterNote);
            return Ok(gameMasterNote);
        }
    }
}
