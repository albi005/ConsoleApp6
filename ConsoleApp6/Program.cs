Console.WriteLine("Hello, World!");
System.Interactive


class A<T, AT> where AT : A<T, AT>
{
    public T Primary { get; set; }

    public virtual NAT Convert<NT, NAT>(Func<T, NT> convert) where NAT : A<NT, NAT>, new()
    {
        return new NAT()
        {
            Primary = convert(Primary)
        };
    }
}

class B<T> : A<T, B<T>>
{
    public T Secondary { get; set; }

    public override NAT Convert<NT, NAT>(Func<T, NT> convert) where NAT : B<NT>
    {
        NAT nat = base.Convert<NT, NAT>(convert);
        return nat;
    }
}