using Project_OOP;
using System.Collections.Generic;

public class UserManager
{
    private List<Person> _userList;

    public UserManager()
    {
        _userList = new List<Person>();
    }

    public void AddUser(Person user)
    {
        _userList.Add(user);
    }

    public Person FindUser(string email)
    {
        foreach (Person p in _userList)
        {
            if (p.Email == email)
            {
                return p;
            }
        }
        return null;
    }

    public bool Login(string email, string password)
    {
        Person user = FindUser(email);
        if (user != null)
        {
            if (user is Admin admin)
            {
                return admin.CheckPassword(password);
            }
            else if (user is Reporter reporter)
            {
                return reporter.CheckPassword(password);
            }
            else if (user is Subscriber subscriber)
            {
                return subscriber.CheckPassword(password);
            }
        }
        return false;
    }

    public List<Person> GetUsersForDisplay()
    {
        List<Person> displayList = new List<Person>();

        for (int i = 0; i < this._userList.Count; i = i + 1)
        {
            Person p = this._userList[i];

            if (!(p is Admin))
            {
                displayList.Add(p);
            }
        }
        return displayList;
    }

    public void SetUserList(List<Person> loadedList)
    {
        _userList = loadedList;
    }
}