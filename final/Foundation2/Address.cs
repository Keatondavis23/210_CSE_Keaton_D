﻿namespace Foundation2;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }
    public bool IsInUSA() { return _country.Equals("USA"); }
    public string AddressString() { return _streetAddress + "\n" + _city + ", " + _stateProvince + " " + _country;}

}