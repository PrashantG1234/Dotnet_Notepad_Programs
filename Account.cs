class Account{
	public String[] customers = ["12345:John:34000","54321:David:44000","11111:Tom:32000"];
	public int cId;
	public String cName;
	public double bal;
	public static double ir;
	
	public Account(int cId){
		for(int i=0;i<customers.Length;i++){
			string cInfo[] = customers[i].split(":");	
			if(cInfo[0]==cId.ToString()){
				cName = 	