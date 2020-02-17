using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(5);
        arrayList.Add(10);
        arrayList.Add(15);
        arrayList.Add("test");
        arrayList.Add(new Test("this is the value from the test class instance"));

        List<int> listInteger = new List<int>();
        listInteger.Add(5);
        listInteger.Add(10);
        listInteger.Add(15);
        listInteger.Add(20);
        listInteger.Add(25);

        List<string> listString = new List<string>();
        listString.Add("test1");
        listString.Add("test2");
        listString.Add("test3");
        listString.Add("test4");
        listString.Add("test5");
        
        List<Test> listTest = new List<Test>();
        listTest.Add(new Test("test object1"));
        listTest.Add(new Test("test object2"));
        listTest.Add(new Test("test object3"));
        listTest.Add(new Test("test object4"));
        listTest.Add(new Test("test object5"));
        
        for (int i = 0; i < arrayList.Count; i++)
        {
            // Console.WriteLine(((Test)arrayList[4]).testString);
            // Console.WriteLine(arrayList[i].ToString());
            // Console.WriteLine(listInteger[i]);
            // Console.WriteLine(listString[i]);
            Console.WriteLine(listTest[i].testString);
        }
        
        var zm = new Normal<string>();
        zm.giveValue("this is text from normal class");
        Console.WriteLine(zm.returnValue());
        Console.ReadLine();
    }
}

class Test
{
    public string testString
    {
        get;
        private set;
    }

    public Test(string testString)
    {
        this.testString = testString;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

class Normal<anything>
{
    private anything genericVariableNameWhatever;

    public anything returnValue()
    {
        return genericVariableNameWhatever;
    }

    public void giveValue(anything genericVariableNameWhatever)
    {
        this.genericVariableNameWhatever = genericVariableNameWhatever;
    }
}