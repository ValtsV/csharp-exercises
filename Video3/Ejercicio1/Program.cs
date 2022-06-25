DatosCliente cliente1 = new DatosCliente("John", 123123123, "Some Street 4", "mail@mail.com", false);

Console.WriteLine(cliente1);

public struct DatosCliente
{
    public DatosCliente(string fullname, int phone, string address, string email, bool isNewCustomer)
    {
        Fullname = fullname;
        Phone = phone;
        Address = address;
        Email = email;
        IsNewCustomer = isNewCustomer;
    }

    public string Fullname { get; }

    public int Phone { get; }

    public string Address { get; }

    public string Email { get; }

    public bool IsNewCustomer { get; }

    public override string? ToString()
    {
        return $"DatosCliente: {Fullname} {Phone} {Address} {Email} {IsNewCustomer}";
    }
}


