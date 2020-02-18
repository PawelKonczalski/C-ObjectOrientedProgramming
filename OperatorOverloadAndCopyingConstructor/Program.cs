using System;

class Program
{
    static void Main(string[] args)
    {
        AccountBalance a = new AccountBalance(5, 120);
        AccountBalance b = new AccountBalance(5, 10);
        Console.WriteLine(a == b);
        Console.WriteLine(a);
        Console.WriteLine(a+b);
    }
}

class AccountBalance
{
    public uint zl { get; set; }

    public ushort gr;

    public ushort Gr
    {
        get { return gr; }
        set
        {
            if (value <= 0)
            {
                gr = 0;
            }
            else if (value >= 100)
            {
                uint temp = (uint) (value / 100);
                zl += temp;
                gr = (ushort) (value - temp * 100);
            }
            else
            {
                gr = value;
            }
        }
    }

    public AccountBalance(uint zl, ushort gr)
    {
        this.zl = zl;
        this.Gr = gr;
    }

    public static bool operator ==(AccountBalance x, AccountBalance y)
    {
        if (x.zl == y.zl && x.gr == y.gr)
        {
            return true;
        }

        return false;
    }

    public static bool operator !=(AccountBalance x, AccountBalance y)
    {
        return !(x == y);
    }

    public static AccountBalance operator +(AccountBalance x, AccountBalance y)
    {
        uint tempZl = x.zl + y.zl;
        ushort tempGr = (ushort)(x.Gr + y.Gr);
        
        uint temp = (uint) (tempGr / 100);
        tempZl += temp;
        tempGr = (ushort) (tempGr - temp * 100);
        
        return new AccountBalance(tempZl, tempGr);
    }

    public AccountBalance(AccountBalance ab)
    {
        Gr = ab.Gr;
        zl = ab.zl;
    }

    public override string ToString()
    {
        return zl + "zł " + Gr + "gr";
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is AccountBalance))
        {
            return false;
        }
        return (this == (AccountBalance) obj);
    }

    public override int GetHashCode()
    {
        return (this.zl * 4 + this.Gr * 20).GetHashCode();
    }
}