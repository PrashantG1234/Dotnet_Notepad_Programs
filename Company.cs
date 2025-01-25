public class Company{
    int totalEmp;
    string compName;
    string location;
    decimal perYearRevenue;
    public string CompDetails(){
        return $"company name: {compName} location: {location} total employees: {totalEmp} per year revenue: {perYearRevenue}";
    }
    public Company(int totalEmp,string compName,string location,decimal perYearRevenue){
        this.totalEmp = totalEmp;
        this.compName = compName;
        this.location = location;
        this.perYearRevenue = perYearRevenue;
    }
    public object this[int index]{
        get{
            if (index==0)
            {
                return totalEmp;
            }else if(index==1){
                return compName;
            }else if(index==2){
                return location;
            }else if(index==3){
                return perYearRevenue;
            }
            return null;
        }
        
    }
}