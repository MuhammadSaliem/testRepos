using System;
class CLS_Person{
    private int age;
    private string fname;
    private string lname;
 

    public int Age { get => age; set => age=value; }
    public string Fname { get => fname; set => fname = value; }
    public string Lname { get => lname; set => lname = value; }

    public CLS_Person() {}

    public CLS_Person(int age , string first_name , string last_name )
    {
        Age = age;
        Fname = first_name;
        Lname = last_name;
    }

    public string FullName { get => fname+' '+lname;  }

    public string info => age +" "+ FullName;
}