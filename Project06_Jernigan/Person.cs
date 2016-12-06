using System;

public class Person
{
    private string _name;
    private string _address;
    private string _teleNumber;

    public Person()
	{
        _address = address;
        _name = Name;
        _teleNumber = teleNumber;
          
	}
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string address
    {
        get { return _address; }
        set { _address = value; }
    }
    public string teleNumber
    {
        get { return _teleNumber;}
        set { _teleNumber = value; }
    }
}
