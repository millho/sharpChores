using sharpChores.Models;
namespace sharpChores.Services;

public class ChoresService
{
    private readonly ChoresRepo _repo;

    public ChoresService(ChoresRepo repo)
    {
        _repo = repo;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repo.GetChores();
        return chores;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _repo.GetOneChoreById(choreId);
        if (chore == null) throw new Exception("no chores @id");
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChoreById(choreId);
        _repo.RemoveChore(chore);
        return "removal message";
    }
}