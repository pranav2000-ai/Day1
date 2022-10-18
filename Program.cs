interface IGovtRules
{
    public double EmployeePF(double basicSalary);
    public string LeaVeDetails();
    public double gratuityAmount(float serviceCompleted,double basicSalary);
    
}

class TCS: IGovtRules
{
    int empid;
    string name;
    string dept;
    string desg;
    double basicSalary;
    public TCS(int empid,string name,string dept,string desg,double basicSalary)
    {
        this.empid = empid;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }
    public double EmployeePF(double basicSalary)
    {
        return( 0.12+0.833+0.367)*basicSalary;
    }
    public string LeaVeDetails()
    {
        return "1-CL 12-SL 10-PL";  
    }
    public double gratuityAmount(float serviceCompleted,double basicSalary)
    {
        if(serviceCompleted>20)
            return 3.0*basicSalary;
        else if(serviceCompleted>10)
            return 2.0*basicSalary;
        else if(serviceCompleted>5)
            return 1.0*basicSalary;
        else
            return 0.0;
    }
}
class WellsFargo: IGovtRules
{
    int empid;
    string name;
    string dept;
    string desg;
    double basicSalary;
    public  WellsFargo(int empid,string name,string dept,string desg,double basicSalary)
    {
        this.empid = empid;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }
    public double EmployeePF(double basicSalary)
    {
        return( 0.12+0.12)*basicSalary;
    }
    public string LeaVeDetails()
    {
        return "2-CL 5-SL 5-PL";  
    }
    public double gratuityAmount(float serviceCompleted,double basicSalary)
    {
        if(serviceCompleted>20)
            return 3.0*basicSalary;
        else if(serviceCompleted>10)
            return 2.0*basicSalary;
        else if(serviceCompleted>5)
            return 1.0*basicSalary;
        else
            return 0.0;
    }
}
class Program
{
    static void Main()
    {
        TCS obj1=new TCS(1,"pk","ti","pa",12000);
        Console.WriteLine(obj1.EmployeePF(12000));
        Console.WriteLine(obj1.LeaVeDetails());
        Console.WriteLine(obj1.gratuityAmount(7,12000));

        
        WellsFargo obj2=new WellsFargo(2,"as","ti","pa",36000);
        Console.WriteLine(obj2.EmployeePF(36000));
        Console.WriteLine(obj2.LeaVeDetails());
        Console.WriteLine(obj2.gratuityAmount(15,36000));
    }
}