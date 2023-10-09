[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService cs)
    {
        _choresService = cs;
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpGet("{choreId}")]
    public ActionResult<Chore> GetOneChoreById(int choreId)
    {
        try
        {
            Chore chore = _choresService.GetOneChoreById(choreId);
            return Ok(chore);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }

    [HttpDelete("{choreId}")]
    public ActionResult<string> RemoveChore(int choreId)
    {
        try
        {
            string message = _choresService.RemoveChore(choreId);
            return Ok(message);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
    }
}