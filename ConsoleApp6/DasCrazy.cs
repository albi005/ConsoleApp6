// ReSharper disable once CheckNamespace
namespace ConsoleApp6.Another;

interface IA<T, AT> where AT : IA<T, AT>
{
    T Primary { get; set; }
}

class A<T, BT> : IA<T, BT> where BT : IA<T, BT>
{
    public T Primary { get; set; }
}  