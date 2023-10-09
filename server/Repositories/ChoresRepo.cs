

namespace sharpChores.Repositories;

public class ChoresRepo
{
    private List<Chore> _FakeDb;

    public ChoresRepo()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "New chore", "Red", "Tuesday"));
    }

    internal Chore CreateChore(Chore choreData)
    {
        _FakeDb.Add(choreData);
        return choreData;
    }

    internal List<Chore> GetChores()
    {
        return _FakeDb;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        return chore;
    }

    internal void RemoveChore(Chore chore)
    {
        _FakeDb.Remove(chore);
    }
}