using System;

public class Customer
{
	class Customer : Person
	{
        private int _customerNumber;
        private bool _newsletter;
	}
    public int CustomerNumber
    {
        get { return _customerNumber; }
        set { CustomerNumber = value; }
    }
    public bool newsletter
    {
        get { return _newsletter; }
        set { newsletter = value; }
    }
}
