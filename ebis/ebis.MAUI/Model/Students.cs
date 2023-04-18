﻿namespace ebis.MAUI.Model;

public class Bornes
{
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private string _phone = string.Empty;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }

    public Bornes(string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }
}